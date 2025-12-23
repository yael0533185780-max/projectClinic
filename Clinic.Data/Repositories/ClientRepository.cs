using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using Clinic.Core.Repositories;
//using projectClinic;

namespace Clinic.Data.Repositories
{
    public class ClientRepository: IClientsRepository
    {
        private readonly DataContext _context;

        public ClientRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Clients> GetAllClients()
        {
            return _context.clients;
        }
        public Clients GetClientById(int id)
        {
            return _context.clients.ToList().Find(x => x.Id == id);
        }
        public void AddClient(Clients client)
        {

            _context.clients.Add(client);
        }
        public void UpdateClient(Clients client, int id)
        {

           var c= _context.clients.ToList().Find(c => c.Id == id);
                c.Name = client.Name;
                c.Address = client.Address;
                c.City = client.City;
                c.Email = client.Email;
                c.Phone = client.Phone;
        }
        public void DeleteClient(int id)
        {
            var c = _context.clients.ToList().Find(c => c.Id == id);
                _context.clients.Remove(c);
        }


        public void Save()
        {
            _context.SaveChanges();
        }
        public Clients GetClientByEmail(string email)
        {
            return _context.clients.ToList().Find(s => s.Email == email);
        }

    }
}
