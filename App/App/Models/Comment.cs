using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Comment
    {
        public int Id{ get; set; }
        public string Content { get; set; }

        public int UserId { get; set; }

        public List<Commentproduct> Commentproducts { get; set; }

    }
}
