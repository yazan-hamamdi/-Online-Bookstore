using System.Text;

namespace Online_Bookstore
{
    public class Cart
    {
        public int Id { get; set; }
        public float Discount { get; set; }
        public List<Order> Orders { get; set; }
        public Cart()
        {
            Orders = new List<Order>();
        }

        public Cart(int id, float discount, List<Order> orders)
        {
            Id = id;
            Discount = discount;
            Orders = orders ?? new List<Order>();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cart ID: {Id}, Discount: {Discount}%");
            sb.AppendLine("Orders:");
            foreach (var order in Orders)
            {
                sb.AppendLine(order.ToString());
            }
            return sb.ToString();
        }
    }
}
