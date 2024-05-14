using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        List<Book> GetAllBooks();
        List<Newspaper> GetAllNewsPapers();
    }
}
