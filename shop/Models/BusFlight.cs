namespace shop.Models
{
    public class BusFlight
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime DateTime { get; set; }
        public int RouteOfBusId { get; set; }
        public RouteOfBus? RouteOfBus { get; set; }
        public int BusId { get; set; }
        public Bus? Bus { get; set; }
    }
}
