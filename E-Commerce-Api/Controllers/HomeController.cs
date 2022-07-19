using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Api.Controllers
{
    public class HomeController : Controller
    {

        public async Task< IActionResult> Index()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7129/api/ProductApi");
            var request = new HttpRequestMessage(HttpMethod.Get, "");
            var response = await client.SendAsync(request);
            var result = response.Content.ReadAsStringAsync();

            return View();
        }
    }
}
