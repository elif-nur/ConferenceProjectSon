using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NspDbContext:DbContext
    {
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<FirstPage> FirstPages { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MisionVision> MisionVisions { get; set; }
        public DbSet<InvitedSpeaker> InvitedSpeakers { get; set; }
        public DbSet<Scientific> Scientifics { get; set; }
        public DbSet<OrganisingSpeaker> OrganisingSpeakers { get; set; }
    }
}
