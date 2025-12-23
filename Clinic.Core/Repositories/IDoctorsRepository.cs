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
        public IEnumerable<Doctors> GetAllDoctors();
        public Doctors GetDoctorById(int id);
        public void UpdateDoctors(Doctors doctors,int id);
        public void DeleteDoctor(int id);
        public void AddDoctor(Doctors doctors);
        public void Save();
        public Doctors GetDoctorsByEmail(string email);


    }
}
