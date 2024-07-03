using Microsoft.AspNet.Identity.EntityFramework;
using EventSphere.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSphere.Database
{
    public class DSContext :IdentityDbContext<User>,IDisposable
    {
        public DSContext() : base("ESConnectionStrings")
        {

        }

        public static DSContext Create()
        {
            return new DSContext();
        }

        public DbSet<Society> Societies { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventReview> EventReviews { get; set; }



    }
}
