using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrganisingDal:IOrganisingDal
    {
        public void Add(OrganisingSpeaker entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(OrganisingSpeaker entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public OrganisingSpeaker Get(Expression<Func<OrganisingSpeaker, bool>> filter)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return context.Set<OrganisingSpeaker>().FirstOrDefault(filter);
            }
        }

        public List<OrganisingSpeaker> GetAll(Expression<Func<OrganisingSpeaker, bool>> filter = null)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return filter == null ? context.Set<OrganisingSpeaker>().ToList() : context.Set<OrganisingSpeaker>().Where(filter).ToList();
            }
        }

        public void Update(OrganisingSpeaker entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
