
namespace shop.Models
{
    public class Stop
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string? image {  get; set; }
        public List<PathPoint> PathPoints { get; set; } = new();
    }
}
