using Clinic.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Services
{
    public interface IDoctorService
    {
        public IEnumerable<Doctors> GetAllDoctors();
        public Doctors GetDoctorById(int id);
        public void UpdateDoctors(Doctors doctors, int id);
        public void DeleteDoctor(int id);
        public void AddDoctor(Doctors doctors);
        public Doctors GetDoctorsByEmail(string email);


    }
}
