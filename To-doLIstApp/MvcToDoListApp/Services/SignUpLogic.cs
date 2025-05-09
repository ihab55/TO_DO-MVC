using MvcToDoListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcToDoListApp.Services
{
    static public class SignUpLogic
    {
        static public bool UsernameIsValidToSignUp(string userName)
        {
            User? foundUser=UserCRUD.ReadUser(userName);
            return foundUser == null;
        }
        static public bool UserIsValidThenSignUp(string userName,string password,string confirmPassword)
        {
            bool usernameIsValid=UsernameIsValidToSignUp(userName);
            if (usernameIsValid && (password == confirmPassword))
            {
                UserCRUD.CreateUser(userName, password);
                return true;
            }
            return false;
        }
    }
}
