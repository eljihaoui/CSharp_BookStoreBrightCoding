using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.ModelsDB
{
    public partial class Category
    {
        public Category()
        {
            Books = new HashSet<Book>();
        }

        public Guid IdCateg { get; set; }
        public string Categ { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
