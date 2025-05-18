namespace Transport.Infrastructure.Models
{
    public class RouteModel
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public int BusModelId { get; set; }
        public BusModel Bus { get; set; }
    }
}
