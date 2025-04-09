using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_2
{
    internal class Member
    {
        public static List<Member> members = new List<Member>();


        public string name;
        public string ID;
        public static List<string> BooksBought;
        public int numberOfBooks;
        public float moneyInBank;
        public float AmountSpent;

        public Member() { }
        public Member(string a, string b, string c , int e,float f, float g)
        {
            this.name = a;
            this.ID = b;
            BooksBought.Add(c);
            this.numberOfBooks = e;
            this.moneyInBank = f;
            this.AmountSpent = g;
        }

        public void AddMembers()
        {

            members.Add(this);
        }


        public void UpdateMember() 
        {
            Console.WriteLine("name: ");
            name=Console.ReadLine();
            Console.WriteLine("id: ");
            ID = Console.ReadLine();
            Console.WriteLine("number of books bought: ");
            numberOfBooks = int.Parse(Console.ReadLine());
            Console.WriteLine("books bought: ");
            BooksBought.Add( Console.ReadLine());
            Console.WriteLine("money in bank : ");
            moneyInBank = float.Parse(Console.ReadLine());
            Console.WriteLine("amount spent: ");
           AmountSpent = float.Parse(Console.ReadLine());

        }
    }
}
