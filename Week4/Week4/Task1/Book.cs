using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Book
    {
        public string Title;
        public string[] Authors;
        public string Publisher;
        public string ISBN;
        public int Price;
        public int Copies;

        public static Book[] bookArray = new Book[100];
        public static int bookCount = 0;

        public Book(string title, string[] arr, string publisher, string isbn, int price, int number)
        {
            Title = title;
            Authors = arr;
            Publisher = publisher;
            ISBN = isbn;
            Price = price;
            Copies = number;

        }
        public Book(string title, string isbn, int copy)
        {
            Title = title;
            ISBN = isbn;
            Copies = copy;

        }

       

        public void AddBook()
        {
            if (bookCount == 100)
            {
                Console.WriteLine("Sorry Limit Exceeded");
                return;
            }

            bookArray[bookCount] = this;
            bookCount++;
            Console.WriteLine("Book added Successfully");
        }

        public static void DisplayBooks()
        {
            for (int i = 0; i < bookCount; i++)
            {
                string authors = string.Join(", ", bookArray[i].Authors);
                Console.WriteLine($"Title: {bookArray[i].Title} , Authors: {authors}");
            }
        }

        public void SearchbyTitle()
        {
            bool found = false;
            for (int i = 0; i < bookCount; i++)
            {
                if (bookArray[i].Title == Title)
                {
                    string authors = string.Join(", ", bookArray[i].Authors);
                    Console.WriteLine($"Title: {bookArray[i].Title}, Authors: {authors}, Publisher: {bookArray[i].Publisher}, ISBN: {bookArray[i].ISBN}, Price: {bookArray[i].Price}, Copies: {bookArray[i].Copies}");
                    found = true; break;
                }
                else
                {
                    found = false;
                }
            }
            if (!found)
            {
                Console.WriteLine("Book not Present.");
            }
        }

        public void SearchbyISBN()
        {
            bool found = false;
            for (int i = 0; i < bookCount; i++)
            {
                if (bookArray[i].ISBN == ISBN)
                {
                    string authors = string.Join(", ", bookArray[i].Authors);
                    Console.WriteLine($"Title: {bookArray[i].Title}, Authors: {authors}, Publisher: {bookArray[i].Publisher}, ISBN: {bookArray[i].ISBN}, Price: {bookArray[i].Price}, Copies: {bookArray[i].Copies}");
                    found = true; break;
                }
                else
                {
                    found = false;
                }
            }
            if (!found)
            {
                Console.WriteLine("Book not Present.");
            }

        }
        public string UpdateStock()
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (bookArray[i].Title == Title)
                {

                    bookArray[i].Copies = bookArray[i].Copies + Copies;
                }

            }
            return "Book Stock Updated Successfully";
        }
        public static void BookDetail()
        {
            for (int i = 0; i < bookCount; i++)
            {
                string authors = string.Join(", ", bookArray[i].Authors);
                Console.WriteLine($"Title: {bookArray[i].Title}, Authors: {authors}, Publisher: {bookArray[i].Publisher}, ISBN: {bookArray[i].ISBN}, Price: {bookArray[i].Price}, Copies: {bookArray[i].Copies}");
                
            }

        }
    }
    
}
