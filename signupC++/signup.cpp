#include <iostream>                                  // Libraries
#include <iomanip>
#include <windows.h>
#include <conio.h>
#include <string>
#include <limits>
#include <fstream>
using namespace std;
void login_header();                                    // header functions
void header();
string adminmenu();
string usermenu();
string signup(int &userCount);                          // function for sign-up
string signin(int &userCount);                          // function for sign-in
void clearScreen();
bool login(string name, string pin, int &userCount);
void readData(int &userCount);                           //function for file handling
string getField(string record, int field);
void writeData(int &userCount, string &name, string &pin, string &role);
void setColor(int colorCode);
void resetColor();
const int MAX_STUDENTS = 100;
const int Max_Users=200;
string userData[Max_Users][3];
bool passwordValidation(string password);
bool validate_name(const string &name); 
main()
{

    int userCount = 0;                        // local declared variables
    string user_name, pin, role;
    string option;
    string choice;
    readData(userCount);
    while (true)
    {

        login_header();
        setColor(97);
        cout << endl
             << endl;
        cout << "                            Select one of the following options number...";
        cout << endl
             << endl;
        cout << "                               1. SignIn with Your Credentials" << endl;
        cout << "                               2. SignUp to get Your Credential" << endl;
        cout << "                               3. Exit the Application";
        cout << endl
             << endl;
        cout << "                            Enter your choice: ";
        cin >> choice;
        resetColor();

        if (choice == "1")
        {
            string role = signin(userCount);
            if (role == "Admin")                                         // ADMIN ACCESS
            {
                cout << "Admin access granted." << endl;
                cin.ignore(numeric_limits<streamsize>::max(), '\n');

                while (true)
                {
                    system("cls");
                    header();
                    option = adminmenu();
                    if (option == "8")
                    {
                        break;
                    }
                    else
                    {
                        cout << "Invalid option. Please try again." << endl;
                    }

                    cout << "Press any key to return to the main menu..." << endl;
                    getch();
                }
            }
            else if (role == "user")                                                              // USER ACCESS
            {
                cout << "User access granted." << endl;

                while (true)
                {
                    system("cls");
                    header();
                    option = usermenu();
                    if (option == "8")
                    {
                        break;
                    }
                    else
                    {
                        cout << "Invalid option. Please try again." << endl;
                    }

                    cout << "Press any key to return to the main menu..." << endl;
                    getch();
                }
            }
        }
        else if (choice == "2")
        {
            string result = signup(userCount);
            setColor(32);
            cout << result << endl;
            resetColor();
        }
        else if (choice == "3")
        {
            system("cls");

            cout << endl
                 << endl
                 << "                                  .... YOU EXIT THE PROGRAME ...." << endl
                 << endl;
            cout << "                               Thanks! For Your Experience." << endl
                 << endl;
            break;
        }
        else
        {
            cout << "                            Invalid choice. Please try again." << endl;
        }
        clearScreen();
    }
    
}
bool login(string name, string pin, int &userCount)                                  //login function     
{
    for (int i = 0; i < userCount; i++)
    {
        if (userData[i][0] == name && userData[i][1] == pin)
        {
            return true;
        }
    }
    return false;
}

string signin(int &userCount)                                                       //sign-in function
{
    readData(userCount);
    string name, pin;
    cout << "                                   Enter username: ";
    cin >> name;
    cout << "                                   Enter password: ";
    cin >> pin;

    if (login(name, pin, userCount))
    {
        for (int i = 0; i < userCount; i++)
        {
            if (userData[i][0] == name && userData[i][2] == "Admin")
            {

                return "Admin";
            }
            if (userData[i][0] == name && userData[i][2] == "user")
            {
                return "user";
            }
        }
    }
    setColor(31);
    cout << "                                  Invalid credentials. Please try again." << endl;
    resetColor();
    return "";
}

