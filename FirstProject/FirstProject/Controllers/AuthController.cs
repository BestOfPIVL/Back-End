using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using FirstProject.DbLayer.POCOs;
using LinqToDB;

namespace FirstProject.Controllers
{
    [Produces("application/json")]
    [Route("api/Auth")]
    public partial class AuthController : Controller
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
    }
}