using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Member
{
   
    public string Name;
    public int MemberID;
    public List<string> BooksBought;
    public int NumberOfBooksBought;
    public double MoneyInBank;
    public double AmountSpent;

    
    public Member(string name, int memberID, double moneyInBank)
    {
        Name = name;
        MemberID = memberID;
        BooksBought = new List<string>();
        NumberOfBooksBought = 0;
        MoneyInBank = moneyInBank;
        AmountSpent = 0.0;
    }

    
    public void AddBook(string bookTitle, double bookPrice)
    {
        if (MoneyInBank >= bookPrice)
        {
            BooksBought.Add(bookTitle);
            NumberOfBooksBought++;
            MoneyInBank -= bookPrice;
            AmountSpent += bookPrice;
            Console.WriteLine($"Book '{bookTitle}' added to the list. Money left in bank: {MoneyInBank:C}");
        }
        else
        {
            Console.WriteLine("Not enough money in bank to purchase this book.");
        }
    }

    
    public void ShowDetails()
    {
        Console.WriteLine($"Member ID: {MemberID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Number of Books Bought: {NumberOfBooksBought}");
        Console.WriteLine("Books Bought:");
        foreach (var book in BooksBought)
        {
            Console.WriteLine($"- {book}");
        }
        Console.WriteLine($"Money in Bank: {MoneyInBank:C}");
        Console.WriteLine($"Amount Spent: {AmountSpent:C}");
    }


    public void ModifyName(string newName)
    {
        Name = newName;
        Console.WriteLine($"Member's name updated to: {Name}");
    }

    
    public void ModifyBankBalance(double newBalance)
    {
        MoneyInBank = newBalance;
        Console.WriteLine($"New bank balance: {MoneyInBank:C}");
    }
}