
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
        public IEnumerable<Clients> GetAllClients();
        public Clients GetClientById(int id);
        public void AddClient(Clients client);
        public void UpdateClient(Clients client,int id);
        public void DeleteClient(int id);
        public void Save();
        public Clients GetClientByEmail(string email);

    }
}
