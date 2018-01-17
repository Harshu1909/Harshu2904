using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------Lab Task1--------");
           
            Console.WriteLine("Which Country you flied from:");
            String country = Console.ReadLine();

            Console.WriteLine("How many bags you has with you:");
            String bags = Console.ReadLine();


            Console.WriteLine("How many the total weight of your luggage:");
            String weight = Console.ReadLine();


            int avg = int.Parse(weight) / int.Parse(bags);

          
            
            Console.WriteLine("I flew from "+country+" having "+bags+" bags with average weight of "+ avg);
            Console.ReadKey();
            

        }
    }
}
