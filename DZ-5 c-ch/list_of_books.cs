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
        private List<Book>books;
        public list_of_books(int num) {
            books=new List<Book>(num);
        }
        public void AddBook(Book book)
        {
            books.Add(book);    
        }
        public void RemoveBook(Book book) {
           books.Remove(book);
        }
        public void Clear()
        {
            books.Clear();
        }
        



       
        
    }
}
