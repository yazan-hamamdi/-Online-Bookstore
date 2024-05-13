

using System.Text;

namespace Online_Bookstore
{
    public class eBook : eProduct
    {
        public string? DownloadLink { get; set; }
        public string? PdfLink { get; set; }
        public eBook()
        {
        }
        public eBook(int id, string genre, string title, int price, string description, string downloadLink, string pdfLink)
        {
            Id = id;
            Genre = genre;
            Title = title;
            Price = price;
            Description = description;
            DownloadLink = downloadLink;
            PdfLink = pdfLink;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Download Link: {DownloadLink}");
            sb.AppendLine($"PDF Link: {PdfLink}");
            return sb.ToString();
        }

    }

}
