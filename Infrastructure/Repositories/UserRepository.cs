using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ISet<User> _users = new HashSet<User>()
        {
            new User(1,"Andrzej","Andrzej@mail.com","pa$$word1"),
            new User(2,"Jerzy","Jerzy@mail.com","p@ssword2")
        };

        public IEnumerable<User> GetAll()
        {
            return _users;
        }
        public User GetById(int id)
        {
            return _users.SingleOrDefault(x => x.Id == id);
        }
        public User Add(User user)
        {
            user.Id = _users.Count() + 1;
            _users.Add(user);
            return user;
        }
        public void Update(User user)
        {
            _users.Select(u => u.Id == user.Id);           
        }
        public void Delete(User user)
        {
            _users.Remove(user);
        }
    }
}
