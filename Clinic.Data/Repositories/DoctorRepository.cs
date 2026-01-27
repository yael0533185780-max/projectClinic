using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using Microsoft.EntityFrameworkCore;
//using projectClinic;

namespace Clinic.Data.Repositories
{
    public class DoctorRepository : IDoctorsRepository
    {
        private readonly DataContext _context;

        public DoctorRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Doctors>> GetAllDoctorsAsync()
        {
            return await _context.doctors.ToListAsync();
        }
        public Task<Doctors?> GetDoctorByIdAsync(int id)
        {
            return _context.doctors.FirstOrDefaultAsync(x => x.Id == id);
        }
        public Task<Doctors?> GetDoctorByEmailAsync(string email)
        {
            return _context.doctors.FirstOrDefaultAsync(s => s.Email == email);
        }
        public async Task AddDoctorAsync(Doctors d)
        {
            _context.doctors.Add(d);
        }
        public async Task UpdateDoctorsAsync(Doctors doctors, int id)
        {
            var c = await _context.doctors.FirstOrDefaultAsync(c => c.Id == id);
            c.Name = doctors.Name;
            c.Businesshours = doctors.Businesshours;
            c.Email = doctors.Email;
            c.Phone = doctors.Phone;
        }
        public async Task DeleteDoctorAsync(int id)
        {
            var d = await _context.doctors.FirstOrDefaultAsync(c => c.Id == id);

            _context.doctors.Remove(d);
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

