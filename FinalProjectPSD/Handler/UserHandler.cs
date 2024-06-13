using FinalProjectPSD.Model;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace FinalProjectPSD.Handler
{
    public class UserHandler
    {
        UserRepository UserRepo = new UserRepository();

        public void AddUser(int id, String username, String email, String gender, String password, DateTime DOB, String role)
        {
            UserRepo.createUser(id, username, email, gender, password, DOB, role);
        }

        public User checkUsernameUniq(string username)
        {
            return UserRepo.uniqueUsername(username);
        }

        public User login(String username, String password)
        {
            return UserRepo.checkuser(username, password);
        }

        public User userbyusername(String username)
        {
            return UserRepo.getUser(username);
        }

        public User userbyid(int id)
        {
            return UserRepo.GetUserByID(id);
        }

        public int generateID()
        {
            return UserRepo.GenerateId();
        }
    }
}