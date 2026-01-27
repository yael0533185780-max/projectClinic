using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;


namespace Clinic.Core.Services
{
    public interface IClientService
    {
        public Task<List<Clients>> GetAllClientsAsync();
        public Task<Clients> GetClientByIdAsync(int id);
        public Task AddClientAsync(Clients client);
        public Task UpdateClientAsync(Clients client, int id);
        public Task DeleteClientAsync(int id);
        public Task<Clients> GetClientByEmailAsync(string email);
    }
}
