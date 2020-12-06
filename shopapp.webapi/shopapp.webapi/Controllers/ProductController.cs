using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using shopapp.business.Abstract;
using shopapp.dataaccess.Absract;
using shopapp.entity;

namespace shopapp.webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController:ControllerBase
    {
         private IProductService productService;



        public ProductController(IProductService _productServicey)
        {
            productService = _productServicey;
        }

        [HttpGet]
        public Product Get()
       {
            return productService.GetProduct();
        }
    }
}