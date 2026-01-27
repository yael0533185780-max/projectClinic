
using Clinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Repositories
{
    public interface IClientsRepository
    {
        public Task<List<Clients>> GetAllClientsAsync();
        public Task<Clients> GetClientByIdAsync(int id);
        public Task AddClientAsync(Clients client);
        public Task UpdateClientAsync(Clients client,int id);
        public Task DeleteClientAsync(int id);
        public Task SaveAsync();
        public Task<Clients> GetClientByEmailAsync(string email);

    }
}
