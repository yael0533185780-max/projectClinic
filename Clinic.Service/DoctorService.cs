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
    public class DoctorService:IDoctorService
    {
        private readonly IDoctorsRepository _doctorsRepository;
        public DoctorService (IDoctorsRepository doctorsRepository)
        {
            _doctorsRepository = doctorsRepository;
        }
        public IEnumerable<Doctors> GetAllDoctors()
        {
            return _doctorsRepository.GetAllDoctors();
        }
        public Doctors GetDoctorById(int id)
        {
            return _doctorsRepository.GetDoctorById(id);
        }
        public void UpdateDoctors(Doctors doctors, int id)
        {
            _doctorsRepository.UpdateDoctors(doctors,id);
            _doctorsRepository.Save();
        }
        public void DeleteDoctor(int id)
        {
            _doctorsRepository.DeleteDoctor(id);
            _doctorsRepository.Save();
        }
        public void AddDoctor(Doctors doctors)
        {
            _doctorsRepository.AddDoctor(doctors);
            _doctorsRepository.Save();
        }
        public Doctors GetDoctorsByEmail(string email)
        {
            return _doctorsRepository.GetDoctorsByEmail(email);
        }
    }
}
