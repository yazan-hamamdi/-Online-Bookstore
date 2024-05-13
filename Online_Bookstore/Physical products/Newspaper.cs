using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore
{
    internal class Newspaper : Product
    {
        public DateTime Date_Of_Publication {set; get; }
        public override void Add_Packaging()
        {
        }
    }
}
