using Online_Bookstore.Interfaces;
using System.Text;

namespace Online_Bookstore
{
    public class Cart : ICrud<Order>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public float Discount { get; set; }
        public List<Order> Orders { get; set; }
        public Cart()
        {
            Orders = new List<Order>();
        }
        public Cart(int id,int userId, float discount, List<Order> orders)
        {
            Id = id;
            UserId = userId;
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
        public void Create(Order order)
        {
            Orders.Add(order);
        }
        public Order Read(int id)
        {
            return Orders.Find(o => o.Id == id);
        }

        public bool Update(Order UPorder)
        {
            var Index = Orders.FindIndex(o => o.Id ==  UPorder.Id);
            if (Index != -1)
            {
                Orders[Index] = UPorder;
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            var order = Orders.Find(o => o.Id ==  Id);
            if (order != null) 
            {
               Orders.Remove(order);
                return true;
            } 
            return false;
        }
    }
}
