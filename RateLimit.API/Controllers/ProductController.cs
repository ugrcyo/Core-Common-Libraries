using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RateLimit.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult getProduct()
        {
            return Ok(new { Id = 1, Name = "Kalem", Price = 20 });
        }

        [HttpGet("{name}/{price}")]
        public IActionResult getProduct(string name,int price)
        {
            return Ok(name);
        }

        [HttpPost]
        public IActionResult saveProduct()
        {
            return Ok(new { Status = "Success" });
        }
        [HttpPut]
        public IActionResult updateProduct()
        {
            return Ok(new { Status = "Başarılı!" });
        }
    }
}
