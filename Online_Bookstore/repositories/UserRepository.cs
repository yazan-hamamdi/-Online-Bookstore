using Online_Bookstore.Interfaces;
namespace Online_Bookstore
{
    public class UserRepository : ICrud<User> , IUserRepository
    {
        public List<User> Users { get; set; }
        public UserRepository() { }
        public UserRepository(List<User> users)
        {
            Users = users;
        }

        public List<User> GetAll()
        {
            return Users;

        }
        public void Create(User user)
        {
            Users.Add(user);
        }

        public User Read(int id)
        {
            return Users.Find(p => p.Id == id);
        }

        public bool Update(User user)
        {
            var Index = Users.FindIndex(p => p.Id == user.Id);
            if (Index != -1)
            {
                Users[Index] = user;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var user = Users.Find(p => p.Id == id);
            if (user != null)
            {
                Users.Remove(user);
                return true;
            }
            return false;
        }
    }
}
