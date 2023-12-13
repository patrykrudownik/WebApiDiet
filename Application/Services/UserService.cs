using Application.DTO;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) 
        { 
            _userRepository = userRepository;
        }
        public IEnumerable<UserDto> GetAllUsers()
        {
            var users = _userRepository.GetAll();
            return users.Select(user => new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email
            });
        }

        public UserDto GetUserById(int id)
        {
            var user = _userRepository.GetById(id);
            return new UserDto()
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email
            };
        }
    }
}
