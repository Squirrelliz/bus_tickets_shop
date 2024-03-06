using Microsoft.AspNetCore.Mvc;

namespace shop.Controllers
{
    public class SaleController : Controller
    {

        private readonly ILogger<SaleController> _logger;

        public SaleController(ILogger<SaleController> logger)
        {
            _logger = logger;
        }

        public IActionResult GetTickets()
        {
            return View();
        }
    }
}
