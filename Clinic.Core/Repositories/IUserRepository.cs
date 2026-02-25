using Clinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Repositories
{
    public interface IUserRepository
    {
        public Task<User> GetByUserNameAsync(string UserName, string Password);
        public Task<User> AddUserAsync(User user);

    } 
}
