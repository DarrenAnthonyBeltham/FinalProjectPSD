using FinalProjectPSD.Handler;
using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.Controller
{
    public class UserController
    {
        private UserHandler handler = new UserHandler();

        public User Checkuserbyid(int id)
        {
            return handler.userbyid(id);
        }
        public String CheckUsername(string username)
        {
            if (username.Length == 0)
            {
                return "Username must not be empty";
            }
            if (username.Length < 5 || username.Length > 15)
            {
                return "Username must be between 5 - 15";
            }
            else if (handler.checkUsernameUniq(username) != null)
            {
                return "Username must be unique";
            }
            return null;
        }

        public String checkEmail(string email)
        {
            if (email.Length == 0)
            {
                return "Email must not be empty";
            }
            else if (!email.EndsWith(".com"))
            {
                return "Email must end with .com";
            }
            return null;
        }

        public String checkgender(RadioButton male, RadioButton female)
        {
            if (!male.Checked && !female.Checked)
            {
                return "Gender must be picked";
            }
            return null;
        }

        public bool isAlphaNum(String password)
        {
            String pattern = "^[a-zA-Z0-9]*$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(password);
        }

        public String checkPassword(String password, String confpassword)
        {
            if (password.Length == 0)
            {
                return "Password must not be empty";
            }
            else if (!isAlphaNum(password))
            {
                return "Password must be alphanumeric";
            }
            else if (confpassword.Length == 0)
            {
                return "Confirm password must not be empty";
            }
            else if (!password.Equals(confpassword))
            {
                return "Confirm Password must be the same with password";
            }
            else if (!confpassword.Equals(password))
            {
                return "Password must be the same with confirm password";
            }
            return null;
        }

        public String checkDOB(DateTime dob)
        {
            if (dob.ToString("dd-mm-yyyy").Equals(""))
            {
                return "Date of Birth must not be empty";
            }
            return null;
        }
        public String login(String username, String password, CheckBox cb)
        {
            if (username.Length == 0)
            {
                return "Username must not be empty";
            }
            else if (password.Length == 0)
            {
                return "Password must not be empty";
            }
            else if (handler.login(username, password) == null)
            {
                return "User does not exist";
            }
            else
            {
                //pembuatan cookie dan session
                User current = handler.userbyusername(username);

                if (cb.Checked)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = current.UserID.ToString();
                    cookie.Expires = DateTime.Now.AddDays(1);
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                HttpContext.Current.Session["user"] = current;
                //HttpContext.Current.Session["UserID"] = current.UserID;
                //HttpContext.Current.Session["UserRole"] = current.UserRole;
                //HttpContext.Current.Session["Username"] = current.Username;

            }
            return "";
        }

        public String register(String username, String email, RadioButton male, RadioButton female, String password, string confpassword, DateTime DOB)
        {
            String error = CheckUsername(username);

            if (error == null)
            {
                error = checkEmail(email);
            }
            if (error == null)
            {
                error = checkgender(male, female);
            }
            if (error == null)
            {
                error = checkPassword(password, confpassword);
            }
            if (error == null)
            {
                error = checkDOB(DOB);
            }
            if (error == null)
            {

                String gender = null;
                if (male.Checked)
                {
                    gender = "male";
                }
                else if (female.Checked)
                {
                    gender = "female";
                }
                error = null;
                int id = handler.generateID();
                handler.AddUser(id, username, email, gender, password, DOB, "customer");
            }
            return error;
        }
    }
}