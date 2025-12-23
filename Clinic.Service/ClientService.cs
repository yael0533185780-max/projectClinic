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
        public ClientService(IClientsRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public IEnumerable<Clients> GetAllClients() {
            return _clientRepository.GetAllClients();
        }
        public void AddClient(Clients client)
        {
             _clientRepository.AddClient(client);
            _clientRepository.Save();
        }
        public void UpdateClient(Clients client, int id)
        {
            _clientRepository.UpdateClient(client , id);
            _clientRepository.Save();
        }
        public void DeleteClient(int id)
        {
            _clientRepository.DeleteClient(id);
            _clientRepository.Save();
        }

        public Clients GetClientById(int id)
        {
            return _clientRepository.GetClientById(id);
        }
        public Clients GetClientByEmail(string email)
        {
            return _clientRepository.GetClientByEmail(email);
        }



    }
}




