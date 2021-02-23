using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double Zipcode { get; set; }
        [Display(Name = "Weekly PickUp Day")]
        public string WeeklyPickupDay { get; set; }
        [Display(Name = "Additional PickUp Date")]
        public DateTime? AdditionalPickUp { get; set; }
        [Display(Name = "Suspend Services Start Date")]
        public DateTime? SuspendPickUpStart { get; set; }
        [Display(Name = "Suspend Services End Date")]
        public DateTime? SuspendPickUpEnd { get; set; }
        [Display(Name = "Monthly Dues")]
        public double MonthlyDues { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        
    }
}
