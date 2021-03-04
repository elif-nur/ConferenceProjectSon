using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInformationService
    {
        void Add(Information information);
        void Update(Information information);
        void Delete(Information information);
        List<Information> GetAll();
        Information Get(int informationId);
    }
}
