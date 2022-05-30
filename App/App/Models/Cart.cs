using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Cart
    {
        public int Id{ get; set; }

        public int TotalPrice { get; set; }

        public int UserId{ get; set; }

        public List<Cartproduct> Cartproducts { get; set; }

    }
}
