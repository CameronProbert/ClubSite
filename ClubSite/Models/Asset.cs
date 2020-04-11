using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubSite.Models
{
    public class Asset : BaseModel
    {
        public Uri Url { get; set; }
        public string Description { get; set; }
    }
}
