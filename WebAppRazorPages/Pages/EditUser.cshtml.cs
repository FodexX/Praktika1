using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPages.Controller;
using WebAppRazorPages.Model;

namespace WebAppRazorPages.Pages
{
    public class EditUserModel : PageModel
    {

        public EditUserModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        private IUserRepository _userRepository;
        public User? User { get; set; }

        public string? Model { get; set; }
        public string? BrandCar { get; set; }
        
        public string? EngineCar { get; set; }

        public IActionResult OnGet(int id_car)
        {
            User = _userRepository.GetUserById(id_car);
            User ??= new();
            return Page();
        }

        public IActionResult OnPost(User? userForm)
        {
            
            var userDB = _userRepository.UpdateUser(userForm);
            if (userDB == null) return NotFound();
            return Page();
        }
    }
}