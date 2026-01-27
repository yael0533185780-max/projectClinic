namespace Clinic.Core.Entities
{
    public class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public List<Queues> Queues { get; set; }
    }
}
