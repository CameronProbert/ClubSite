using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubSite.Models
{
    public class Reply : IAuditable
    {
        public Post Post { get; }

        public DateTimeOffset DateCreated { get; }
        public DateTimeOffset DateLastUpdated { get; }
        public Member CreatedBy { get; }
        public Member LastUpdatedBy { get; }
    }
}
