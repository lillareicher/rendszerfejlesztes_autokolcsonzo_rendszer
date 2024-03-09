using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vmi
{
    internal class Class_main
    {
        static void Main(string[] args)
        {
            bool dalmaIttJart = true;
            bool exit = false;

            while(!exit)
            { 
                Console.Write("Please enter a number from 0 to 10: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("The input type is incorrect. Please enter a valid type of number!");
                    continue;
                }
                if(choice < 0 || choice > 10)
                {
                    Console.WriteLine("The input value is incorrect. Please enter a valid number between 0 to 10!");
                    continue;
                }
                Console.Clear();
            }
        }

    }
}
