using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName);
            Console.WriteLine("What is the computer's current status?");
            string status = Console.ReadLine();
            Console.WriteLine("Console Status: " + status);
            

        }
    }
}
