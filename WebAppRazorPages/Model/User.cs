using System.ComponentModel.DataAnnotations;

namespace WebAppRazorPages.Model
{
    public class User
    {
        public int Id_car { get; set; }
        [Required(ErrorMessage = "Введите марку машины")]
        public string BrandCar { get; set; }
        [Required(ErrorMessage = "Введите модель")]
        public string Model { get; set; }
        public string EngineCar { get; set; }
        public User() 
        { 
            BrandCar ??= string.Empty;
            Model ??= string.Empty;
            EngineCar ??= string.Empty;
        }
    }
}
