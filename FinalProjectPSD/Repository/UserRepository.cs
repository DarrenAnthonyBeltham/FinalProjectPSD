using FinalProjectPSD.Factory;
using FinalProjectPSD.Handler;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.Repository
{
    public class UserRepository
    {
        private static MakeUpzzEntities1 db = DataSingleton.getInstance();

        public void createUser(int id, String username, String email, String gender, String password, DateTime DOB, String role)
        {
            User user = UserFactory.create(id,username, email, gender, password, DOB, role);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public User uniqueUsername(String username)
        {
            return(from u in db.Users where u.Username == username select u).FirstOrDefault();
        }

        public User checkuser(String username, String password)
        {
            return (from x in db.Users where x.Username.Equals(username) && x.UserPassword.Equals(password) select x).FirstOrDefault();
        }

        public User GetUserByID(int id)
        {
            return (from u in db.Users where u.UserID == id select u).FirstOrDefault();
        }

        public User getUser(string username)
        {
            return (from u in db.Users where u.Username == username select u).FirstOrDefault();
        }

        public List<User> showUsers()
        {
            return (from x in db.Users where x.UserRole.Equals("Customer") select x).ToList();
        }

        public int getIDFromUsername(string username)
        {
            return (from x in db.Users where x.Username == username select x.UserID).FirstOrDefault();
        }
                
        public int GenerateId()
        {
            int id = (from x in db.Users select x.UserID).ToList().LastOrDefault();
            int newID;

            if (id == 0)
            {
                newID = 0;
            }
            else
            {
                newID = id + 1;
            }
            return newID;
        }

        public User userbyid(int id)
        {
            return (from x in db.Users where x.UserID == id select x).FirstOrDefault();
        }

        public void deleteName(int id)
        {
            User user = userbyid(id);
            user.Username = "";
            db.SaveChanges();
        }

        public void updateProfile(int id, string name, string email, string gender, DateTime dob)
        {
            User user = userbyid(id);
            user.Username = name;
            user.UserEmail = email;
            user.UserGender = gender;
            user.UserDOB = dob;

            db.SaveChanges();
            return;
        }

        public String GetUserPassword(int id)
        {
            User user = userbyid(id);
            return user.UserPassword;
        }

        public void UpdateUserPassword(int id, string newPass)
        {
            User user = userbyid(id);
            user.UserPassword = newPass;
            db.SaveChanges();
        }
    }
}