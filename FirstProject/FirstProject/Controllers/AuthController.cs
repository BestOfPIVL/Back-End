using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using FirstProject.DbLayer.POCOs;
=======
using FirstProject.DbLayer.POCOs;
using LinqToDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
>>>>>>> 0def423f6e8ae54053a12ef21b8e0f30c7eb897a

namespace FirstProject.Controllers
{
    [Produces("application/json")]
    [Route("api/Auth")]
<<<<<<< HEAD
    public class AuthController : Controller
    {
        public JObject Post(string user_name, string password, string status, string faculty, string specialty, string mail, DateTime year_of_entry)
        {

            var person = new Admin()
            {
                Username = user_name,
                Password = password,
                Status = status,
                Faculty = faculty,
                Specialty = specialty,
                Admission_Year = year_of_entry,
                Mail = mail
            };
            

            return JObject.Parse(@"{'status':'ok'}");
        }
=======
    public partial class AuthController : Controller
    {
        public JObject Get()
        {
            return JObject.Parse(@"{ 'status' : 'ok' }");              
        }

        public JObject Post(string username, string password)
        {
            var user = new Admin
            {
              Username = username, 
              Password = password,
              Admission_Year = new DateTime(2000, 1, 1, 1, 1, 1),
              Faculty = "wewe",
              Mail = "wewe",
              Specialty = "wewe",
              Status = "wewe"
            };
            
            Program.DataConnection.Insert(user);
            return JObject.Parse(@"{ 'status' : 'ok' }");
        }
    

>>>>>>> 0def423f6e8ae54053a12ef21b8e0f30c7eb897a
    }
}