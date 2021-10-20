using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.ModelsHelpers
{
   public  class BookViewModel
    {
        public Guid IdBook { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Cover { get; set; }
        public DateTime Published { get; set; }
        public double Price { get; set; }
        public int NbPages { get; set; }
        public  string  Author { get; set; }
        public  string Categorie { get; set; }
    }
}
