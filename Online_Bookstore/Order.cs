

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
    }
}
