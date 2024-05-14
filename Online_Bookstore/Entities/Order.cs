
using Online_Bookstore.Interfaces;
using System.Text;

namespace Online_Bookstore
{
    public class Order 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; } 
        public int TotalPrice { get; set; }
        public List<Product> Products {set; get; }
        public Order()
        {
            Products = new List<Product>();
        }
        public Order(int id, int userId, DateTime orderDate, int totalPrice, List<Product> product)
        {
            Id = id;
            UserId = userId;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            Products = product ?? new List<Product>();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order ID: {Id}, User ID: {UserId}, Order Date: {OrderDate}, Total Price: {TotalPrice}");
            sb.AppendLine("Products:");
            foreach (var product in Products)
            {
                sb.AppendLine(product.ToString());
            }
            sb.AppendLine("Electronic Products:");
            return sb.ToString();
        }
        
    }   
}
