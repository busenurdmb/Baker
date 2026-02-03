using Microsoft.AspNetCore.Mvc;

namespace Baker.WebUI.Controllers
{
    public class DasboardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DasboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:7021/api/Product/CountProduct");
            var jsonData1 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.ProductCount = jsonData1;
            return View();
        }
    }
}
