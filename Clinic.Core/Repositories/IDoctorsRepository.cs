using Clinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Repositories
{
    public interface IDoctorsRepository
    {
        public Task<List<Doctors>> GetAllDoctorsAsync();
        public Task<Doctors> GetDoctorByIdAsync(int id);
        public Task<Doctors> GetDoctorByEmailAsync(string email);
        public Task UpdateDoctorsAsync(Doctors doctors, int id);
        public Task DeleteDoctorAsync(int id);
        public Task AddDoctorAsync(Doctors doctors);
        public Task SaveAsync();

    }
}
