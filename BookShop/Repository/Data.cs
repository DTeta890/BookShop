using BookShop.Models;
using System.Collections.Generic;

namespace BookShop.Repository
{
    public class Data
    {
        // Book mockup data
        static List<Book> Books = new List<Book>()
        {
            new Book { Id=1, Name="Jack Ma & Alibaba", Author="Chen Wei", ISBN="9781911498261", Description="Jack Ma Book Description" },
            new Book { Id=2, Name="Shoe Dog", Author="Phil Knight", ISBN="1508211809", Description="Nike Book Description" },
            new Book { Id=3, Name="Elon Musk", Author="Ashley Vance", ISBN="006230125X", Description="Tesla Book Description" },
            new Book { Id=4, Name="Steve Jobs", Author="Walter Isaacson", ISBN="1451648537", Description="Apple Book Description" },
            new Book { Id=5, Name="Shoe Dog", Author="Jeff Bozes", ISBN="1647820715", Description="Amazon Book Description" }
        };

        // Person mockup data
        static List<Person> People = new List<Person>()
        {
            new Person {Id=1, Name="Deivid", Age=19, BookId=2},
            new Person {Id=2, Name="Alfredo", Age=18, BookId=1},
            new Person {Id=3, Name="Kristina", Age=19, BookId=2},
            new Person {Id=4, Name="Andi", Age=19, BookId=3},
            new Person {Id=5, Name="Djana", Age=19, BookId=3},
            new Person {Id=6, Name="Sajmon", Age=18, BookId=1},
            new Person {Id=7, Name="Anisa", Age=19, BookId=4},
            new Person {Id=8, Name="Arlind", Age=20, BookId=5},
            new Person {Id=9, Name="Fabio", Age=19, BookId=2},
            new Person {Id=10, Name="Endris", Age=19, BookId=4},
            new Person {Id=11, Name="Enes", Age=17, BookId=5},
            new Person {Id=12, Name="Sindi", Age=19, BookId=2},
            new Person {Id=13, Name="Klaudia", Age=19, BookId=1},
            new Person {Id=14, Name="Ester", Age=19, BookId=4},
            new Person {Id=15, Name="Melisa", Age=19, BookId=2},
        };

        static public List<Book> getAllBooks() // Returns the list of books
        {
            return Books;
        }

        static public Book getBookInfo(int bookId) // Returns a specific Book from bookId
        {
            return Books.Find(m => m.Id == bookId);
        }

        static public List<Person> getPersonByBook(int bookId) // Returns a list of Person from bookId
        {
            return People.FindAll(m => m.BookId == bookId);
        }
    }
}
