﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }

        public Product product { get; set; }

        public int productId { get; set; }

        public int Amount { get; set; }


        public string ShoppingCartId { get; set; }

    }
}
