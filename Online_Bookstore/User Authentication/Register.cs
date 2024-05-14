

namespace Online_Bookstore.User_Authentication
{
    public class Register
    {
        public UserRepository UserRepository { get; set; }

        public Register(UserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public void RegisterUser(string name, string email, string password)
        {
            int newUserId = UserRepository.Users.Count + 1;

            User newUser = new User(newUserId, name, email, password, new Cart());

            UserRepository.Create(newUser);

            Console.WriteLine($"User {name} registered successfully!");
        }
    }
}
