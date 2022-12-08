using Microsoft.AspNetCore.Mvc;

namespace MVCDog.Controllers
{
    public class DogsController : Controller
    {
        public DogsController()
        {

        }

        [HttpGet("")]
        [HttpGet("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
