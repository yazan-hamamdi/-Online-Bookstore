
namespace Online_Bookstore
{
    internal class Newspaper : Product
    {
        public DateTime Date_Of_Publication {set; get; }
        public Newspaper()
        {
        }
        public Newspaper(int id, string genre, string title, int price, string description, DateTime date_of_publication)
        {
            Id = id;
            Genre = genre;
            Title = title;
            Price = price;
            Description = description;
            Date_Of_Publication = date_of_publication;
        }

        public override int Add_Packaging()
        {
            return Price += 5;
        }
        public override string ToString()
        {
            return base.ToString() + $", Date of Publication: {Date_Of_Publication.ToShortDateString()}";
        }
    }
}
