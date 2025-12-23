using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using System.Collections;
//using projectClinic;

namespace Clinic.Data.Repositories
{
    public class DoctorRepository: IDoctorsRepository
    {
        private readonly DataContext _context;

        public DoctorRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Doctors> GetAllDoctors()
        {
            return _context.doctors;
        }
        public Doctors GetDoctorById(int id)
        {
            return _context.doctors.ToList().Find(x => x.Id == id);
        }
        public void AddDoctor(Doctors d)
        {
            _context.doctors.Add(d);
        }
        public void UpdateDoctors(Doctors doctors, int id)
        {
            var c = _context.doctors.ToList().Find(c => c.Id == id);
                c.Name = doctors.Name;
                c.Businesshours=doctors.Businesshours;
                c.Email = doctors.Email;
                c.Phone = doctors.Phone;
        }
        public void DeleteDoctor(int id)
        {
            var d = _context.doctors.ToList().Find(c => c.Id == id);
            
                _context.doctors.Remove(d);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public Doctors GetDoctorsByEmail(string email)
        {
            return _context.doctors.ToList().Find(s => s.Email == email);
        }
    }
}

