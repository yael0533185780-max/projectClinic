using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using Clinic.Core.Repositories;
using Microsoft.EntityFrameworkCore;
//using projectClinic;

namespace Clinic.Data.Repositories
{
    public class ClientRepository : IClientsRepository
    {
        private readonly DataContext _context;

        public ClientRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Clients>> GetAllClientsAsync()
        {
            return await _context.clients.ToListAsync();
        }
        public async Task<Clients> GetClientByIdAsync(int id)
        {
            return await _context.clients.FirstAsync(x => x.Id == id);
        }
        public async Task AddClientAsync(Clients client)
        {

             _context.clients.Add(client);
        }
        public async Task UpdateClientAsync(Clients client, int id)
        {

            var c = await _context.clients.FirstAsync(c => c.Id == id);
            c.Name = client.Name;
            c.Address = client.Address;
            c.City = client.City;
            c.Email = client.Email;
            c.Phone = client.Phone;
        }
        public async Task DeleteClientAsync(int id)
        {
            var c = await _context.clients.FirstAsync(c => c.Id == id);
             _context.clients.Remove(c);
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
        public async Task<Clients> GetClientByEmailAsync(string email)
        {
            return await _context.clients.FirstOrDefaultAsync(s => s.Email == email);
        }

    }
}