string signup(int &userCount)                                                    // sign-up function
{
    if (userCount >= MAX_STUDENTS)
    {
        return "                                User limit reached. Cannot register more users.";
    }

    string name, pin, role;
    bool user_valid = false;
    do
    {
        cout << "                                  Enter a new username: ";
        cin >> name;
        if (validate_name(name))
        {
            user_valid = true;
        }
        else
        {
            cout << "                              Invalid name! Name should not contain any digits." << endl;
        }
    } while (!user_valid);
    cout << "                                  Enter a new password: ";
    cin >> pin;
    while (passwordValidation(pin))
    {
        cout << "                                  Password Must Contain At Least 3 character Try Again:   " << endl;
        cout << "                                  Enter a new password: ";
        cin >> pin;
    }

    bool role_valid = false;
    do
    {
        cout << "                                  Enter role: ";
        cin >> role;
        if (validate_name(role))
        {
            role_valid = true;
        }
        else
        {
            cout << "                              Invalid Role! Role should not contain any digits." << endl;
        }
    } while (!role_valid);

    fstream fread;
    string record;
    fread.open("credentials.txt", ios::in);
    while (getline(fread, record))
    {
        string present = getField(record, 1);
        if (present == name)
        {
            fread.close();
            return "                            Username already exists. Try a different one.";
        }
    }
    fread.close();
    writeData(userCount, name, pin, role);

    return "                                   Signup successful! You can now log in....";
}
void clearScreen()                                                      // screen clear function
{
    cout << "                                   Press any Key to continue.";
    getch();
    system("cls");
}
string adminmenu()                                                      //admin menu function
{
    string option;
    setColor(95);
    cout << "                       ****************************************************************************************************************" << endl;
    cout << "                       *                                              .....ADMIN MENU.....                                            *" << endl;
    cout << "                       ****************************************************************************************************************" << endl
         << endl;
    resetColor();
    setColor(97);
    cout << "1. Register a Student" << endl;
    cout << "2. Register a Senior" << endl;
    cout << "3. Remove a Student " << endl;
    cout << "4. Remove a Senior " << endl;
    cout << "5. Data of Registered students" << endl;
    cout << "6. Update the Data of Registered students" << endl;
    cout << "7. Diplay Feedback by other Students" << endl;
    cout << "8. logout..." << endl
         << endl;
    cout << "Enter Your option >..";
    cin >> option;
    resetColor();
    return option;
}
string usermenu()                                            // user menu function
{
    string option;
    setColor(95);
    cout << "                       ****************************************************************************************************************" << endl;
    cout << "                       *                                              .....USER  MENU.....                                            *" << endl;
    cout << "                       ****************************************************************************************************************" << endl
         << endl;
    resetColor();
    setColor(97);
    cout << "1. List of Available Subjects and Domain" << endl;
    cout << "2. Timetable of Registered Seniors" << endl;
    cout << "3. List of Registered students" << endl;
    cout << "4. Search your buddy matcher " << endl;
    cout << "5. Book your buddy matcher " << endl;
    cout << "6. Give Your Feedback " << endl;
    cout << "7. Diplay Feedback by other Students" << endl;
    cout << "8. logout..." << endl
         << endl;
    cout << "Enter Your option >..";
    cin >> option;
    resetColor();
    return option;
}
void header()                                                  // function to print the header
{
    setColor(95);
    cout << R"(                                                 ____  _             _         ____            _     _                    )" << endl;
    cout << R"(                                                / ___|| |_ _   _  __| |_   _  | __ ) _   _  __| | __| |_   _              )" << endl;
    cout << R"(                                                \___ \| __| | | |/ _` | | | | |  _ \| | | |/ _` |/ _` | | | |             )" << endl;
    cout << R"(                                                 ___) | |_| |_| | (_| | |_| | | |_) | |_| | (_| | (_| | |_| |             )" << endl;
    cout << R"(                                                |____/ \__|\__,_|\__,_|\__, | |____/ \__,_|\__,_|\__,_|\__, |             )" << endl;
    cout << R"(                                                                __  __  |___/_       _                  |___/             )" << endl;
    cout << R"(                                                               |  \/  | __ _| |_ ___| |__   ___ _ __                      )" << endl;
    cout << R"(                                                               | |\/| |/ _` | __/ __| '_ \ / _ \ '__|                     )" << endl;
    cout << R"(                                                               | |  | | (_| | || (__| | | |  __/ |                        )" << endl;
    cout << R"(                                                               |_|  |_|\__,_|\__\___|_| |_|\___|_|                        )" << endl;
    cout << endl
         << endl
         << endl;
    resetColor();
    cout << R"(                                                                 Welcome To ..STUDY BUDDY MATCHER..                        )" << endl;
    cout << endl
         << endl;
}
bool validate_name(const string &name)                      // function to validate string name
{

    for (int i = 0; i < name.length(); i++)
    {
        if (isdigit(name[i]))
        {
            return false;
        }
    }
    return true;
}
bool passwordValidation(string password)                    // function to validate password
{
    if (password.length() < 3)
    {
        return true;
    }
    return false;
}
void login_header()                        // function for login header
{
    header();
    setColor(95);
    cout << "                       ****************************************************************************************************************" << endl;
    cout << "                       *                                       LOGIN TO STUDY BUDDY MATCHER                                           *" << endl;
    cout << "                       ****************************************************************************************************************" << endl;
    resetColor();
}
void setColor(int colorCode)                   // function for add color
{

    cout << "\033[1;" << colorCode << "m";
}
void resetColor()                           // function to reset color
{

    cout << "\033[0m";
}
string getField(string record, int field)                    // function for CSV format
{
    int commaCount = 1;
    string item;

    for (int x = 0; x < record.length(); x++)
    {
        if (record[x] == ',')
        {
            commaCount++;
        }
        else if (commaCount == field)
        {
            item = item + record[x];
        }
    }
    return item;
}
void readData(int &userCount)                          // function to read data from file
{
    string record;
    fstream data;
    data.open("credentials.txt", ios::in);

    while (getline(data, record))
    {
        userData[userCount][0] = getField(record, 1);
        userData[userCount][1]= getField(record, 2);
        userData[userCount][2] = getField(record, 3);
        userCount++;
    }

    data.close();
}
void writeData(int &userCount, string &name, string &pin, string &role)        // function to write data
{
    fstream myFile;
    myFile.open("credentials.txt", ios::app);

    myFile << name << "," << pin << "," << role << "," << endl;

    myFile.close();
}    