using Microsoft.AspNetCore.Identity;

namespace shop.Models
{
    public class User
    {
        public int Id { get; set; } 
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; }=null!;
        public string LastName { get; set; }= null!;
        public string Email { get; set; }= null!;
        public string Password { get; set; } =null!;
        public string PhoneNumber { get; set; }= null!;
        public Role role { get; set; }
        public int Rating { get; set; }
        public List<Ticket> Tickets { get; set; } = new();
    }

}
