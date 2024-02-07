using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPages.Controller;
using WebAppRazorPages.Model;

namespace WebAppRazorPages.Pages
{
    public class UserModel : PageModel
    {
        public UserModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        private IUserRepository _userRepository;
        public User? User { get; set; }
        public IActionResult OnGet(int id_car = 1) 
        {
            User = _userRepository.GetUserById(id_car); // запрашиваем у контроллера пользователся и id_car из параметра
            if (User == null) return NotFound(); // если пользватель не нашелся выкидываем ошибку HTTP 404
            return Page(); // выводим страницу пользователя
        }
    }
}
