using EAD_Project0.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_Project0.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public List<Product> Get()
        {
            List<Product> products = new List<Product>  ()

            { new Product(1, "Table", 8000, Category.Furniture),
                new Product(2, "Jeans", 2000, Category.Cloth),
                new Product(3, "FootBall", 1000, Category.Sport),
            };
            return products;
        }
    }
}
