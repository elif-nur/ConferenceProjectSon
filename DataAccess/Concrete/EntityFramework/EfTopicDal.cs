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

    public class EfTopicDal : ITopicDal
    {
        //NspDbContext _context = new NspDbContext();
        //public void Add(Topic topic)
        //{
        //    _context.Topics.Add(topic);
        //    _context.SaveChanges();
        //}

        //public void Delete(int topicId)
        //{
        //    var delete = _context.Topics.Find(topicId);
        //    _context.Topics.Remove(delete);
        //    _context.SaveChanges();
        //}

        //public Topic Get(int topicId)
        //{
        //    var list = _context.Topics.FirstOrDefault(x => x.Id == topicId);
        //    return list;
        //}

        //public List<Topic> GetAll()
        //{
        //    return _context.Topics.ToList();
        //}

        //public void Update(Topic topic)
        //{
        //    var update = _context.Topics.FirstOrDefault(x => x.Id == topic.Id);
        //    update.Description = topic.Description;
        //    _context.SaveChanges();
        //}
        public void Add(Topic entity)
        {
            using(NspDbContext context=new NspDbContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Topic entity)
        {
            using (NspDbContext context = new NspDbContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Topic Get(Expression<Func<Topic, bool>> filter)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return context.Set<Topic>().FirstOrDefault(filter);
            }
        }

        public List<Topic> GetAll(Expression<Func<Topic, bool>> filter = null)
        {
            using (NspDbContext context = new NspDbContext())
            {
                return filter == null ? context.Set<Topic>().ToList() : context.Set<Topic>().Where(filter).ToList();
            }
        }

        public void Update(Topic entity)
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
