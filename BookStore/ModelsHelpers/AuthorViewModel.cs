using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.ModelsHelpers
{
    class AuthorViewModel
    {
        public Guid IdAuthor { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int  nbBooks { get; set; }
    }
}
