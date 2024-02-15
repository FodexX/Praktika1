using WebAppRazorPages.Model;

namespace WebAppRazorPages.Controller
{
    public interface ICar
    {
        public Car Add(Car Icar);
        public Car? GetCar(int Id);
        public List<Car> GetAll();
        public Car UpdateCar(Car upCar);
        public List<Car> DeleteCar(int Id);
    }
}
