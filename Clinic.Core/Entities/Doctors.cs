using System.Collections;

namespace Clinic.Core.Entities
{
    public class Doctors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Businesshours { get; set; }
        public List<Queues> Queues { get; set; }  // לכל רופא יש רשימה של תורים

    }
}
