using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTasksWeek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter your name : ");
            name=Console.ReadLine();
            Console.WriteLine("Hello,"+name+"!");

            Console.WriteLine("Dispaly numbers :");   //Task2
            for (int i = 10; i > 0; i--)
            {
                Console.Write(i+" ");
            }


            Console.WriteLine("Enter the number : ");                      //task3
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= number; i++)
            {   
                result = result + i;
                
            }
            Console.WriteLine(result);


            Console.WriteLine("Enter the number : ");                //task4
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even number ");

            }
            else
            {
                Console.WriteLine("Odd number ");
            }


            Console.WriteLine("Enter the Word :");                //task5
            string word;
            word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }

            
            int[] array= new int[5];                                    //task6
            Console.WriteLine("Enter 5 Numbers :");
            for (int i = 0; i < 5; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());   
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("["+array[i]+" ]");
            }


        }
    }
}
