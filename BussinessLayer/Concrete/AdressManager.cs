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
    public class AdressManager : IAddresService
    {
        IAdresDal _adresdal;

        public AdressManager(IAdresDal adresdal)
        {
            _adresdal = adresdal;
        }

        public Addres GetById(int id)
        {
            return _adresdal.GetByID(id);
        }

        public List<Addres> GetList()
        {
            return _adresdal.GetList();
        }

        public void TAdd(Addres t)
        {
            _adresdal.Insert(t);
        }

        public void TDelete(Addres t)
        {
            _adresdal.Delete(t);
        }

        public List<Addres> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Addres t)
        {
            _adresdal.Update(t);
        }
    }
}
