using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveBranchBakes.Models
{
    // THIS CLASS IS DESIGNED TO ESTABLISH BUSINESS RULES FOR THE BAKERY APPLICATION.
    public class BakerySettings
    {
        // Standard sales tax for this project.
        public decimal TaxRate { get; set; } = 0.085m;

        // O5: Quantity limits from our Variant Card.
        public int GuestQuantityLimit { get; set; } = 6;

        public int CustomerQuantityLimit { get; set; } = 24;

        // P2: Loyalty discount requirements.
        public int LoyaltyOrderThreshold { get; set; } = 3;

        public decimal LoyaltyDiscountRate { get; set; }
            = 0.10m;

        // General pickup requirements.
        public int MinimumPickupHours { get; set; } = 24;

        public int MaximumPickupDays { get; set; } = 30;
    }
}
