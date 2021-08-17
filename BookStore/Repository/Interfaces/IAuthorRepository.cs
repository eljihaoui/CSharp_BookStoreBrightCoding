using BookStore.ModelsDB;
using System.Collections;

namespace BookStore.Repository.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable TopAuthor(int count);
    }
}
