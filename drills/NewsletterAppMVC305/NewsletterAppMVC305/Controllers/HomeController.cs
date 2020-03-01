using NewsletterAppMVC305.Models;
using NewsletterAppMVC305.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC305.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.SignUps.Add(signup);
                    db.SaveChanges();

                }
                return View("Success");
            }
        }

       
    }
}



//been replaced by the newsletter entity code 
//private readonly string connectionString = @"Data Source=DESKTOP-K1MAO28\SQLEXPRESS;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

//signup method
//string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
//                        (@FirstName, @LastName, @EmailAddress)";

////when conencting with an external db always wrap in a using statement so the connection gets cut off when done
//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    SqlCommand command = new SqlCommand(queryString, connection);
//    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
//    command.Parameters.Add("@LastName", SqlDbType.VarChar);
//    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

//    command.Parameters["@FirstName"].Value = firstName;
//    command.Parameters["@LastName"].Value = lastName;
//    command.Parameters["@EmailAddress"].Value = emailAddress;

//    //open a connection and execute query
//    connection.Open();
//    command.ExecuteNonQuery(); //an insert is a nonQuery
//    connection.Close();

//}

//Admin method
//string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from SignUps";
//List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    SqlCommand command = new SqlCommand(queryString, connection);

//    connection.Open();

//    SqlDataReader reader = command.ExecuteReader();

//    while (reader.Read())
//    {
//        var signup = new NewsletterSignUp(); /*of datatype NewsletterSignUp()*/
//        signup.Id = Convert.ToInt32(reader["Id"]);
//        signup.FirstName = reader["FirstName"].ToString();
//        signup.LastName = reader["LastName"].ToString();
//        signup.EmailAddress = reader["EmailAddress"].ToString();
//        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();

//        signups.Add(signup);
//    }

//}