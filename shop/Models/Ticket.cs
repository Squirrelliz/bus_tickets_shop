namespace shop.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Place {  get; set; }
        public int BusFlightId { get; set; }
        public BusFlight? BusFlight { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
