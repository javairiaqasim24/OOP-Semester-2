using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labmauunal4
{
    internal class Program
    {
        static void Main()
        {
            Member member = null;
            int choice;

            while(true) 
            {
                Console.WriteLine("\n*** Menu ***");
                Console.WriteLine("1. Create Member");
                Console.WriteLine("2. Add Book to Member");
                Console.WriteLine("3. Show Member Details");
                Console.WriteLine("4. Modify Member Name");
                Console.WriteLine("5. Modify Bank Balance");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice==1)
                {
                   

                        Console.Write("Enter Member Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Member ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Money in Bank: ");
                        double moneyInBank = double.Parse(Console.ReadLine());

                        member = new Member(name, id, moneyInBank);
                        Console.WriteLine("Member created successfully.");
                        break;
                }

                   else if (choice == 2) {
                        if (member != null)
                        {

                            Console.Write("Enter Book Title: ");
                            string bookTitle = Console.ReadLine();
                            Console.Write("Enter Book Price: ");
                            double bookPrice = double.Parse(Console.ReadLine());

                            member.AddBook(bookTitle, bookPrice);
                        }
                        else
                        {
                            Console.WriteLine("Please create a member first.");
                        }
                        break;
                    }

                    else if (choice == 3) {
                        if (member != null)
                        {

                            member.ShowDetails();
                        }
                        else
                        {
                            Console.WriteLine("Please create a member first.");
                        }
                        break;
                    }

                    else if (choice == 4) {
                        if (member != null)
                        {

                            Console.Write("Enter New Name: ");
                            string newName = Console.ReadLine();
                            member.ModifyName(newName);
                        }
                        else
                        {
                            Console.WriteLine("Please create a member first.");
                        }
                        break;
                    }

                    else if (choice == 5) {
                        if (member != null)
                        {

                            Console.Write("Enter New Bank Balance: ");
                            double newBalance = double.Parse(Console.ReadLine());
                            member.ModifyBankBalance(newBalance);
                        }
                        else
                        {
                            Console.WriteLine("Please create a member first.");
                        }
                        break;
                    }

                    else if (choice == 6) {

                        Console.WriteLine("Exiting program.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                    }

            } 
        }
    }
}

