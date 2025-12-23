namespace Clinic.Core.Entities
{
    public class Queues
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime Endtime { get; set; }
        public int DoctorId { get; set; }
        public int ClientId { get; set; }

        public Doctors Doctor { get; set; }  // קשר ישיר לרופא
        public Clients Client { get; set; }
    }
}
