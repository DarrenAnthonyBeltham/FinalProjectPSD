using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class UserFactory
    {
        public static User create(String name, String email, DateTime DOB, String gender, String role, String password)
        {
            User user = new User()
            {
                Username = name,
                UserEmail = email,
                UserDOB = DOB,
                UserGender = gender,
                UserRole = role,
                UserPassword = password
            };
            return user;
        }
    }
}