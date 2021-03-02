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
    public class FooterManager : IFooterService
    {
        IFooterDal _footerDal;

        public FooterManager(IFooterDal footerDal)
        {
            _footerDal = footerDal;
        }

        public void Add(Footer footer)
        {
            _footerDal.Add(footer);
        }

        public void Delete(Footer footer)
        {
            _footerDal.Delete(footer);
        }

        public Footer Get(int footerId)
        {
            return _footerDal.Get(x => x.Id == footerId);
        }

        public List<Footer> GetAll()
        {
            return _footerDal.GetAll();
        }

        public void Update(Footer footer)
        {
            _footerDal.Update(footer);
        }
    }
}
