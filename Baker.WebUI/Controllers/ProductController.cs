using Baker.WebUI.Dtos.Product;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Baker.WebUI.Controllers
{
    public class ProductController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> ProductList()
        {
            var client=_httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7021/api/Product/with-category");
            if (response.IsSuccessStatusCode)
            {
                var json=await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ProductWithCategoryDto>>(json);
                return View(values);
            }
            return View();
        }
    }
}
//api server
//uı client