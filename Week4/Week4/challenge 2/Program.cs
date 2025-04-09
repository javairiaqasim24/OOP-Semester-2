using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge_2;

namespace challenge3
{
    internal class Program
    {
        static float totalsales = 0;

        static void Main(string[] args)
        {
            int opt = Menu();
            while (opt!=11)
            {
                if (opt == 1)
                {
                    Book book = TakeInput();
                    book.AddBook();
                }

                else if (opt == 2)
                {
                    Console.WriteLine("Enter name : ");
                    string a=Console.ReadLine();
                    if (SearchBook(a))
                    {
                        Console.WriteLine("Search successful");

                    }
                    else
                    {
                        Console.WriteLine("Book no found");
                    }

                }
                else if (opt == 3)
                {
                    Console.WriteLine("Enter ISBN ");
                    string a = Console.ReadLine();
                    if (SearchBookTTL(a))
                    {
                        Console.WriteLine("Search successful");

                    }
                    else
                    {
                        Console.WriteLine("Book no found");
                    }

                }
                else if (opt == 4)
                {
                    Console.WriteLine("Enter title of book: ");
                    string ttl=Console.ReadLine();
                    foreach(Book b in Book.books)
                    {
                        if (b.title == ttl)
                        {
                            Console.WriteLine("Enter new stock: ");
                            float stck=float.Parse(Console.ReadLine());
                            b.stock= stck;
                            Console.WriteLine("Stock updated...");
                        }
                    }

                }
                else if (opt == 5)
                {
                    Member m=TakeInputMember();
                    m.AddMembers();

                }
                else if (opt == 6)
                {
                    Console.WriteLine("Enter name : ");
                    string a = Console.ReadLine();
                    if (SearchMember(a))
                    {
                        Console.WriteLine("Search successful");

                    }
                    else
                    {
                        Console.WriteLine("Member no found");
                    }
                }
                else if (opt == 7)
                {
                    Console.WriteLine("Enter the name that u want to update: ");
                    string nm=Console.ReadLine();
                    foreach(Member m in Member.members)
                    {
                        if (m.name == nm)
                        {
                            m.UpdateMember();
                        }
                    }
                }
                else if(opt == 8)
                {

                    PurchaseBook();
                }

                else if (opt == 9)
                {
                    Console.WriteLine("The total sales are " + totalsales);
                }
                else if ( opt==10)
                {
                    int count=0;
                    foreach (Member m in Member.members)
                    {
                        count++;
                    }
                    Console.WriteLine("The total members are " + count);
                    Console.WriteLine("The total member ship fee is $" + count * 10);
                }
                opt = Menu();
            }
        }

        static int Menu()
        {
            Console.WriteLine("1. add book");
            Console.WriteLine("2. search book by title");
            Console.WriteLine("3. search book by ISBN");
            Console.WriteLine("4. Update stock of a book ");
            Console.WriteLine("5. add member");
            Console.WriteLine("6. search member by name");
            Console.WriteLine("7. update member info");
            Console.WriteLine("8. Purchase book");
            Console.WriteLine("9. display total sales");
            Console.WriteLine("10. display no of members and total membership fee");
            Console.WriteLine("11. exit" );
            Console.WriteLine("chose one option..");
            int o=int.Parse(Console.ReadLine());
            return o;
        }
        static Book TakeInput()
        {
            Console.WriteLine("enter title ");
            string a=Console.ReadLine();

            
            Console.WriteLine("enter publisher");
            string c=Console.ReadLine();

            Console.WriteLine("enter isbn ");
            string d = Console.ReadLine();

            Console.WriteLine("enter price ");
            float e=float.Parse(Console.ReadLine());

            Console.WriteLine("enter stock");
            float f = float.Parse(Console.ReadLine());


            Console.WriteLine("enter yeear");
            int g = int.Parse(Console.ReadLine());


            Console.WriteLine("enter number of authors ");
            int h = int.Parse(Console.ReadLine());
            
            Book bo =new Book(a,c,d,e,f,g,h);
            for (int i = 0; i < h; i++)
            {
                Console.WriteLine("enter author ");
                bo.Addauthor(Console.ReadLine());
            }
            return bo;
        }

        static bool SearchBook(string a)
        {
            foreach(Book b in Book.books)
            {
                if (b.title == a)
                {
                    Console.WriteLine("Book Found");
                    Console.WriteLine("Title: " + b.title);
                    Console.WriteLine("ISBN: " + b.ISBN);
                    Console.WriteLine("Stock: " + b.stock);
                    Console.WriteLine("Year: " + b.year);
                    Console.WriteLine("Price: " + b.price);
                    return true;
                }
            }
            return false;
        }
        static bool SearchBookTTL(string a)
        {
            foreach (Book b in Book.books)
            {
                if (b.ISBN == a)
                {
                    Console.WriteLine("Book Found");
                    Console.WriteLine("Title: " + b.title);
                    Console.WriteLine("ISBN: " + b.ISBN);
                    Console.WriteLine("Stock: " + b.stock);
                    Console.WriteLine("Year: " + b.year);
                    Console.WriteLine("Price: " + b.price);
                    return true;
                }
            }
            return false;
        }
        static Member TakeInputMember()
        {
            string a, b, c;
            int d;
            float e,f;
            Console.WriteLine("name: ");
            a=Console.ReadLine();
            Console.WriteLine("id: ");
            b=Console.ReadLine();
            Console.WriteLine("number of books bought: ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("books bought: ");
            c=Console.ReadLine();
            Console.WriteLine("money in bank : ");
            e=float.Parse(Console.ReadLine());
            Console.WriteLine("amount spent: ");
            f=float.Parse(Console.ReadLine());

            Member member = new Member(a,b,c,d,e,f);
            return member;
        }
        static bool SearchMember(string a)
        {
            foreach (Member m in Member.members)
            {
                if (m.name == a)
                {
                    Console.WriteLine("Member Found");
                    Console.WriteLine("Name: " + m.name);
                    Console.WriteLine("ID: " + m.ID);
                    Console.WriteLine("no of boks: " + m.numberOfBooks);
                    Console.WriteLine("money in bank: " + m.moneyInBank);
                    Console.WriteLine("amount spent: " + m.AmountSpent);
                    return true;
                }
            }
            return false;
        }
        static void PurchaseBook()
        {
            Console.WriteLine("Enter name: ");
            string name=Console.ReadLine();
            Console.WriteLine("enter id(0 if not member):");
            string id=Console.ReadLine();   
            foreach(Member m in Member.members)
            {
                if (m.name==name && m.ID == id)
                {
                    Console.WriteLine("Enter NAME of book: ");
                    string t=Console.ReadLine();
                    foreach(Book b in Book.books)
                    {
                        if (b.title ==t)
                        {
                           Console.WriteLine("enter quantity: ");
                            float p=float.Parse(Console.ReadLine());
                            float ttlp = p * b.price;
                            if (m.ID != "0")
                            {
                                ttlp -= ttlp * 5 / 100;
                            }
                            m.moneyInBank-=ttlp;
                            m.AmountSpent += ttlp;
                            totalsales += ttlp;
                            Console.WriteLine("Book purchased");
                            break;
                        }
                    }
                }
            }
        }
    }
}
