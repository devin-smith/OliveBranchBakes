using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveBranchBakes.Services
{
    public class SchedulingService
    {
        // O5: Check quantity limits.
        public bool IsValidQuantity(
            int quantity, bool isSignedIn)
        {
            int maxQuantity = isSignedIn ? 24 : 6;

            return quantity >= 1 &&
                   quantity <= maxQuantity;
        }

        // Check pickup date requirements.
        public bool IsValidPickupDate(
            DateTime pickupDate)
        {
            DateTime now = DateTime.Now;

            if (pickupDate < now.AddHours(24))
                return false;

            if (pickupDate > now.AddDays(30))
                return false;

            // Christmas Day
            if (pickupDate.Month == 12 &&
                pickupDate.Day == 25)
                return false;

            // Thanksgiving: fourth Thursday
            // in November.
            if (pickupDate.Month == 11 &&
                pickupDate.DayOfWeek == DayOfWeek.Thursday)
            {
                int thursdayNumber =
                    (pickupDate.Day - 1) / 7 + 1;

                if (thursdayNumber == 4)
                    return false;
            }

            return true;
        }

        // User-friendly quantity message.
        public string GetQuantityMessage(
            bool isSignedIn)
        {
            if (isSignedIn)
            {
                return "Signed-in customers can order up to 24 of each item.";
            }

            return "Guest customers can order up to 6 of each item. Sign in to increase your limit to 24.";
        }
    }
}
