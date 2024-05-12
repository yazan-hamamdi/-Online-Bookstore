

namespace Online_Bookstore
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; } 
        public int TotalPrice { get; set; }
    }
}
