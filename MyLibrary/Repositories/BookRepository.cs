using MyLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    public class BookRepository
    {
        private AppContext _context;

        public void FindBookByID()
        {
            _context.Books.FirstOrDefault();

        }

        public void FindAllBooksUsers()
        {
            _context.Books.ToList();

        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);

        }

        public void DeleteBook(Book book)
        {
            _context.Books.Remove(book);
        }

        public void UpdateDatePublished(int id, DateTime datePublished)
        {
            _context.Books.FirstOrDefault().DatePublished = datePublished;
        
        
        }

        public void SelectBookByGenre(string genre)
        { 
            var books = _context.Books.Where(b => b.Genre == genre).ToList();
            foreach (var book in books) 
            {
                Console.WriteLine(book);
            }
        
        }
        public void SumBooksByAuthor(string author)
        {
            var count = _context.Books.Where(b => b.Author == author).Sum(b => b.Id);
            Console.WriteLine($"Количество книг автора: {author}: {count}");
        
        }
        public void SumBooksByGenre(string genre)
        {
            var count = _context.Books.Where(b => b.Genre == genre).Sum(b => b.Id);
            Console.WriteLine($"Количество книг жанра {genre}: {count}");

        }
        public void IsBookHavingByAuthorAndTitle(string author, string title)
        {
            bool hasBook;
            var countBook = _context.Books.Where(b => b.Author == author && b.Title == title).Count();
            if (countBook > 0)
            { 
                hasBook = true;
                Console.WriteLine(hasBook);
            } 
        }
        public void IsBookOnUserHands(int userId)
        {
            bool hasBookByUser;

            var onUserBooks = _context.Books.Where(b => b.UserId == userId).Count();
            if (onUserBooks > 0)
            { 
                hasBookByUser = true;
                Console.WriteLine(hasBookByUser);
            }
        }

        public void CountBooksByUserHands(int userId)
        {
            var books = _context.Books.Where(b => b.UserId == userId).Count();
            Console.WriteLine(books);


        }

        public void LastBookByDatePublished()
        { 
            var book = _context.Books.OrderByDescending(b => b.DatePublished);
            var lastBook = book.FirstOrDefault();
            Console.WriteLine(lastBook);
        }

        public void SelectAllBookASC()
        {
            var allBooks = _context.Books.OrderBy(b => b.Title).Select(b => b.Title);

            foreach ( var book in allBooks ) 
            {
                Console.WriteLine(book);

            }
        
        }
        public void SelectAllBookDescByDatePublished() 
        {
            var books = _context.Books.OrderByDescending(b => b.DatePublished).Select(b => b.Title);

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        
        }
    }
}
