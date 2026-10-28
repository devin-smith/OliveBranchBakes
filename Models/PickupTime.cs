using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OliveBranchBakes.Models
{
    public class PickupTime
    {
        public int Id { get; set; }

        public DateTime ScheduledDateTime { get; set; }

        public bool IsAvailable { get; set; } = true;

        public string Notes { get; set; } = "";

        // Empty constructor supports JSON loading.
        public PickupTime()
        {
        }

        // Creates a pickup time with a specified date.
        public PickupTime(int id, DateTime scheduledDateTime)
        {
            if (scheduledDateTime == DateTime.MinValue)
            {
                throw new ArgumentException(
                    "A valid pickup date and time is required.");
            }

            Id = id;
            ScheduledDateTime = scheduledDateTime;
        }

        // Returns a readable pickup date and time.
        // This formats the date for display in the UI.
        public string GetDisplayText()
        {
            return ScheduledDateTime.ToString(
                "MMMM dd, yyyy h:mm tt");
        }
    }
}
