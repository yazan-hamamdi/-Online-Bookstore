using Online_Bookstore.Interfaces;
using System.Text;
namespace Online_Bookstore
{
    public class User 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Cart cart { get; set; }
        public User()
        {
            cart = new Cart();
        }
        public User(int id, string name, string email, string password, Cart cart)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            this.cart = cart;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {Id}, Name: {Name}, Email: {Email}, Password: {Password}");
            sb.AppendLine("Cart:");
            sb.AppendLine(cart.ToString());
            return sb.ToString();
        }
    }
}
