using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Commentproduct
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
