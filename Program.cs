using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Islam's Carpet Cleaning Service
            //    Charges:
            //        25 per small
            //        35 per large
            //    Sales tax rate is 6 %
            //    Estimates are valid for 30 days

            //    Prompt the user for the number of small and large rooms they would like cleaned
            //    and provide an estimate such as:


            //Estimate for carpet cleaning service
            //Number of small carpets: 3 < --
            //Number of large carpets: 1 < --
            //Price per small room: 25
            //Price per large room: 35
            //Cost : 110
            //Tax: 6.6 => Cost * 0.06
            //===============================
            //Total estimate: 116.6
            //This estimate is valid for 30 days
            Console.WriteLine("Number of small carpets:");
            int smcarpet =int.Parse(Console.ReadLine ());
            Console.WriteLine("Number of large carpets:");
            int largecarpet = int.Parse(Console.ReadLine());
            Console.WriteLine("Price per small room: 25");
            Console.WriteLine("Price per large room: 35");
            int cost = (smcarpet*25) + (largecarpet*35);
            Console.WriteLine($"Cost : {cost}");
          
            double total = cost * 1.06;
            Console.WriteLine($"total after tax = {total}");

            Console.WriteLine("This estimate is valid for 30 days");


        }
    }
}
