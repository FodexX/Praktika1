using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPages.Controller;
using WebAppRazorPages.Model;

namespace WebAppRazorPages.Pages
{
    public class CarsModel : PageModel
    {
        public CarsModel(ICar carRepository) 
        {
            _carRepository = carRepository;
        }
        private ICar _carRepository;
        public List<Car> cars { get; set; }
        public IActionResult OnGet()
        {
            cars = _carRepository.GetAll();
            return Page();
        }
    }
}
