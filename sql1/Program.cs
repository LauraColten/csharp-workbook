using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace sql1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Cat in the Hat", Type.Childrens);
            Book b2 = new Book("The Hobbit", Type.Fiction);


            Dao dao = new Dao();
            dao.create("Cat in the Hat", Type.Childrens);
            dao.create("The Hobbit", Type.Fiction);

            foreach(Book b in dao.listBooks())
            {
                Console.WriteLine(b.title+" is of the genre " +b.type);
            }


        }
    }

    public class Book
    {
        public int id { get; private set;}
        public string title { get; private set;}
        public Type type { get; private set;}

        public Book()
        {

        }
        public Book(string initialTitle, Type initialType)
        {
            this.title = initialTitle;
            this.type = initialType;
        }
    }

    public enum Type
    {
            Fiction,
            NonFiction,
            Biography,
            Childrens
    }

    public class Dao
    {
        private BooksContext context;
        public Dao()
        {
            context = new BooksContext();
            context.Database.EnsureCreated();
        }

        public void create(string title, Type type)
        {
            Book newBook = new Book(title, type);
            context.books.Add(newBook);
            context.SaveChanges();
        }

        public IEnumerable<Book> listBooks()
        {
            List<Book> result = new List<Book>();
            foreach(Book b in context.books)
            {
                result.Add(b);
            }
            return result;
        }

        public List<Book> listFictionBooks()
        {
            List<Book> fictionBooks = new List<Book>();

            foreach(Book b in context.books)
            {
                if (b.type == Type.Fiction)
                {
                    fictionBooks.Add(b);
                }
            }
            return fictionBooks;
        }

        public class BooksContext : DbContext
        {
            public DbSet<Book> books { get; private set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
                optionsBuilder.UseSqlite("Filename=./books.db");
            }
        }

    }


}
