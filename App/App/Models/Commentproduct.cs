using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Commentproduct
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }

        public Comment Comment { get; set; }
        public int CommentId { get; set; }
    }
}
