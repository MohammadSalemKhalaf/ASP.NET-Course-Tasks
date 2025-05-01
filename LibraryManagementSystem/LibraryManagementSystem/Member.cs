using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Member : Person
    {
        public List<Book> borrowedBooks { get; set; }
        public Member(int id, string name)
        {
            this.id = id;
            this.name = name;
            borrowedBooks = new List<Book>();
        }
        public override void DisplayInfo()
        {
            this.ToString();
        }
        public override string ToString()
        {
            return $"Member ID: {id}, Name: {name}";
        }
        public void BorrowBook(Book book)
        {
            if (book.isAvailable)
            {
                borrowedBooks.Add(book);
                book.isAvailable = false;
                Console.WriteLine("Book borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Book isn't Available.");
            }
        }
        public void ReturnBook(Book book)
        {
            if (borrowedBooks.Contains(book))
            {
                borrowedBooks.Remove(book);
                book.isAvailable = true;
                Console.WriteLine("Book returned successfully.");
            }
            else
            {
                Console.WriteLine("This book wasn't borrowed by you.");
            }
        }
        public void DisplayBorrowedBooks()
        {
            foreach (Book book in borrowedBooks)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
