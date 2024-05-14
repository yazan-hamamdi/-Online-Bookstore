using Online_Bookstore.User_Authentication;

namespace Online_Bookstore
{
    public class Program
    {
        static void Main(string[] args)
        {
            // test UserRepository ,Login ,  Register
            /* UserRepository userRepository = new UserRepository(new List<User>
             {
                 new User(1, "John", "john@example.com", "password", new Cart()),
                 new User(2, "Alice", "alice@example.com", "123456", new Cart())
             });
             Register register = new Register(userRepository);
             Login login = new Login(userRepository);

             register.RegisterUser("Bob", "bob@example.com", "password123");


             Console.WriteLine();
             Console.WriteLine("Login Test:");
             login.AuthenticateUser("john@example.com", "password"); 
             login.AuthenticateUser("alice@example.com", "123456"); 
             login.AuthenticateUser("bob@example.com", "password123"); 
             login.AuthenticateUser("invalid@example.com", "invalidpassword"); */


            /*
             Book book1 = new Book(1, "Fiction", "The Great Gatsby", 20, "Classic novel", 97836, "Paperback");
             Book book2 = new Book(2, "Fantasy", "Harry Potter and the Philosopher's Stone", 25, "Fantasy novel", 97743, "Hardcover");
             Newspaper newspaper1 = new Newspaper(3, "News", "The New York Times", 5, "Daily newspaper", DateTime.Now);
             Newspaper newspaper2 = new Newspaper(4, "News", "The Guardian", 3, "Daily newspaper", DateTime.Now.AddDays(-1));

             ProductRepository productRepository = new ProductRepository(new List<Product> { book1, book2, newspaper1, newspaper2 });

             Console.WriteLine("All Products:");
             List<Product> allProducts = productRepository.GetAll();
             foreach (var product in allProducts)
             {
                 Console.WriteLine(product);
             }

             Console.WriteLine("\nAll Books:");
             List<Book> allBooks = productRepository.GetAllBooks();
             foreach (var book in allBooks)
             {
                 Console.WriteLine(book);
             }

             Console.WriteLine("\nAll Newspapers:");
             List<Newspaper> allNewspapers = productRepository.GetAllNewsPapers();
             foreach (var newspaper in allNewspapers)
             {
                 Console.WriteLine(newspaper);
             }

             Order order = new Order(1, 101, DateTime.Now, 45, new List<Product> { book1, newspaper1 });

             Console.WriteLine("\nOrder Details:");
             Console.WriteLine(order);
         */
        }

    }
}