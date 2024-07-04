using EventSphere.Database;
using EventSphere.Entities;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSphere.Services
{
    public class EventServices
    {
        public static EventServices Instance
        {
            get
            {
                if (instance == null) instance = new EventServices();
                return instance;
            }
        }
        private static EventServices instance { get; set; }
        private EventServices()
        {
        }
        
        public Event GetEvent(int ID)
        {
            var context = new DSContext();
            return context.Events.Where(x => x.ID == ID).FirstOrDefault();

        }
        public List<Event> GetAllEventofSociety(int id)
        {
            var context = new DSContext();
            return context.Events.Where(x => x.SocietyID == id).ToList();
        }
        public List<Event> GetTopEvents()
        {
            var context = new DSContext();
            return context.Events.OrderByDescending(x=>x.ID).Take(4).ToList();
        }
        //public WorkEvent GetWorkEvent(string id = "")
        //{
        //    var context = new DSContext();
        //    var workEventFound = context.WorkEvents.Where(x => x.WorkEventID == id).FirstOrDefault();
        //    return workEventFound;
        //}
        //public void updateEmail(WorkEvent workEvent)
        //{
        //    var context = new DSContext();
        //    context.Entry(workEvent).State = EntityState.Modified;
        //    context.SaveChanges();
        //}
        public void SaveEvent(Event Event)
        {
            var context = new DSContext();
            context.Events.Add(Event);
            context.SaveChanges();
        }
        public void deleteEvent(int ID)
        {
            var context = new DSContext();
            var target = context.Events.Where(x => x.ID == ID).FirstOrDefault();
            context.Events.Remove(target);
            context.SaveChanges();
        }

        public void UpdateEvent(Event Event)
        {
            var context = new DSContext();
            context.Entry(Event).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
