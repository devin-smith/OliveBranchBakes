using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveBranchBakes.Models
{
    internal class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime PickupDate { get; set; }
        public string Status { get; set; } = "";
        public string AllergyNotes { get; set; } = "";
    }
}
