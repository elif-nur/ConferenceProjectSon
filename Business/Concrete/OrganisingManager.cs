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
    public class OrganisingManager : IOrganisingService
    {
        IOrganisingDal _organisingDal;

        public OrganisingManager(IOrganisingDal organisingDal)
        {
            _organisingDal = organisingDal;
        }

        public void Add(OrganisingSpeaker organisingSpeaker)
        {
            _organisingDal.Add(organisingSpeaker);

        }

        public void Delete(OrganisingSpeaker organisingSpeaker)
        {
            _organisingDal.Delete(organisingSpeaker);
        }

        public OrganisingSpeaker Get(int organisingId)
        {
            return _organisingDal.Get(x => x.Id == organisingId);
        }

        public List<OrganisingSpeaker> GetAll()
        {
            return _organisingDal.GetAll();
        }

        public void Update(OrganisingSpeaker organisingSpeaker)
        {
            _organisingDal.Update(organisingSpeaker);
        }
    }
}
