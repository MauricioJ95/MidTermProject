using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        private string author;
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public Book()
        {
            title = "";
            author = "";
        }
        public Book(string titleBook, string authorBook)
        {
            title = titleBook;
            author = authorBook;
        }
    }
}
