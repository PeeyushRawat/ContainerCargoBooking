namespace ContainerCargoBooking_API.Models
{
    public class ShippingCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public double RatePerDay { get; set; }
    }
}
