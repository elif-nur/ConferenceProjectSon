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
    public class EfInvitedSpeakerDal : IInvitedSpeakerDal
    {
        public void Add(InvitedSpeaker entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(InvitedSpeaker entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public InvitedSpeaker Get(Expression<Func<InvitedSpeaker, bool>> filter)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return context.Set<InvitedSpeaker>().FirstOrDefault(filter);
            }
        }

        public List<InvitedSpeaker> GetAll(Expression<Func<InvitedSpeaker, bool>> filter = null)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return filter == null ? context.Set<InvitedSpeaker>().ToList() : context.Set<InvitedSpeaker>().Where(filter).ToList();
            }
        }

        public void Update(InvitedSpeaker entity)
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
