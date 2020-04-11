using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubSite.Models
{
    public class Booking : BaseModel
    {
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public int NumberOfDays => (EndDate - StartDate).Days;
    }
}
