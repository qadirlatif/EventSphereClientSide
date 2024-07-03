using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSphere.Entities
{
    public class Society : BaseEntity
    {
        public string  SocietyName { get; set; }
        public string   SocietyIcon { get; set; }
        public bool IsActiveCommunity { get; set; }
    }
}
