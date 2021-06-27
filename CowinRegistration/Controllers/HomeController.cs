using CowinRegistration.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CowinRegistration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index1(User  user)
        {if (ModelState.IsValid)
            {
                string myConnection = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                SqlConnection connection = new SqlConnection(myConnection);
                connection.Open();

                SqlCommand command = new SqlCommand("UserRegistration", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Name", user.Name);
                command.Parameters.AddWithValue("Age", user.Age);
                command.Parameters.AddWithValue("State", user.State);
                command.Parameters.AddWithValue("District", user.District);
                command.Parameters.AddWithValue("AadharNumber", user.AadhaarNumber);
                command.Parameters.AddWithValue("ChooseFromVendor", user.ChooseFromVendor);

                command.ExecuteNonQuery();
                connection.Close();

            }

            return View("View");
        }
    }
}