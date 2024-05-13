

namespace Online_Bookstore
{
    public class Book : Product
    {
        public int ISBN { get; set; }
        public string? Paper_Type { get; set; }
        public Book()
        {
        }
        public Book(int id, string genre, string title, int quantity, int price, string description, int isbn, string paperType)
        {
            Id = id;
            Genre = genre;
            Title = title;
            Quantity = quantity;
            Price = price;
            Description = description;
            ISBN = isbn;
            Paper_Type = paperType;
        }

        public override void Add_Packaging()
        {
            throw new NotImplementedException();
        }
    }
}
