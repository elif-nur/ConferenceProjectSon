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
    public class RegistrationManager : IRegistrationService
    {
        IRegistrationDal _registrationDal;

        public RegistrationManager(IRegistrationDal registrationDal)
        {
            _registrationDal = registrationDal;
        }

        public void Add(Registration registration)
        {
            _registrationDal.Add(registration);
        }

        public void Delete(Registration registration)
        {
            _registrationDal.Delete(registration);
        }

        public Registration Get(int registrationId)
        {
            return _registrationDal.Get(x => x.Id == registrationId);
        }

        public List<Registration> GetAll()
        {
            return _registrationDal.GetAll();
        }

        public void Update(Registration registration)
        {
            _registrationDal.Update(registration);
        }
    }
}
