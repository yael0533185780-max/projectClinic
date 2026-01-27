using Clinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.DTOs
{
    public class QueueDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime Endtime { get; set; }
        public int DoctorId { get; set; }
        public int ClientId { get; set; }

    }
}
