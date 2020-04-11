using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubSite.Models
{
    public class Booking : IAuditable
    {
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public int NumberOfDays => (EndDate - StartDate).Days;

        public DateTimeOffset DateCreated { get; }
        public DateTimeOffset DateLastUpdated { get; }
        public Member CreatedBy { get; }
        public Member LastUpdatedBy { get; }
    }
}
