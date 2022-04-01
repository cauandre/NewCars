using Microsoft.AspNetCore.Mvc;

namespace NewCars.Controllers
{
    public class CarController : Controller
    {
        private readonly IConfiguration _configuration;
        public CarController(IConfiguration configuration)
        {
           _configuration = configuration;
            var com = _configuration.GetConnectionString("connNewCars");

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
