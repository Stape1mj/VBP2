using System;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thanks for using my application! What is your name?");
            string name = Console.ReadLine();

           Console.WriteLine($"\r\nHi {name}! You can travel to anywhere in the world. Where would you like to go? Jamaica?");
           Console.ReadLine();
           Console.WriteLine("\r\nYou chose Jamaica! How many days are you going to be there?" );
            int days = Int32.Parse(Console.ReadLine());
           
           Console.WriteLine("\r\nHow much $$$ do you plan on bringing?");
            double money = Double.Parse(Console.ReadLine());
            double sMoney = Math.Round((money / days), 2);

            Console.WriteLine($"\r\nSo if you're there for {days} days, with ${money}, you'll be able to spend ${sMoney} per day");
            Console.ReadLine();

        }
    }
}
