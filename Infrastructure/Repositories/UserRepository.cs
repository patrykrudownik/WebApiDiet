using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly ISet<User> _userRepository = new HashSet<User>() 
        { 
            new User(1,"Andrzej","Andrzej@mail.com","pa$$word1"),
            new User(2,"Jerzy","Jerzy@mail.com","p@ssword2")
        };

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }
        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
        public User Add(User user)
        {
            throw new NotImplementedException();
        }
        public void Update(User user)
        {
            throw new NotImplementedException();
        }
        public void Delete(User user)
        {
            throw new NotImplementedException();
        }
    }
}
