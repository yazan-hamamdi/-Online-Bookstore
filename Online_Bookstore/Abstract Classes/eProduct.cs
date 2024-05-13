using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore
{
    public abstract class eProduct
    {
        public int Id { get; set; }
        public string? Genre { get; set; }
        public string? Title { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
        public abstract void AddToCart();
    }
}
