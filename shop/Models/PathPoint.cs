using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace shop.Models
{
    public class PathPoint
    {
        public int Id { get; set; }
        public int StopId { get; set; }
        public Stop? Stop { get; set; }
        public int Queue {  get; set; }
        public int RouteOfBusId { get; set; }
        public RouteOfBus? RouteOfBus { get; set; }
    }
}
