namespace ContainerCargoBooking_API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        // Navigation property for related bookings
        public ICollection<Booking>? Bookings { get; set; }
    }
}
