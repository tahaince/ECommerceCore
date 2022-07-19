using DataAccsessLayer.Abstract;
using DataAccsessLayer.Content;
using DataAccsessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EFCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetCommentWithUserandProduct(int id)
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.Product).Include(z=>z.AppUser).Where(x=>x.ProductId==id).ToList();

            }
        }
    }
}

