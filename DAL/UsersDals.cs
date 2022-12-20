using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class UsersDal : IUsersDal
    {
        private List<User> users = new List<User>() {
            new User() {Name = "n", Password = 0, Id = 0},
        };

        public User GetById(int id)
        {
            return users.FirstOrDefault(item => item.Id == id);
        }

        public User GetByLogin(string login)
        {
            return users.FirstOrDefault(item => item.Name == login);
        }

        public void WriteUserToBD(User user)
        {
            users.Add(user);
        }

	}
}
