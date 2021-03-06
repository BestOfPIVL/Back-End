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
            var check = Program.DataConnection.Admins.FirstOrDefault(x => x.Username == user_name) == null;
            if (!check) return JObject.Parse(@"{'status':'registered'}");

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

            Program.DataConnection.Insert(person);

            return JObject.Parse(@"{'status':'ok'}");
        }

        public JObject Post(string user_name, string password)//���� ���� �������� ����� ��� ������ ������
        {

        }


        public JObject PostResetter(string username, string token)
        {
            return JObject.Parse(@"{ 'status' : 'ok' }");    
            
        }
    }
}