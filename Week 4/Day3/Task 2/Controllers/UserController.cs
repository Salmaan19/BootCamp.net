using Microsoft.AspNetCore.Mvc;

namespace Task_2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AttributeRouting(int id ,string name)
        {
            return View();
        }
    }
}
