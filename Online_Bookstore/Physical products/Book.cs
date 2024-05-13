

namespace Online_Bookstore
{
    public class Book : Product
    {
        public int ISBN { get; set; }
        public string? Paper_Type { get; set; }
        public Book()
        {
        }
        public Book(int id, string genre, string title, int price, string description, int isbn, string paperType)
        {
            Id = id;
            Genre = genre;
            Title = title;
            Price = price;
            Description = description;
            ISBN = isbn;
            Paper_Type = paperType;
        }

        public override int Add_Packaging()
        {
            return Price += 10;
        }
        public override string ToString()
        {
            return base.ToString() + $", Date of Publication: {ISBN}, Paper Type:{Paper_Type}";
        }
    }
}
