using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Controllers
{
    public class PickUpTrackerController : Controller
    {
        // GET: PickUpTrackerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PickUpTrackerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PickUpTrackerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PickUpTrackerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PickUpTrackerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PickUpTrackerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PickUpTrackerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PickUpTrackerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
