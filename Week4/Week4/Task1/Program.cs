using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("                Welcome to Book Store");
                Console.WriteLine("1. Add a New Book");
                Console.WriteLine("2. Display All Books");
                Console.WriteLine("3. Search for a Book by Title");
                Console.WriteLine("4. Search for a Book by ISBN");
                Console.WriteLine("5. Update Book Stock");
                Console.WriteLine("6. Show Book Details");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Enter your Choice");
                string Choice = Console.ReadLine();

                if (Choice == "1")
                {
                    Console.Write("Enter Book Title  ");
                    string title = Console.ReadLine();

                    string []arr = new string[4];
                    for(int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine($"Enter Author {i + 1}  (or press Enter for stop): ");
                        arr[i] = Console.ReadLine();
                        if (string.IsNullOrEmpty(arr[i])) break;
                        
                    }

                    Console.Write("Enter Publisher Name  ");
                    string publisher = Console.ReadLine();
                    Console.Write("Enter ISBN  ");
                    string isbn = Console.ReadLine();
                    Console.Write("Enter price  ");
                    int price = int.Parse(Console.ReadLine());
                    Console.Write("Enter Number of copies of book  ");
                    int number = int.Parse(Console.ReadLine());

                    Book book = new Book(title, arr, publisher, isbn, price, number);
                    book.AddBook();
                }
                else if (Choice == "2")
                {
                    Console.WriteLine("All Books");
                    Book.DisplayBooks();
                }
                else if(Choice == "3")
                {
                    Console.WriteLine("Enter Title of Book:  ");
                    string title = Console.ReadLine();

                    Book book1 = new Book(title ," ",0);
                    book1.SearchbyTitle();
                }
                else if (Choice == "4")
                {
                    Console.WriteLine("Enter ISBN of Book:  ");
                    string isbn = Console.ReadLine();

                    Book book1 = new Book(" ",isbn,0);
                    book1.SearchbyISBN();
                }
                else if (Choice == "5")
                {
                    Console.WriteLine("Enter title of Book: ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter the Number of Copies of Book you want to Enter: ");
                    int copy = int.Parse(Console.ReadLine());

                    Book book1 = new Book(title, " ", copy);
                    Console.WriteLine(book1.UpdateStock());
                }
                else if (Choice == "6")
                {
                    Console.WriteLine("Books Detail");
                    Book.BookDetail();

                }
                else if(Choice == "7")
                {
                    Console.WriteLine("Exiting");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }

            }
        }
    }
}
