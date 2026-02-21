using Clinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Services
{
    public interface IUserService
    {
        public Task<User> GetByUserNameAsync(string UserName, string Password);
        public Task<User> AddUserAsync(User user);

    }
}
