using Clinic.Core.Entities;
using Clinic.Core.Repositories;
using Clinic.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> GetByUserNameAsync(string userName, string Password)
        {
            return await _userRepository.GetByUserNameAsync(userName, Password);
        }
        public async Task<User> AddUserAsync(User user)
        {
            return await _userRepository.AddUserAsync(user);
        }

    }
}
