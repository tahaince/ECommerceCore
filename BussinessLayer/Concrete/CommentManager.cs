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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentdal;

        public CommentManager(ICommentDal commentdal)
        {
            _commentdal = commentdal;
        }

        public Comment  GetById(int id)
        {
          return  _commentdal.GetByID(id);
        }

        public List<Comment> GetCommentWithUserandProduct(int id)
        {
            return _commentdal.GetCommentWithUserandProduct(id);
        }

        public List<Comment> GetList()
        {
           return _commentdal.GetList();
        }

        public void TAdd(Comment t)
        {
            _commentdal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
