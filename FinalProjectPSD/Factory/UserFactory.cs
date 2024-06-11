﻿using FinalProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class UserFactory
    {
        public static User create(String username, String email, String gender, String password, DateTime DOB, String role)
        {
            User user = new User()
            {
                Username = username,
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