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
    public class OrderSepetManager : IOrderSepetService
    {
        IOrderSepetDal _orderSepetDal;

        public OrderSepetManager(IOrderSepetDal orderSepetDal)
        {
            _orderSepetDal = orderSepetDal;
        }

        public OrderSepet GetById(int id)
        {
            return _orderSepetDal.GetByID(id);
        }

        public List<OrderSepet> GetList()
        {
            return _orderSepetDal.GetList();
        }

        public List<OrderSepet> GetOrderSepetsWithProducts()
        {
            return _orderSepetDal.GetOrderSepetsWithProduct();
        }

        public void TAdd(OrderSepet t)
        {
            _orderSepetDal.Insert(t);
        }

        public void TDelete(OrderSepet t)
        {
            throw new NotImplementedException();
        }

        public List<OrderSepet> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(OrderSepet t)
        {
            throw new NotImplementedException();
        }
    }
}
