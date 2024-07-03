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
    public class SocietyServices
    {
        #region Singleton
        public static SocietyServices Instance
        {
            get
            {
                if (instance == null) instance = new SocietyServices();
                return instance;
            }
        }
        private static SocietyServices instance { get; set; }
        private SocietyServices()
        {
        }
        #endregion

        public List<Society> getAllActiveSocieties()
        {
            var context = new DSContext();
            return context.Societies.Where(x => x.IsActiveCommunity == true).ToList();
        }
        public List<Society> GetAllSocieties()
        {
            var context = new DSContext();
            return context.Societies.ToList();
        }
        //public WorkSociety GetWorkSociety(string id = "")
        //{
        //    var context = new DSContext();
        //    var workSocietyFound = context.WorkSocietys.Where(x => x.WorkSocietyID == id).FirstOrDefault();
        //    return workSocietyFound;
        //}
        //public void updateEmail(WorkSociety workSociety)
        //{
        //    var context = new DSContext();
        //    context.Entry(workSociety).State = EntityState.Modified;
        //    context.SaveChanges();
        //}
        public void SaveSociety(Society Society)
        {
            var context = new DSContext();
            context.Societies.Add(Society);
            context.SaveChanges();
        }

        public void UpdateSociety(Society Society)
        {
            var context = new DSContext();
            context.Entry(Society).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}