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
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderdal;

        public SliderManager(ISliderDal sliderdal)
        {
            _sliderdal = sliderdal;
        }

        public Slider GetById(int id)
        {
            return _sliderdal.GetByID(id);
        }

        public List<Slider> GetList()
        {
            return _sliderdal.GetList(); ;
        }

        public void TAdd(Slider t)
        {
            _sliderdal.Insert(t);
        }

        public void TDelete(Slider t)
        {
            _sliderdal.Delete(t);
        }

        public List<Slider> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Slider t)
        {
            _sliderdal.Update(t);
        }
    }
}
