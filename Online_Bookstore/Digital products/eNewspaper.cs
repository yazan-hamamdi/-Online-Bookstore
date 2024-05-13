using System.Text;
namespace Online_Bookstore
{
    public class eNewspaper : eProduct
    {
        public int Page_Size { get; set; }
        public eNewspaper()
        {
        }
        public eNewspaper(int id, string genre, string title, int price, string description, int page_size)
        {
            Id = id;
            Genre = genre;
            Title = title;
            Price = price;
            Description = description;
            Page_Size = page_size;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Download Link: {Page_Size}");
            return sb.ToString();
        }

    }
}
