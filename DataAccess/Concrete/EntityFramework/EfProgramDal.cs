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
    public class EfProgramDal:IProgramDal
    {
        public void Add(Program entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Program entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Program Get(Expression<Func<Program, bool>> filter)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return context.Set<Program>().FirstOrDefault(filter);
            }
        }

        public List<Program> GetAll(Expression<Func<Program, bool>> filter = null)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return filter == null ? context.Set<Program>().ToList() : context.Set<Program>().Where(filter).ToList();
            }
        }

        public void Update(Program entity)
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
