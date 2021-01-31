using Microsoft.AspNetCore.Mvc;
using NetCoreIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIntro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View(Product.products.ToList());
        }
        public IActionResult GetProduct(int productId)
        {
            return View(Product.products.FirstOrDefault(x => x.ID == productId));
        }
        public IActionResult GetProductsWithCategory(int categoryId)
        {
            return View(Product.products.Where(x => x.CategoryId == categoryId).ToList());
        }
    }
}
