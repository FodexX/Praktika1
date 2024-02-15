using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPages.Controller;
using WebAppRazorPages.Model;

namespace WebAppRazorPages.Pages
{
    public class EditCarModel : PageModel
    {

        public EditCarModel(ICar CarRepository)
        {
            _CarRepository = CarRepository;
        }

        private ICar _CarRepository;
        public Car Car { get; set; }
        public Car BrandCar { get; set; }
        public Car Model { get; set; }
        public Car EngineCar { get; set; }

        public IActionResult OnGet(int id)
        {
            Car = _CarRepository.GetCar(id);
            Car ??= new();
            return Page();
        }

        public IActionResult OnPost(Car? CarForm)
        {

            var CarDB = _CarRepository.UpdateCar(CarForm);
            if (CarDB == null) return NotFound();
            return Page();
        }
    }
}