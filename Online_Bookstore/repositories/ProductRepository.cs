using Online_Bookstore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore
{
    public class ProductRepository : ICrud<Product>, IProductRepository
    {
        public List<Product> Products { get; set; }
        public ProductRepository() { }
        public ProductRepository(List<Product> products)
        {
            Products = products;
        }

        public List<Product> GetAll()
        {
            return Products;

        }
        public List<Book> GetAllBooks()
        {
            return Products.OfType<Book>().ToList();
        }
        public List<Newspaper> GetAllNewsPapers()
        {
            return Products.OfType<Newspaper>().ToList();
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
    }
}
