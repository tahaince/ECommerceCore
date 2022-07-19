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
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public OrderDetail GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(OrderDetail t)
        {
            _orderDetailDal.Insert(t);
        }

        public void TDelete(OrderDetail t)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(OrderDetail t)
        {
            throw new NotImplementedException();
        }
    }
}
