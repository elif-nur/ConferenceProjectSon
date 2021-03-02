using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TopicManager : ITopicService
    {
        ITopicDal _topicDal;

        public TopicManager(ITopicDal topicDal)
        {
            _topicDal = topicDal;
        }

        public void Add(Topic topic)
        {
            _topicDal.Add(topic);
        }

        public void Delete(Topic topic)
        {
            _topicDal.Delete(topic);
        }

        public Topic Get(int topicId)
        {
            return _topicDal.Get(x=>x.Id==topicId);
        }

        public List<Topic> GetAll()
        {
            return _topicDal.GetAll();
        }

        public void Update(Topic topic)
        {
            _topicDal.Update(topic);
        }
    }
}
