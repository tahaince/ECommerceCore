using BussinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.Product
{
    public class ProductComment:ViewComponent
    {
        CommentManager cm = new CommentManager(new EFCommentDal());

        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetCommentWithUserandProduct(id);
            return View(values);

        }
    }
}
