using Microsoft.AspNetCore.Mvc;
using MVCDog.Models;

namespace MVCDog.Controllers
{   
    public class DogsController : Controller
    {
        DogService service;
        public DogsController()
        {
            service= new DogService();
        }

        [HttpGet("")]
        [HttpGet("index")]
        public IActionResult Index()
        {
            var model = service.GetAllDogs();
            return View(model);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Dog obj)
        {
            service.Add(obj);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var model = service.GetDogById(id);
            return View(model);
        }

        [HttpPost("edit/{id}")]
        public IActionResult Edit(Dog obj)
        {

            service.EditDog(obj); 

            return RedirectToAction(nameof(Index));
        }
    }
}
