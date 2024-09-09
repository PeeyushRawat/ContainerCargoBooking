namespace ContainerCargoBooking_API.Models
{
    public class Container
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }             // Size in feet (20ft, 40ft, etc.)
        public int Location { get; set; }         // Foreign key for Port (location)
        public DateOnly AvailableFrom { get; set; }
        public int ShippingCompanyId { get; set; } // Foreign key for ShippingCompany

        // Navigation property for shipping company
        public ShippingCompany ShippingCompany { get; set; }

        // Navigation property for related bookings
        public ICollection<Booking> Bookings { get; set; }
    }
}
