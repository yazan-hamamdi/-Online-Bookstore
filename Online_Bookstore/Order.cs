

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
        public List<eProduct> eProducts { set; get; }

        public Order()
        {
            Products = new List<Product>();
            eProducts = new List<eProduct>();
        }
        public Order(int id, int userId, DateTime orderDate, int totalPrice, List<Product> product, List<eProduct> eproducts)
        {
            Id = id;
            UserId = userId;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            Products = product ?? new List<Product>();
            eProducts = eproducts ?? new List<eProduct>();
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
            foreach (var eproduct in eProducts)
            {
                sb.AppendLine(eproduct.ToString());
            }
            return sb.ToString();
        }
    }
}
