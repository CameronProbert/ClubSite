using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubSite.Models
{
    public class Reply : BaseModel
    {
        public Post Post { get; }
    }
}
