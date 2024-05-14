namespace Online_Bookstore
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public abstract int Add_Packaging();
        public override string ToString()
        {
            return $"ID: {Id}, Title: {Title}, Genre: {Genre}, Price: {Price}, Description: {Description}";
        }

    }
}
