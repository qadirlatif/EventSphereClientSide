using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSphere.Entities
{
    public class EventReview : BaseEntity
    {
        public string UserName { get; set; }
        public string Review { get; set; }
        public int EventID { get; set; }
    }
}
