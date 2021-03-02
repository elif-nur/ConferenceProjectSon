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
    public class MisionVisionManager : IMisionVisionService
    {
        IMisionVisionDal _misionVisionDal;

        public MisionVisionManager(IMisionVisionDal misionVisionDal)
        {
            _misionVisionDal = misionVisionDal;
        }

        public void Add(MisionVision misionVision)
        {
            _misionVisionDal.Add(misionVision);
        }

        public void Delete(MisionVision misionVision)
        {
            _misionVisionDal.Delete(misionVision);
        }

        public MisionVision Get(int misionvisionId)
        {
            return _misionVisionDal.Get(x => x.Id == misionvisionId);
        }

        public List<MisionVision> GetAll()
        {
            return _misionVisionDal.GetAll();
        }

        public void Update(MisionVision misionVision)
        {
            _misionVisionDal.Update(misionVision);
        }
    }
}
