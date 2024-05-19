using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5_c_ch
{
    public class Book
    {
        public string Name {  get; set; }
        public string Author { get; set; }
        public int Number_of_pages { get; set; }
        public int Age { get; set; }
        public Book(string name, string author, int numpages, int age) { 
            Name = name;
            Author = author;
            Number_of_pages = numpages;
            Age = age;

        }

        public void Info()
        {
            Console.WriteLine($"Название: {Name}, Автор: {Author}, кол-во страниц: {Number_of_pages}, год издания книги: {Age}");
        }

        public static bool operator ==(Book left, Book right)
        {
            
            left.Name = right.Name;
            left.Author == right.Author;
            left.Number_of_pages==right.Number_of_pages;
            left.Age == right.Age;
            return true;

        }
        public static bool operator !=(Book left, Book right)
        {
            left.Name = right.Name;
            left.Author = right.Author;
            left.Number_of_pages = right.Number_of_pages;
            left.Age = right.Age;
            return true;

        }

    }
}
