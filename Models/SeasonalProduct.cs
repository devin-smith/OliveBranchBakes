using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveBranchBakes.Models
{
    public class SeasonalProduct : Product  // Inherits from Product class
    {
        public DateTime StartDate { get; set; } // The date when the seasonal product becomes available
        public DateTime EndDate { get; set; } // The date when the seasonal product is no longer available

        public override bool IsAvailable(DateTime date) // check whether the date falls within the defined seasnal range
        {
            return date.Date >= StartDate.Date &&
                   date.Date <= EndDate.Date;
        }
    }
}