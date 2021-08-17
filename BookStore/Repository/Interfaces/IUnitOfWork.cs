using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository Authors { get;  }
        IBookRepository Books { get; }
        ICategoryRepository  Categorys { get;  }
        int Complete();
    }
}
