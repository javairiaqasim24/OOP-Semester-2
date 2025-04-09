
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;

namespace signup
{
    internal class Program
    {
        
        
       public static List<MUser> users = new List<MUser>();
        static void Main(string[] args)
        {

            string name, pin, role;
            string option;
            string choice;

            

            while (true)
            {

                ReadData();
                LoginHeader();
                SetColor(97);
                Console.WriteLine("\n\n                            Select one of the following options number...\n\n");
                Console.WriteLine("                               1. SignIn with Your Credentials");
                Console.WriteLine("                               2. SignUp to get Your Credential");
                Console.WriteLine("                               3. Exit the Application\n\n");
                Console.Write("                            Enter your choice: ");
                ResetColor();

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("                                   Enter username: ");
                     name = Console.ReadLine();
                    Console.Write("                                   Enter password: ");
                     pin = Console.ReadLine();
                    MUser sign=new MUser(name, pin,"");
                    string role2 =sign.SignIn(users,SetColor,ResetColor);
                    if (role2 == "Admin")
                    {
                        Console.WriteLine("Admin access granted.");

                        while (true)
                        {
                            Console.Clear();
                            Header();
                            option = AdminMenu();
                            Console.Clear();
                            if (option == "8")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid option. Please try again.");
                            }

                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey();
                        }
                    }
                    else if (role2 == "user")
                    {
                        Console.WriteLine("User access granted.");

                        while (true)
                        {
                            Console.Clear();
                            Header();
                            option = UserMenu();
                            Console.Clear();
                            if (option == "8")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid option. Please try again.");
                            }

                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey();
                        }
                    }
                }
                else if (choice == "2")
                {
                    

                   
                    bool user_valid = false;
                    do
                    {
                        Console.Write("                                  Enter a new username: ");
                        name = Console.ReadLine();
                        if (ValidateName(name))
                        {
                            user_valid = true;
                        }
                        else
                        {
                            Console.WriteLine("                              Invalid name! Name should not contain any digits.");
                        }
                    } while (!user_valid);

                    Console.Write("                                  Enter a new password: ");
                    pin = Console.ReadLine();
                    while (!PasswordValidation(pin))
                    {
                        Console.WriteLine("                                  Password Must Contain At Least 3 characters. Try Again:");
                        Console.Write("                                  Enter a new password: ");
                        pin = Console.ReadLine();
                    }

                    bool role_valid = false;
                    do
                    {
                        Console.Write("                                  Enter role: ");
                         role = Console.ReadLine();
                        if (ValidateName(role))
                        {
                            role_valid = true;
                        }
                        else
                        {
                            Console.WriteLine("                              Invalid Role! Role should not contain any digits.");
                        }
                    } while (!role_valid);

                    if (File.Exists("credentials.txt"))
                    {
                        foreach (var line in File.ReadLines("credentials.txt"))
                        {
                            string present = GetField(line, 1);
                            if (present == name)
                            {
                                Console.WriteLine( "                            Username already exists. Try a different one.");
                            }
                        }
                    }
                    MUser sigUp = new MUser(name,pin,role);
                    string result = sigUp.SignUp();
                    SetColor(32);
                    Console.WriteLine(result);
                    ResetColor();
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine("\n\n                                  .... YOU EXIT THE PROGRAM ....\n\n");
                    Console.WriteLine("                               Thanks! For Your Experience.\n\n");
                    break;
                }
                else
                {
                    Console.WriteLine("                            Invalid choice. Please try again.");
                }

