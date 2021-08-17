using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.ModelsDB
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public Guid IdAuthor { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
