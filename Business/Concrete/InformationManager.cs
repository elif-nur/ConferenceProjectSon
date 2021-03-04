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
    public class InformationManager : IInformationService
    {
        IInformationDal _informationDal;

        public InformationManager(IInformationDal informationDal)
        {
            _informationDal = informationDal;
        }

        public void Add(Information information)
        {
            _informationDal.Add(information);
        }

        public void Delete(Information information)
        {
            _informationDal.Delete(information);
        }

        public Information Get(int informationId)
        {
            return _informationDal.Get(x => x.Id == informationId);
        }

        public List<Information> GetAll()
        {
            return _informationDal.GetAll();
        }

        public void Update(Information information)
        {
            _informationDal.Update(information);
        }
    }
}
