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

        public IActionResult OnGet(int id)
        {
            Car = _CarRepository.GetCar(id);
            Car ??= new();
            Console.WriteLine($"Received Car ID: {Car.Id}, Brand: {Car.BrandCar}, Model: {Car.Model}, Engine: {Car.EngineCar}");
            return Page();
        }

        public IActionResult OnPost(Car CarForm)
        {
            Console.WriteLine($"Received Car ID: {CarForm.Id}, Brand: {CarForm.BrandCar}, Model: {CarForm.Model}, Engine: {CarForm.EngineCar}");
            Car = _CarRepository.UpdateCar(CarForm);

            if (Car == null) return NotFound();

            return RedirectToPage("Cars");
        }
    }
}