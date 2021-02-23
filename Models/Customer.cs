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

        [NotMapped]
        public List<string> States 
        {   "Alabama",
            "Alaska",
            "Arizona", 
            "Arkansas", 
            "California", 
            "Colorado", 
            "Connecticut", 
            "Delaware", 
            "Florida", 
            "Georgia", 
            "Hawaii", 
            "Idaho", 
            "Illinois", 
            "Indiana", 
            "Iowa", 
            "Kansas",
            "Kentucky", 
            "Louisiana", 
            "Maine", 
            "Maryland",
            "Massachusetts", 
            "Michigan",
            "Minnesota", 
            "Mississippi", 
            "Missouri", 
            "Montana", 
            "Nebraska", 
            "Nevada", 
            "New Hampshire",
            "New Jersey", 
            "New Mexico",
            "New York", 
            "North Carolina", 
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"
        }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        
    }
}
