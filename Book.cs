using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    class Book
    {

        public string title;
        public string author;
        public int pages;

        //this below is called a constructor
        public Book(string aTitle, string aAuthor,int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
