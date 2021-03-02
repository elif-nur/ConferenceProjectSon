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
    public class EfMisionVisionDal:IMisionVisionDal
    {
        public void Add(MisionVision entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(MisionVision entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public MisionVision Get(Expression<Func<MisionVision, bool>> filter)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return context.Set<MisionVision>().FirstOrDefault(filter);
            }
        }

        public List<MisionVision> GetAll(Expression<Func<MisionVision, bool>> filter = null)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return filter == null ? context.Set<MisionVision>().ToList() : context.Set<MisionVision>().Where(filter).ToList();
            }
        }

        public void Update(MisionVision entity)
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
