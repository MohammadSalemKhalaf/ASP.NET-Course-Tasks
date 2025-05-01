using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library
    {
        public List<Book> books { get; set; }
        public List<Member> members { get; set; }
        public Library() 
        {
            books=new List<Book>();
            members=new List<Member>();
        }
        public void AddBook(Book book) => books.Add(book);
        public void AddMember(Member member)=> members.Add(member);
        public Book FindBookById(int id)
        {
            foreach (var b in books)
            {
                if (b.id == id)
                {
                    Console.WriteLine(b.ToString());
                    return b;
                }
            }
            Console.WriteLine("Book not found.");
            return null;
        }
        public Member FindMemberById(int id)
        {
            foreach (var m in members)
            {
                if (m.id == id)
                {
                    Console.WriteLine(m.ToString());
                    return m;
                }
            }
                
                    Console.WriteLine("Member not found.");
                    return null;
                
            
        }
        public void DisplayBooks()
        {
            foreach (Book book in books) 
            {
                Console.WriteLine(book);//book.ToString());
            }
        }
        public void DisplayMembers()
        {
            foreach (Member member in members)
            {
                Console.WriteLine(member);//member.ToString());
            }
        }
    }
}
