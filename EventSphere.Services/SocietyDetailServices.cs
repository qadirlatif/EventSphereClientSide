using EventSphere.Database;
using EventSphere.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSphere.Services
{
    public class SocietyDetailServices
    {
        public static SocietyDetailServices Instance
        {
            get
            {
                if (instance == null) instance = new SocietyDetailServices();
                return instance;
            }
        }
        private static SocietyDetailServices instance { get; set; }
        private SocietyDetailServices()
        {
        }

        
        public SocietyDetails GetdetailsofASociety(int id)
        {
            var context = new DSContext();
            return context.SocietyDetails.Where(x=>x.SocietyID == id).FirstOrDefault();
        }
        //public WorkSocietyDetail GetWorkSocietyDetail(string id = "")
        //{
        //    var context = new DSContext();
        //    var workSocietyDetailFound = context.WorkSocietyDetails.Where(x => x.WorkSocietyDetailID == id).FirstOrDefault();
        //    return workSocietyDetailFound;
        //}
        //public void updateEmail(WorkSocietyDetail workSocietyDetail)
        //{
        //    var context = new DSContext();
        //    context.Entry(workSocietyDetail).State = EntityState.Modified;
        //    context.SaveChanges();
        //}
        public void SaveSocietyDetail(SocietyDetails SocietyDetail)
        {
            var context = new DSContext();
            context.SocietyDetails.Add(SocietyDetail);
            context.SaveChanges();
        }

        public void UpdateSocietyDetail(SocietyDetails SocietyDetail)
        {
            var context = new DSContext();
            context.Entry(SocietyDetail).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
