using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPages.Controller;
using WebAppRazorPages.Model;

namespace WebAppRazorPages.Pages
{
    public class EditCarModel : PageModel
    {
        private readonly ICar _carRepository;

        public EditCarModel(ICar carRepository)
        {
            _carRepository = carRepository;
        }

        [BindProperty]
        public Car Car { get; set; }
        public Car BrandCar { get; set; }
        public Car Model { get; set; }
        public Car EngineCar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Car = _carRepository.GetCar(id.Value);

            if (Car == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var updatedCar = _carRepository.UpdateCar(Car);
            
            return RedirectToPage("/Cars");
        }
    }
}