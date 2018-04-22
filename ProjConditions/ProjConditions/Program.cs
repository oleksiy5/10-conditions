using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjConditions
{
    class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();

            switch (command)
            {
                case "abc":
                    Console.WriteLine("Pierwsze litery alfabetu.");
                    break;
                case "123":
                    Console.WriteLine("Pierwsze cyfry.");
                    break;
                case "007":
                    Console.WriteLine("James Bond");
                    break;
                case "olo":
                    Console.WriteLine("Olo Technic");
                    break;
                default:
                    Console.WriteLine("domyślne działanie");
                    break;
            }   
            

        }
    }
}
