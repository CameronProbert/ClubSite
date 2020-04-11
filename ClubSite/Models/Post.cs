using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubSite.Models
{
    public class Post : IAuditable
    {
        public ICollection<Reply> Replies { get; }
        public string Text { get; set; }
        public Member Author { get; }

        public DateTimeOffset DateCreated { get; }
        public DateTimeOffset DateLastUpdated { get; }
        public Member CreatedBy { get; }
        public Member LastUpdatedBy { get; }
    }
}
