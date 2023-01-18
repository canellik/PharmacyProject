using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProject.Sells
{
    internal class Cart
    {
        public static List<Cart> CartList = new List<Cart>();
        public string Medicine { get; set; }
        public string Customer { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public DateTime SoldDate { get; set; }
    }
}
