using Microsoft.AspNetCore.Mvc;

namespace WebAppAndApi.Features.ProductMakes
{
    public class ProductMakesController : Controller
    {

        public ProductMakesController()
        {

        }
        public IActionResult MovieIndex()
        {
            return View();
        }
    }
}