using MyBookStore.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.Core.Repository
{
    public class BookRepository
    {
        public BookRepository()
        {

        }


        public List<Book> GetAllBooks()
        {

            IEnumerable<Book> books =
                from bookCategory in bookCategories
                from book in bookCategory.Books
                select book;

            return books.ToList<Book>(); 
        }


        public Book GetBookById(int bookId)
        {
            IEnumerable<Book> books =
                from bookCategory in bookCategories
                from book in bookCategory.Books
                where book.BookId == bookId
                select book;

            return books.FirstOrDefault(); 
        }

        public List<Book> GetFavoriteBooks()
        {
            IEnumerable<Book> books =
                from bookCategory in bookCategories
                from book in bookCategory.Books
                where book.IsFavorite
                select book;

            return books.ToList<Book>(); 
        }

        public List<Category> GetAllCategoriesWithBooks()
        {
            return bookCategories; 
        }

        public List<Book> GetBooksByCategoryId(int categoryId)
        {
            IEnumerable<Book> books =
                from bookCategory in bookCategories
                from book in bookCategory.Books
                where bookCategory.CategoryId == categoryId
                select book;

            return books.ToList<Book>(); 
        }


        private static List<Category> bookCategories = new List<Category>()
        {
            new Category()
            {
                CategoryId = 1,
                Title = "Category A",
                ImagePath =  "",

                Books = new List<Book>()
                {
                    new Book()
                    {
                        BookId = 1,
                        Name = "Book 1",
                        Available = true,
                        ShortDescription = "This is book 1 short description",
                        Description = "This is book 1 detailed description. You can add more details about the book in this property",
                        IsFavorite = true,
                        Price = 14,
                        ImagePath = "book1"
                       
                    },

                    new Book()
                    {
                        BookId = 2,
                        Name = "Book 2",
                        Available = true,
                        ShortDescription = "This is book 2 short description",
                        Description = "This is book 2 detailed description. You can add more details about the book in this property",
                        IsFavorite = true,
                        Price = 12,
                        ImagePath = "book2"

                    },

                    new Book()
                    {
                        BookId = 3,
                        Name = "Book 3",
                        Available = true,
                        ShortDescription = "This is book 3 short description",
                        Description = "This is book 3 detailed description. You can add more details about the book in this property",
                        IsFavorite = false,
                        Price = 16,
                        ImagePath = "book3"

                    },


                }

            },

            new Category()
            {
                CategoryId = 2,
                Title = "Category B",
                ImagePath =  "",

                Books = new List<Book>()
                {
                    new Book()
                    {
                        BookId = 4,
                        Name = "Book 4",
                        Available = true,
                        ShortDescription = "This is book 4 short description",
                        Description = "This is book 4 detailed description. You can add more details about the book in this property",
                        IsFavorite = false,
                        Price = 11,
                        ImagePath = "book4"

                    },

                    new Book()
                    {
                        BookId = 5,
                        Name = "Book 5",
                        Available = true,
                        ShortDescription = "This is book 5 short description",
                        Description = "This is book 5 detailed description. You can add more details about the book in this property",
                        IsFavorite = true,
                        Price = 9,
                        ImagePath = "book5"

                    },

                    new Book()
                    {
                        BookId = 6,
                        Name = "Book 6",
                        Available = true,
                        ShortDescription = "This is book 6 short description",
                        Description = "This is book 6 detailed description. You can add more details about the book in this property",
                        IsFavorite = false,
                        Price = 12,
                        ImagePath = "book6"

                    },
                }
             },

            new Category()
            {
                CategoryId = 3,
                Title = "Category C",
                ImagePath =  "",

                Books = new List<Book>()
                {
                    new Book()
                    {
                        BookId = 7,
                        Name = "Book 7",
                        Available = true,
                        ShortDescription = "This is book 7 short description",
                        Description = "This is book 7 detailed description. You can add more details about the book in this property",
                        IsFavorite = false,
                        Price = 15,
                        ImagePath = "book7"

                    },

                    new Book()
                    {
                        BookId = 8,
                        Name = "Book 8",
                        Available = true,
                        ShortDescription = "This is book 8 short description",
                        Description = "This is book 8 detailed description. You can add more details about the book in this property",
                        IsFavorite = true,
                        Price = 17,
                        ImagePath = "book8"

                    },

                    new Book()
                    {
                        BookId = 9,
                        Name = "Book 9",
                        Available = true,
                        ShortDescription = "This is book 9 short description",
                        Description = "This is book 9 detailed description. You can add more details about the book in this property",
                        IsFavorite = false,
                        Price = 9,
                        ImagePath = "book9"

                    },
                }
             }



        }; 
    }
}
