using BookStore.ModelsDB;
using BookStore.Repository.Interfaces;

namespace BookStore.Repository.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly bcBookStoreContext _context;
        public IAuthorRepository Authors { get; private set; }

        public IBookRepository Books { get; private set; }

        public ICategoryRepository Categorys { get; private set; }

        public UnitOfWork(bcBookStoreContext context)
        {
            _context = context;
            Authors = new AuthorRepository(_context);
            Books = new BookRepository(_context);
            Categorys = new CategoryRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
