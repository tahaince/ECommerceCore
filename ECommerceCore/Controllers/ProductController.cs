using BussinessLayer.Concrete;
using DataAccsessLayer.Content;
using DataAccsessLayer.EntityFramework;
using ECommerceCore.Models.JsonModels;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace ECommerceCore.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EFProductDal());
        CommentManager cm = new CommentManager(new EFCommentDal());


        public IActionResult Index(int id)
        {
            var values = pm.GetBrandWithProductById(id);
            var commentcount = cm.GetList().Where(x => x.ProductId == id).Count();
            ViewBag.comment = commentcount;
            return View(values);
        }

        public IActionResult ProductBrand(int id,int page=1)
        {
            var values = pm.GetBrandWithProduct().Where(x=>x.BrandId==id).ToList();
       
            return View(values);
        }
        public IActionResult ProductCategory(int id, int page = 1)
        {
            var values = pm.GetBrandWithProduct().Where(x => x.CategoryId == id).ToPagedList(page,2);

            return View(values);
        }

        public  IActionResult ProductSearch(string id)
        
        {
            var id2 = id.ToUpper();
            var id3 = id.ToUpper();
            var ilkharf = char.ToUpper(id[0]);

            var values = pm.GetBrandWithProduct().Where(x => x.Name.Contains(id2)||x.Name.Contains(id3) || x.Name.Contains(id)).ToList();

       //İlk harfi büyük yapmayı öğren 
            return View(values);
        }

        public IActionResult ProductFilter(int? price)
        {
            var values = pm.GetBrandWithProduct().Where(x=>x.Price==price).ToList();
            
            return View(values);
        }

        public async Task<IActionResult> Apideneme()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7129/api/ProductApi");
            var request = new HttpRequestMessage(HttpMethod.Get, "");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();

            var ProductDeSeri = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductJson>(result);
            var values = ProductDeSeri.ProductListe;
            return View(values);
        }
    }
}
