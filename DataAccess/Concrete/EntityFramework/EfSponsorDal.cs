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
    public class EfSponsorDal : ISponsorDal
    {
        public void Add(Sponsor entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Sponsor entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
           
        }

        public Sponsor Get(Expression<Func<Sponsor, bool>> filter)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return context.Set<Sponsor>().FirstOrDefault(filter);
            }
        }

        public List<Sponsor> GetAll(Expression<Func<Sponsor, bool>> filter = null)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return filter == null ? context.Set<Sponsor>().ToList() : context.Set<Sponsor>().Where(filter).ToList();
            }
        }

        public void Update(Sponsor entity)
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
