namespace shop.Models
{
    public class Bus
    {
        public int Id { get; set; }
        public string ModelName { get; set; } = null!;
        public bool InService { get; set; } = true;
        public int NumberOfPlaces { get; set; }
        public string Number { get; set; } = null!;
    }
}
