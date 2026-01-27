using Clinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Services
{
    public interface IDoctorService
    {
        public Task<List<Doctors>> GetAllDoctorsAsync();
        public Task<Doctors> GetDoctorByIdAsync(int id);
        public Task UpdateDoctorsAsync(Doctors doctors, int id);
        public Task DeleteDoctorAsync(int id);
        public Task AddDoctorAsync(Doctors doctors);
        public Task<Doctors> GetDoctorByEmailAsync(string email);

    }
}
