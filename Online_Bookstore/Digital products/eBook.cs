

namespace Online_Bookstore
{
    public class eBook : eProduct
    {
        public string? DownloadLink { get; set; }
        public string? PdfLink { get; set; }
        public eBook()
        {
        }
        public eBook(int id, string genre, string title, int quantity, int price, string description, string downloadLink, string pdfLink)
        {
            Id = id;
            Genre = genre;
            Title = title;
            Quantity = quantity;
            Price = price;
            Description = description;
            DownloadLink = downloadLink;
            PdfLink = pdfLink;
        }

        public override void AddToCart()
        {
            throw new NotImplementedException();
        }
    }

}
