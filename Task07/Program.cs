using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    // shevkmnat wignebis klasi
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Page { get; set; } 

        // konsturktori
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
         

        }

        // informacia wignze
        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Year: {Year}";
        }
    }

    // bibliotekis klasi
    public class Library
    {
        private List<Book> books = new List<Book>(); // wignebis chamonatvali

        // raodenoba
        public int Count => books.Count;

        // wignis damatebis metodi
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Added: {book.Title} by {book.Author}");
        }

        // wignis washlis metodi
        public void RemoveBook(string title)
        {
            var bookToRemove = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Removed: {bookToRemove.Title} by {bookToRemove.Author}");
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }

        // wignis modzebnis metodi
        public List<Book> FindBook(string title)
        {
            return books.FindAll(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
        }

        // davbechdo ra wignebi maqvs bibliotekashi 
        public void PrintBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
                return;
            }

            Console.WriteLine("Books in the library:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // biblioteka
            Library library = new Library();

            // damatebis metodis gamoyeneba (?)
            library.AddBook(new Book("The Catcher in the Rye", "J.D. Salinger", 1951));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
            library.AddBook(new Book("1984", "George Orwell", 1949));

            // arsebuli wignebis chamonatvalis chveneba
            library.PrintBooks();

            // sasurveli wignis modzebna
            Console.WriteLine("\nFinding books with '1984' in the title:");
            var foundBooks = library.FindBook("1984");
            foreach (var book in foundBooks)
            {
                Console.WriteLine(book);
            }

            // bibliotekiashi arsebuli wignis washla
            library.RemoveBook("To Kill a Mockingbird");

            // washlili an damatebuli wignebis shemdgom arsebulis mdgomarebis chveneba wignebis siashi
            Console.WriteLine("\nAfter removing 'To Kill a Mockingbird':");
            library.PrintBooks();

            // wignebis sruli raodenoba
            Console.WriteLine($"\nNumber of books in the library: {library.Count}");
        }
    }
}