                ClearScreen();
            }
        }

        static void LoginHeader()
        {
            Header();
            SetColor(95);
            Console.WriteLine("                       ****************************************************************************************************************");
            Console.WriteLine("                       *                                       LOGIN TO STUDY BUDDY MATCHER                                           *");
            Console.WriteLine("                       ****************************************************************************************************************");
            ResetColor();
        }

        static void Header()
        {
            SetColor(95);
            Console.WriteLine("                                                 ____  _             _         ____            _     _                    ");
            Console.WriteLine("                                                / ___|| |_ _   _  __| |_   _  | __ ) _   _  __| | __| |_   _              ");
            Console.WriteLine("                                                \\___ \\| __| | | |/ _` | | | | |  _ \\| | | |/ _` |/ _` | | | |             ");
            Console.WriteLine("                                                 ___) | |_| |_| | (_| | |_| | | |_) | |_| | (_| | (_| | |_| |             ");
            Console.WriteLine("                                                |____/ \\__|\\__,_|\\__,_|\\__, | |____/ \\__,_|\\__,_|\\__,_|\\__, |             ");
            Console.WriteLine("                                                                __  __  |___/_       _                  |___/             ");
            Console.WriteLine("                                                               |  \\/  | __ _| |_ ___| |__   ___ _ __                      ");
            Console.WriteLine("                                                               | |\\/| |/ _` | __/ __| '_ \\ / _ \\ '__|                     ");
            Console.WriteLine("                                                               | |  | | (_| | || (__| | | |  __/ |                        ");
            Console.WriteLine("                                                               |_|  |_|\\__,_|\\__\\___|_| |_|\\___|_|                        ");
            Console.WriteLine();
            Console.WriteLine("                                                                 Welcome To ..STUDY BUDDY MATCHER..                        ");
            ResetColor();
        }

        
        

        

        static void ReadData()
        {
            if (File.Exists("credentials.txt"))
            {
                foreach (var line in File.ReadLines("credentials.txt"))
                {
                    string userName = GetField(line, 1);
                    string password = GetField(line, 2);
                    string role = GetField(line, 3);
                    MUser user = new MUser(userName, password, role);
                    users.Add(user);
                    
                }
            }
        }

        

        static string GetField(string record, int field)
        {
            int commaCount = 0;
            string item = "";

            foreach (char ch in record)
            {
                if (ch == ',')
                {
                    commaCount++;
                }
                else if (commaCount == field - 1)
                {
                    item += ch;
                }
            }

            return item;
        }

        static bool ValidateName(string name)
        {
            foreach (char ch in name)
            {
                if (char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        static bool PasswordValidation(string password)
        {
            return password.Length >= 3;
        }

        static void SetColor(int colorCode)
        {
            
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void ResetColor()
        {
            Console.ResetColor();
        }

        static string AdminMenu()
        {
            SetColor(95);
            Console.WriteLine("                       ****************************************************************************************************************");
            Console.WriteLine("                       *                                              .....ADMIN MENU.....                                            *");
            Console.WriteLine("                       ****************************************************************************************************************\n");
            ResetColor();
            SetColor(97);
            Console.WriteLine("1. Register a Student");
            Console.WriteLine("2. Register a Senior");
            Console.WriteLine("3. Remove a Student ");
            Console.WriteLine("4. Remove a Senior ");
            Console.WriteLine("5. Data of Registered students");
            Console.WriteLine("6. Update the Data of Registered students");
            Console.WriteLine("7. Display Feedback by other Students");
            Console.WriteLine("8. Logout...\n");
            Console.Write("Enter Your option >.. ");
            ResetColor();
            return Console.ReadLine();
        }

        static string UserMenu()
        {
            SetColor(95);
            Console.WriteLine("                       ****************************************************************************************************************");
            Console.WriteLine("                       *                                              .....USER  MENU.....                                            *");
            Console.WriteLine("                       ****************************************************************************************************************\n");
            ResetColor();
            SetColor(97);
            Console.WriteLine("1. List of Available Subjects and Domain");
            Console.WriteLine("2. Timetable of Registered Seniors");
            Console.WriteLine("3. List of Registered students");
            Console.WriteLine("4. Search your buddy matcher ");
            Console.WriteLine("5. Book your buddy matcher ");
            Console.WriteLine("6. Give Your Feedback ");
            Console.WriteLine("7. Display Feedback by other Students");
            Console.WriteLine("8. Logout...\n");
            Console.Write("Enter Your option >.. ");
            ResetColor();
            return Console.ReadLine();
        }

        static void ClearScreen()
        {
            Console.WriteLine("                                   Press any Key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
    }

}

