using EventSphere.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventSphere.ViewModels
{
    public class SocietyViewModel
    {
        public User  user { get; set; }
        public SocietyDetails detail { get; set; }
        public Society society { get; set; }
    }
    public class SocietyDetailviewModel
    {
        public int SocietyID { get; set; }
        public string SocietySupervisorName { get; set; }
        public HttpPostedFileBase SocietySupervisorImage { get; set; }
        public string SocietyPresidentName { get; set; }
        public HttpPostedFileBase SocietyPresidentImage { get; set; }
        public string SocietyVicePresidentName { get; set; }
        public HttpPostedFileBase SocietyVicePresidentImage { get; set; }
        public string SocietyFinanceSecreteryName { get; set; }
        public HttpPostedFileBase SocietyFinanceSecreteryImage { get; set; }
    }
}