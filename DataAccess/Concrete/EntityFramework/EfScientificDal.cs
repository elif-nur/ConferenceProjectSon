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
    public class EfScientificDal : IScientificDal
    {
        public void Add(Scientific entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Scientific entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Scientific Get(Expression<Func<Scientific, bool>> filter)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return context.Set<Scientific>().FirstOrDefault(filter);
            }
        }

        public List<Scientific> GetAll(Expression<Func<Scientific, bool>> filter = null)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return filter == null ? context.Set<Scientific>().ToList() : context.Set<Scientific>().Where(filter).ToList();
            }
        }

        public void Update(Scientific entity)
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
