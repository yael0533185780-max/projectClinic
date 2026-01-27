using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using Clinic.Core.Services;
using Clinic.Core.Repositories;
namespace Clinic.Service
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorsRepository _doctorsRepository;
        public DoctorService(IDoctorsRepository doctorsRepository)
        {
            _doctorsRepository = doctorsRepository;
        }
        public async Task<List<Doctors>> GetAllDoctorsAsync()
        {
            return await _doctorsRepository.GetAllDoctorsAsync();
        }
        public async Task<Doctors> GetDoctorByIdAsync(int id)
        {
            return await _doctorsRepository.GetDoctorByIdAsync(id);
        }
        public async Task UpdateDoctorsAsync(Doctors doctors, int id)
        {
            await _doctorsRepository.UpdateDoctorsAsync(doctors, id);
            await _doctorsRepository.SaveAsync();
        }
        public async Task DeleteDoctorAsync(int id)
        {
            await _doctorsRepository.DeleteDoctorAsync(id);
            await _doctorsRepository.SaveAsync();
        }
        public async Task AddDoctorAsync(Doctors doctors)
        {
            await _doctorsRepository.AddDoctorAsync(doctors);
            await _doctorsRepository.SaveAsync();
        }
        public Task<Doctors> GetDoctorByEmailAsync(string email)
        {
            return _doctorsRepository.GetDoctorByEmailAsync(email);
        }
    }
}
