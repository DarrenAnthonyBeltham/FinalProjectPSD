using FinalProjectPSD.Factory;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class UserRepository
    {
        private static MakeUpzzEntities1 db = DataSingleton.getInstance();

        public void createUser(String username, String email, DateTime DOB, String gender, String role, String password)
        {
            User user = UserFactory.create(username, email, DOB, gender, role, password);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static User getUser(String username, String password)
        {
            return (from x in db.Users where x.Username.Equals(username) && x.UserPassword.Equals(password) select x).FirstOrDefault();
        }

        public List<User> showUsers()
        {
            return (from x in db.Users where x.UserRole.Equals("Customer") select x).ToList();
        }
    }
}