using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPages.Repository;
using WebAppRazorPages.Model;
using Microsoft.AspNetCore.Authorization;

namespace WebAppRazorPages.Pages
{
    [Authorize] // Разрешить доступ только аутентифицированным пользователям
    public class EditCarModel : PageModel
    {
        private readonly ICar _carRepository;

        public EditCarModel(ICar carRepository)
        {
            _carRepository = carRepository;
        }

        public Car Car { get; set; }

        public IActionResult OnGet(int id)
        {
            Car = _carRepository.GetCar(id);
            Car ??= new Car();
            Console.WriteLine($"Received Car ID: {Car.Id}, Brand: {Car.BrandCar}, Model: {Car.Model}, Engine: {Car.EngineCar}");
            return Page();
        }

        public IActionResult OnPost(Car carForm)
        {
            Console.WriteLine($"Received Car ID: {carForm.Id}, Brand: {carForm.BrandCar}, Model: {carForm.Model}, Engine: {carForm.EngineCar}");
            Car = _carRepository.UpdateCar(carForm);

            if (Car == null)
                return NotFound();

            return RedirectToPage("Cars");
        }
    }
}
