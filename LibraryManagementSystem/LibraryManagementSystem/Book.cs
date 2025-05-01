using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public Book(int id, string title, string author)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.isAvailable = true;
        }

        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public bool isAvailable { get; set; }
        public override string ToString()
        {
            return $"{id} - {title} by {author} - {(isAvailable ? "Available" : "Not Available")}";
        }
    }
}
