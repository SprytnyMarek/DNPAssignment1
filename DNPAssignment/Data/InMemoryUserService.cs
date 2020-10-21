using System;
using System.Collections.Generic;
using System.Linq;
using DNPAssignment.Data;
using Models;

namespace DNPAssignment.Data
{
    public class InMemoryUserService :IUserService
    {

        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    Securitylevel = 4,
                    UserName = "Pawel",
                    Password = "123456"
                },
                new User
                {
                    Securitylevel = 3,
                    UserName = "Wojtek",
                    Password = "123456"
                },
                new User
                {
                Securitylevel = 2,
                UserName = "Dumi",
                Password = "123456"
                },
                new User
                {
                    Securitylevel = 1,
                    UserName = "Maria",
                    Password = "123456"
                }
            }.ToList();
        }
        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}