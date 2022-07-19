using BussinessLayer.Concrete;
using DataAccsessLayer.Content;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        ProductManager pm = new ProductManager(new EFProductDal());

        [HttpGet]
        public IActionResult ProductList()
        {
            var values = pm.GetBrandWithProduct().Where(x=>x.BrandId==1).ToList();

            return Ok(pm.GetList());
        }
    }
}
