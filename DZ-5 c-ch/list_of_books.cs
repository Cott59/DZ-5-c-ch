using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5_c_ch
{
    public class list_of_books
    {
        private Book[] books;
        public list_of_books(int num) {
            books=new Book[num];
        }

        public void AddBook(Book book, int num)
        {
            if(num<books.Length-1)
                books[num] = book;
        }
        public void RemoveBook(Book book) {
           
        }
        public Book GetBook(int num)
        {
            
        }

    }
}
