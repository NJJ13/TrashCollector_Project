using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class PickUpTracker
    {
        [Key]
        public int PickUpTrackingId { get; set; }
        public int ScheduledPickUpThisMonth { get; set; }

        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; }
    }
}
