using MvcToDoListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcToDoListApp.Services
{
    static public class LoginLogic
    {
        static public bool UserIsValidToLogin(string userName,string password) 
        {
            User? foundUser = UserCRUD.ReadUser(userName);
            if (foundUser != null)
            {
                if(password==foundUser.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
