using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore.User_Authentication
{
    public class Login
    {
        public UserRepository UserRepository { get; set; }

        public Login(UserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public bool AuthenticateUser(string email, string password)
        {
            User user = UserRepository.Users.Find(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                Console.WriteLine($"Welcome back, {user.Name}!");
                return true;
            }
            else
            {
                Console.WriteLine("Login failed. Invalid email or password.");
                return false;
            }
        }
    }
}
