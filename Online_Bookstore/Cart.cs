namespace Online_Bookstore
{
    public class Cart
    {
        public int Id { get; set; }
        public float Discount { get; set; }
        public List<Order> orders { get; set; }
        public Cart()
        {
            orders = new List<Order>();
        }

        public Cart(int id, float discount, List<Order> orders)
        {
            Id = id;
            Discount = discount;
            orders = orders ?? new List<Order>();
        }

    }
}
