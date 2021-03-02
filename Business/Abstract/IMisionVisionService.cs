using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMisionVisionService
    {
        void Add(MisionVision misionVision);
        void Update(MisionVision misionVision);
        void Delete(MisionVision misionVision);
        List<MisionVision> GetAll();
        MisionVision Get(int misionvisionId);
    }
}
