using WebAppRazorPages.Model;

namespace WebAppRazorPages.Controller
{
    public class MocUserRepository : IUserRepository
    {
        private List<User> _users;
        public MocUserRepository() 
        { 
            _users ??= new List<User>();
            _users.Add(new() { Id_car = 1, BrandCar = "Ауди", Model = "RS6" });
            _users.Add(new() { Id_car = 2, BrandCar = "BMW", Model = "E-39" });
            _users.Add(new() { Id_car = 3, BrandCar = "Nissan", Model = "Primera P11" });
        }
        public User? GetUserById(int id_car) 
        {
            return _users.Where(u => u.Id_car == id_car).ToList().FirstOrDefault();            
        }

        public List<User> GetUsers() 
        {
            return _users;
        }

        public User UpdateUser(User upUser) 
        {
            var userDB = GetUserById(upUser.Id_car);
            if (userDB != null)
            {
                _users.Remove(userDB);
            }
            _users.Add(upUser);
            return upUser;
        }
    }
}
