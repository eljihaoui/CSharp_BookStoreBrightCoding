using BookStore.ModelsDB;
using BookStore.Repository.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository.Implementations
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(bcBookStoreContext context):base(context)
        {

        }
        public IEnumerable BookByAuthor()
        {
            throw new NotImplementedException();
        }

        public IEnumerable BookByCategory()
        {
            throw new NotImplementedException();
        }
    }
}
