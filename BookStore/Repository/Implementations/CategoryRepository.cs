using BookStore.ModelsDB;
using BookStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository.Implementations
{
    public class CategoryRepository : Repository<Category> , ICategoryRepository
    {
        public CategoryRepository(bcBookStoreContext context) : base(context)
        {

        }
    }
}
