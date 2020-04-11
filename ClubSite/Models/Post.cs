using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubSite.Models
{
    public class Post : BaseModel
    {
        public Post()
        {
            Replies = new HashSet<Reply>();
        }

        public ICollection<Reply> Replies { get; }
        public string Text { get; set; }
        public Member Author { get; }
    }
}
