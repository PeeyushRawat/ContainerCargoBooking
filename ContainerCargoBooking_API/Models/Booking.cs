namespace ContainerCargoBooking_API.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }                // Foreign key to User
        public int ContainerId { get; set; }           // Foreign key to Container
        public int SourcePortId { get; set; }          // Foreign key to Port (source)
        public int DestinationPortId { get; set; }     // Foreign key to Port (destination)
        public DateTime Created { get; set; }
        public DateTime DeliveryDate { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Container Container { get; set; }
        public Port SourcePort { get; set; }
        public Port DestinationPort { get; set; }
    }

}
