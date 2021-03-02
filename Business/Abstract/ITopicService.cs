using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITopicService
    {
        void Add(Topic topic);
        void Update(Topic topic);
        void Delete(Topic topic);
        List<Topic> GetAll();
        Topic Get(int topicId);
    }
}
