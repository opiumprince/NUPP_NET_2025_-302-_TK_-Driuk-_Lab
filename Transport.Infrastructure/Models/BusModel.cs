namespace Transport.Infrastructure.Models
{
    public class BusModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DriverModel Driver { get; set; } // 1-до-1
        public ICollection<RouteModel> Routes { get; set; } // 1-до-багатьох
    }
}
