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
        public IEnumerable<Clients> GetAllClients();
        public Clients GetClientById(int id);
        public void AddClient(Clients client);
        public void UpdateClient(Clients client, int id);
        public void DeleteClient(int id);
        public Clients GetClientByEmail(string email);
    }
}
