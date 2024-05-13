namespace Online_Bookstore
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string? Genre { get; set; }
        public string? Title { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
        public abstract void Add_Packaging();
        

    }
}
