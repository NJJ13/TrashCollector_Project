using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Zip Code")]
        [StringLength(10, MinimumLength =5)]
        public string ZipCode { get; set; }
        [Display(Name = "Pickup Day")]
        public string PickupDay { get; set; }
        public ICollection<Customer> Customers { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
