using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace Transactions.Controllers
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
           
            ViewBag.UserName = user.UserName;
            ViewBag.UserEmail = user.UserEmail;
            ViewBag.UserCNIC = user.UserCNIC;
            ViewBag.UserAddress = user.UserAddress;
            ViewBag.edu_name = user.edu_name;
            ViewBag.stu_id = user.stu_id;


            SqlTransaction objTrans = null;


            var connection = new SqlConnection(@"Data Source=;Initial Catalog=MVCwithDatabase;Integrated Security=true");

      

           



            connection.Open();

            objTrans = connection.BeginTransaction();

            //  var command1 = new SqlCommand(string.Format("insert into RegistrationForm(UserName, UserEmail, UserCNIC, UserAddress) values('{0}','{1}', '{2}', '{3}');", user.UserName, user.UserEmail, user.UserCNIC, user.UserAddress), connection);
            //  var command2 = new SqlCommand(string.Format("insert into Education(edu_name, stu_id) values('{0}',{1});", user.edu_name, 's'), connection);



            // through stored procedure

            var command = new SqlCommand("trans", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("UserName", user.UserName);
            command.Parameters.AddWithValue("UserEmail", user.UserEmail);
            command.Parameters.AddWithValue("UserCNIC", user.UserCNIC);
            command.Parameters.AddWithValue("UserAddress", user.UserAddress);



            try
            {
                // through stored procedure

                command.ExecuteNonQuery();


               //  command1.ExecuteNonQuery();
              //  command2.ExecuteNonQuery();



                objTrans.Commit();
            }

            catch (Exception)
            {
                objTrans.Rollback();
            }

            finally
            {
                connection.Close();
            }

      


            return View();
        }

    }
}
