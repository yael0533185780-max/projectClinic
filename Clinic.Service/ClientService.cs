using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Services;
using Clinic.Core.Entities;

namespace Clinic.Service
{
    public class ClientService: IClientService
    {
        private readonly IClientsRepository _clientRepository;
        public  ClientService(IClientsRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<List<Clients>> GetAllClientsAsync() {
            return await _clientRepository.GetAllClientsAsync();
        }
        public async Task AddClientAsync(Clients client)
        {
            await _clientRepository.AddClientAsync(client);
            await _clientRepository.SaveAsync();
        }
        public async Task UpdateClientAsync(Clients client, int id)
        {
            await _clientRepository.UpdateClientAsync(client , id);
            await _clientRepository.SaveAsync();
        }
        public async Task DeleteClientAsync(int id)
        {
            await _clientRepository.DeleteClientAsync(id);
            await _clientRepository.SaveAsync();
        }

        public async Task<Clients> GetClientByIdAsync(int id)
        {
            return await _clientRepository.GetClientByIdAsync(id);
        }
        public async Task<Clients> GetClientByEmailAsync(string email)
        {
            return await _clientRepository.GetClientByEmailAsync(email);
        }



    }
}




