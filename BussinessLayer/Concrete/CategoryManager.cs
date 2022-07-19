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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public Category GetById(int id)
        {
            return _categorydal.GetByID(id);
        }

        public List<Category> GetList()
        {
        return    _categorydal.GetList();
        }

        public void TAdd(Category t)
        {
            _categorydal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categorydal.Delete(t);
        }

        public List<Category> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Category t)
        {
            _categorydal.Update(t);
        }
    }
}
