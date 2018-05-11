using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class Book
    {
        [Key]
        public int ISBN { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Copies { get; set; }
        
    }
}
