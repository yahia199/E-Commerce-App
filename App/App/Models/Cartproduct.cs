﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Cartproduct
    {
        public Cart Cart { get; set; }
        public int CartId { get; set; }

        public Product Products { get; set; }
        public int ProductId { get; set; }
    }
}