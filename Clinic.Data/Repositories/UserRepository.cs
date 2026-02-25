using Clinic.Core.Entities;
using Clinic.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<User> GetByUserNameAsync(string userName, string Password)
        {
            return await _dataContext.user.FirstOrDefaultAsync(u => u.UserName == userName && u.Password == Password);
        }
        public async Task<User> AddUserAsync(User user)
        {
            await _dataContext.user.AddAsync(user);
            await _dataContext.SaveChangesAsync();
            return user;
        }

    }
}
