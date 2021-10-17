using BookStore.ModelsDB;
using BookStore.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;

namespace BookStore.Repository.Implementations
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(bcBookStoreContext context) : base(context)
        {

        }

        public bcBookStoreContext _bcBookStoreContext { get => _context as bcBookStoreContext; }

        public IEnumerable BookByAuthor()
        {
            return _bcBookStoreContext.Books.Include(a => a.Author)
                 .GroupBy(a => a.Author.Name)
                 .Select(grpAuthor => new { Author = grpAuthor.Key, Books = grpAuthor.Count() })
                 .OrderByDescending(a => a.Books)
                 .ToList();
        }

        public IEnumerable BookByCategory()
        {
            return _bcBookStoreContext.Books.Include(a => a.Category)
             .GroupBy(a => a.Category.Categ)
             .Select(grpCateg => new { Category = grpCateg.Key, Books = grpCateg.Count() })
             .OrderByDescending(a => a.Books)
             .ToList();
        }
    }
}
