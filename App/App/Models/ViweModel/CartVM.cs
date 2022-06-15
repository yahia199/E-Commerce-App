using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.ViweModel
{
    public class CartVM
    {
        public static List<Product> products { get; set; }

        static CartVM()
        {
            products = new List<Product>();
        }
    }
}
