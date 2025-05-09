using MvcToDoListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcToDoListApp.Services
{
    public static class UserCRUD
    {
        public static void CreateUser(string username,string password)
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.Add(new User() { Username = username, Password = password });
                db.SaveChanges();
            }
        }
        public static void DeleteUserByUserName(string userName)
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.Remove(new  User() { Username = userName });
                db.SaveChanges();
            }
        }

        public static void UpdateUser(User user)
        {
            using (AppDbContext db = new AppDbContext())
            {
                User? foundUser = db.Users.Find(user.Username);
                if (foundUser != null)
                {
                    foundUser.Password= user.Password;
                    db.SaveChanges();
                }
            }
        }
        public static User? ReadUser(string userName)
        {
            using (AppDbContext db = new AppDbContext())
            {
                User? foundUser = db.Users.Find(userName);
                return foundUser;
            }
        }

        public static List<User> ReadAllUsers()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Users.ToList();
            }
        }
    }
}
