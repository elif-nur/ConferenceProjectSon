using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFooterService
    {
        void Add(Footer footer);
        void Update(Footer footer);
        void Delete(Footer footer);
        List<Footer> GetAll();
        Footer Get(int footerId);
    }
}
