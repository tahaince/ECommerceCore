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
    public class OrderManager : IOrderService
    {
        IOrderDal _orderdal;
        public Order GetById(int id)
        {
            return _orderdal.GetByID(id);
        }

        public List<Order> GetList()
        {
            return _orderdal.GetList();
        }

        public void TAdd(Order t)
        {
            _orderdal.Insert(t);
        }

        public void TDelete(Order t)
        {
            _orderdal.Delete(t);
        }

        public List<Order> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Order t)
        {
            _orderdal.Update(t);
        }
    }
}
