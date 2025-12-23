using Clinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.DTOs
{
    public class DoctorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Businesshours { get; set; }
        //public List<Queues> Queues { get; set; }
    }
}
