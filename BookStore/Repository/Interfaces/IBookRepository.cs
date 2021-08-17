using BookStore.ModelsDB;
using System.Collections;

namespace BookStore.Repository.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable BookByCategory();
        IEnumerable BookByAuthor();
    }
}
