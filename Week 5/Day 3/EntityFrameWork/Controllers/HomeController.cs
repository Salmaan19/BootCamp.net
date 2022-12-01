using EntityFrameWork.Models;
using EntityFrameWork.MyDbContext;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityFrameWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private StudentMS _studentMS;


        public HomeController(ILogger<HomeController> logger, StudentMS studentMS)
        
        {
            _studentMS = studentMS;
            _logger = logger;
        }

        public IActionResult Index()
        {
            Address a1 = new Address() { city = "Karachi", country = "Pakistan", state = "Self Independent" };

            _studentMS.Addresses.Add(a1);

            _studentMS.SaveChanges();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}