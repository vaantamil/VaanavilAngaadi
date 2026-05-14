using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VaanavilAngaadi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var products = new[]
            {
            new { Id = 1, Name = "Apple", Price = 120 },
            new { Id = 2, Name = "Orange", Price = 80 }
        };

            return Ok(products);
        }
    }
}
