using Application.DTO;
using Application.Interfaces;
using AutoMapper;
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
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper) 
        { 
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public IEnumerable<UserDto> GetAllUsers()
        {
            var users = _userRepository.GetAll();
            
            return _mapper.Map<IEnumerable<UserDto>>(users);

            //Logic without AutoMapper
            //return users.Select(user => new UserDto
            //{
            //    Id = user.Id,
            //    Name = user.Name,
            //    Email = user.Email
            //});
        }

        public UserDto GetUserById(int id)
        {
            var user = _userRepository.GetById(id);
            return _mapper.Map<UserDto>(user);

            //Logic without AutoMapper
            //return new UserDto()
            //{
            //    Id = user.Id,
            //    Name = user.Name,
            //    Email = user.Email
            //};
        }
    }
}
