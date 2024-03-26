using Microsoft.AspNetCore.Mvc;

namespace buoi2_TH.Controllers
{
    public class CategoryController : Controller
    {   
        public IActionResult Index()
        {
            return View();
        }
    }
}
