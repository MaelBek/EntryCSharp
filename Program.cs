using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Lessons
            string tekst;
            Console.WriteLine("Please enter your name: ");
            tekst = Console.ReadLine();
            tekst = "Cześć " + tekst;
            Console.WriteLine(tekst);
            Console.WriteLine(tekst.Length);
            Console.ReadLine();


        }
    }
}
