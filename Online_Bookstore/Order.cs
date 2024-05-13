

using Online_Bookstore.Interfaces;
using System.Text;

namespace Online_Bookstore
{
    public class Order : ICrud<Product>, IECrud<Product>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; } 
        public int TotalPrice { get; set; }
        public List<Product> Products {set; get; }
        public List<eProduct> eProducts { set; get; }

        public Order()
        {
            Products = new List<Product>();
            eProducts = new List<eProduct>();
        }
        public Order(int id, int userId, DateTime orderDate, int totalPrice, List<Product> product, List<eProduct> eproducts)
        {
            Id = id;
            UserId = userId;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            Products = product ?? new List<Product>();
            eProducts = eproducts ?? new List<eProduct>();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order ID: {Id}, User ID: {UserId}, Order Date: {OrderDate}, Total Price: {TotalPrice}");
            sb.AppendLine("Products:");
            foreach (var product in Products)
            {
                sb.AppendLine(product.ToString());
            }
            sb.AppendLine("Electronic Products:");
            foreach (var eproduct in eProducts)
            {
                sb.AppendLine(eproduct.ToString());
            }
            return sb.ToString();
        }

        public void Create(Product product)
        {
            Products.Add(product);
        }

        public Product Read(int id)
        {
            return Products.Find(p => p.Id == id);
        }

        public bool Update(Product UPproduct)
        {
            var Index = Products.FindIndex(p => p.Id == UPproduct.Id);
            if (Index != -1)
            {
                Products[Index] = UPproduct;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var product = Products.Find(p => p.Id == id);
            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            return false;
        }

        public void eCreate(Product product)
        {
            Products.Add(product);
        }

        public Product eRead(int id)
        {
            return Products.Find(p => p.Id == id);
        }

        public bool eUpdate(Product UPproduct)
        {
            var Index = Products.FindIndex(p => p.Id == UPproduct.Id);
            if(Index != -1) 
            {
                Products[Index] = UPproduct;
                return true;
            }
            return false;
        }

        public bool eDelete(int id)
        {
            var product = Products.Find(p => p.Id == id);
            if (product != null) 
            {
                Products.Remove(product);
                return true;
            }
            return false;
        }
    }

       
    
}
