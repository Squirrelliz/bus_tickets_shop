namespace shop.Models
{
    public class RouteOfBus
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<PathPoint> PathPoints { get; set; } = new();
        public List<BusFlight> BusFlights { get; set; } = new();
    }
}
