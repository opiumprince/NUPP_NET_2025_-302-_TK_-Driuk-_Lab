namespace Transport.Infrastructure.Models
{
    public class DriverModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BusModelId { get; set; }
        public BusModel Bus { get; set; }
    }
}
