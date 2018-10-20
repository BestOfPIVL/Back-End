using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.DbLayer.POCOs;
using LinqToDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FirstProject.Controllers
{
    [Produces("application/json")]
    [Route("api/Auth")]
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
    

    }
}