using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Submit(Models.User user)
        {
            ViewBag.Name = user.Name;
            ViewBag.Email = user.Email;
            ViewBag.Address = user.Address;
            ViewBag.CNIC = user.CNIC;



            var connection = new SqlConnection(@"Data Source=;Initial Catalog=Registration;Integrated Security=true");

            var command = new SqlCommand(string.Format("insert into Info(Name ,Email, Address, CNIC) values ('{0}','{1}', '{2}', '{3}');",
                user.Name, user.Email, user.Address, user.CNIC), connection);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close(); 





            return View();
        }
    }
}
