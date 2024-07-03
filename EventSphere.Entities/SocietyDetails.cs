using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSphere.Entities
{
    public class SocietyDetails : BaseEntity
    {
        public int  SocietyID { get; set; }
        public string SocietySupervisorName { get; set; }
        public string SocietySupervisorImage { get; set; }
        public string SocietyPresidentName { get; set; }
        public string SocietyPresidentImage { get; set; }
        public string SocietyVicePresidentName { get; set; }
        public string SocietyVicePresidentImage { get; set; }
        public string SocietyFinanceSecreteryName { get; set; }
        public string SocietyFinanceSecreteryImage { get; set; }
    }
}
