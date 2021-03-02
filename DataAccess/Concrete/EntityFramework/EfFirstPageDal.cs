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
    public class EfFirstPageDal : IFirstPageDal
    {
        public void Add(FirstPage entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(FirstPage entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public FirstPage Get(Expression<Func<FirstPage, bool>> filter)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return context.Set<FirstPage>().FirstOrDefault(filter);
            }
        }

        public List<FirstPage> GetAll(Expression<Func<FirstPage, bool>> filter = null)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return filter == null ? context.Set<FirstPage>().ToList() : context.Set<FirstPage>().Where(filter).ToList();
            }
        }

        public void Update(FirstPage entity)
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
