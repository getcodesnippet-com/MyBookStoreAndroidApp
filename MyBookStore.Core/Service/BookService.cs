using MyBookStore.Core.Model;
using MyBookStore.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.Core.Service
{
    public class BookService
    {
        private static BookRepository bookRepository = new BookRepository(); 

        public BookService()
        {

        }

        public List<Book> GetAllBooks()
        {
            return bookRepository.GetAllBooks(); 
        }

        public Book GetBookById(int bookId)
        {
            return bookRepository.GetBookById(bookId); 
        }

        public List<Book> GetFavoriteBooks()
        {
            return bookRepository.GetFavoriteBooks(); 
        }

        public List<Category> GetAllCategoriesWithBooks()
        {
            return bookRepository.GetAllCategoriesWithBooks(); 
        }

        public List<Book> GetBooksByCategoryId(int categoryId)
        {
            return bookRepository.GetBooksByCategoryId(categoryId); 
        }


    }
}
