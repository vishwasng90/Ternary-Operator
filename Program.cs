using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good night.";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
