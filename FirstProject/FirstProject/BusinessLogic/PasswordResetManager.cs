using FirstProject.DbLayer.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.BusinessLogic
{
    public static class PasswordResetManager
    {

        static Dictionary<Admin, string> Users { get; set; } = new Dictionary<Admin, string>();

        public static void CreateActiveUser(Admin admin)
        {
            Random rnd = new Random();
            string Token = Convert.ToString(rnd.Next(3));
            Token = Users[admin];
        }
        public static void FindUser(Admin admin)
        {
            bool Find = Users.ContainsKey(admin);
            if(Find != false)
            {

            }
        }
    }
}
