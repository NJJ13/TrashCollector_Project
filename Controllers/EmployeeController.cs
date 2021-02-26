using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employee
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Employees.Include(e => e.IdentityUser);
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employees.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            if(employee == null)
            {
                return RedirectToAction("Create");
            }
            var currentday = DateTime.Today.ToString("dddd");
            var customersInArea = _context.Customers.Where(c => c.ZipCode == employee.ZipCode && c.WeeklyPickupDay == currentday);
            
            return View(customersInArea);
        }
        public async Task<IActionResult> Filter()
        {
            var applicationDbContext = _context.Employees.Include(e => e.IdentityUser);
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employees.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            var customersInArea = _context.Customers.Where(c => c.ZipCode == employee.ZipCode && c.WeeklyPickupDay == employee.PickupDay);

            return View(customersInArea);
        }
        public async Task<IActionResult> AdditionalServices()
        {
            var applicationDbContext = _context.Employees.Include(e => e.IdentityUser);
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employees.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            var customersInArea = _context.Customers.Where(c => c.ZipCode == employee.ZipCode && c.AdditionalPickUp.HasValue);

            return View(customersInArea);
        }
        // GET: Employee/Details/5
        public async Task<IActionResult> Details()
        {
           
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }
        public async Task<IActionResult> CustomerDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(c => c.CustomerID == id).FirstOrDefault();
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = userId;
                DateTime dayValue = DateTime.Today;
                employee.PickupDay = dayValue.ToString("dddd");
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View();
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            if (id != employee.EmployeeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Employee employeeToEdit = _context.Employees.Find(id);
                    employeeToEdit.FirstName = employee.FirstName;
                    employeeToEdit.LastName = employee.LastName;
                    employeeToEdit.PickupDay = employee.PickupDay;
                    employeeToEdit.ZipCode = employee.ZipCode;
                    _context.Update(employeeToEdit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Filter");
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.EmployeeID == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeID == id);
        }
     
        public async Task<IActionResult> ConfirmPickUp(int id)
        {
            Customer customerToCharge = _context.Customers.Find(id);
            if (SuspensionCheck(customerToCharge))
            {
                return RedirectToAction("CollectionIncomplete");
            }
            if(customerToCharge.WeeklyPickupDay == DateTime.Today.DayOfWeek.ToString())
            {
                if (LastCollectionCheck(customerToCharge) == true)
                {
                    return RedirectToAction("CollectionIncomplete");
                }
                CustomerChargeForPickup(customerToCharge);
            }
            if (customerToCharge.AdditionalPickUp.HasValue)
            {
                if(customerToCharge.AdditionalPickUp.Value.Month == DateTime.Today.Month && customerToCharge.AdditionalPickUp.Value.Day == DateTime.Today.Day && customerToCharge.AdditionalPickUp.Value.Year == DateTime.Today.Year)
                {
                    customerToCharge.AdditionalPickUp = null;
                    CustomerChargeForPickup(customerToCharge);
                }
            }
            _context.Update(customerToCharge);
            await _context.SaveChangesAsync();
            return RedirectToAction("Filter");
        }
        public void CustomerChargeForPickup(Customer customer)
        {
            double pickUpRate;
            double flatRate = 10.00;
            pickUpRate = flatRate;
            customer.MonthlyDues += pickUpRate;
            customer.LastCollection = DateTime.Now;
            _context.Update(customer);
        }

        public bool LastCollectionCheck(Customer customer)
        {
            bool Pickupcollected = false;
            if (customer.LastCollection.HasValue)
            {
                if (customer.LastCollection.Value.Month == DateTime.Today.Month && customer.LastCollection.Value.Day == DateTime.Today.Day && customer.LastCollection.Value.Year == DateTime.Today.Year)
                {
                    Pickupcollected = true;
                }
            }
            return Pickupcollected;
        }
        public bool SuspensionCheck(Customer customer)
        {
            bool AccountSuspended = false;
            if(customer.SuspendPickUpStart.HasValue)
            {
                if (customer.SuspendPickUpEnd.HasValue)
                {
                    if(customer.SuspendPickUpEnd.Value.Year >= DateTime.Today.Year && customer.SuspendPickUpEnd.Value.Month >= DateTime.Today.Month && customer.SuspendPickUpEnd.Value.Day >= DateTime.Now.Day)
                    {
                        AccountSuspended = true;
                    }
                }
                else
                {
                    AccountSuspended = true;
                }
            }
            return AccountSuspended;
        }
        public async Task<IActionResult> CollectionIncomplete()
        {

            return View();
        }
    }
}
