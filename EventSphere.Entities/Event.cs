using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSphere.Entities
{
    public class Event : BaseEntity
    {
        public string EventName { get; set; }
        public DateTime EventDateandTime { get; set; }
        public string EventVenue { get; set; }
        public string EventCity { get; set; }
        public int SocietyID { get; set; }
        public string EventIcon { get; set; }
    }
}
