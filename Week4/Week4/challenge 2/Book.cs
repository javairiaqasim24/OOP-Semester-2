using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_2
{
    internal class Book
    {
        public string title;
        public string publisher;

        public static  List<string> Authors=new List<string>();

        public string ISBN;
        public float price;
        public float stock;
        public int year;
        public int numberofAuthors;

        public static List <Book> books=new List<Book> ();
        public Book() { }
        public Book(string a,  string c, string d, float e,float f,int g, int h)
        {

            title = a;
            publisher = c;
            ISBN= d;    
            price = e;
            stock = f;
            year = g;
            numberofAuthors = h;
        }
        public Book(string a)
        {
            this.title = a;
        }
        public void AddBook()
        {

            books.Add(this);
        }
        public void Addauthor(string a)
        {
            Authors.Add(a);
        }
    }
}
