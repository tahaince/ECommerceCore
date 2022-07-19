using BussinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public Brand GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetList()
        {
            return _brandDal.GetList();
        }

        public void TAdd(Brand t)
        {
            _brandDal.Insert(t);
        }

        public void TDelete(Brand t)
        {
            _brandDal.Delete(t);
        }

        public List<Brand> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Brand t)
        {
            _brandDal.Update(t);
        }
    }
}
