namespace projectClinic.Models
{
    public class QueuePostModel
    {
        public DateTime Date { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime Endtime { get; set; }
        public int DoctorId { get; set; }
        public int ClientId { get; set; }
    }
}
