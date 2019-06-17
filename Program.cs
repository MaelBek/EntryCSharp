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
            // -- 2.7 -- Exercises
            //2.8


            //2.7
            //int x, y = 5;
            //x = ++y * 2;
            //x = y++;
            //x = y--;
            //Console.WriteLine(++y);
            //Console.ReadLine();


            //2.6
            //int x, y = 4;
            //x = (y -= 2);
            //x = y++;
            //x = y--;
            //Console.WriteLine("{0},{1}",x,y);
            //Console.ReadLine();

            //2.5
            //int x = 2, y = 3;
            //Console.WriteLine(x *= y * 2);
            //Console.ReadLine();

            //2.4
            //int x = 100;
            //Console.WriteLine(++x * 2);
            //Console.ReadLine();

            //2.3
            //double BMI, wzrost;
            //int masa;
            //Console.WriteLine("Podaj mase ciała: ");
            //masa = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Podaj wzrost: ");
            //wzrost = Convert.ToDouble(Console.ReadLine());
            //BMI = masa / (Math.Pow(wzrost, 2));
            //Console.WriteLine("Twoje BMI to: {0:F1}", BMI);
            //Console.ReadLine();

            //2.2
            //int a, b, c, delta, x1, x2;
            //double deltaK;
            //int deltaK1;
            //Console.WriteLine("Wprowadź wartość a:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Wprowadź wartość b:");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Wprowadź wartość c:");
            //c = Convert.ToInt32(Console.ReadLine());
            //delta = (b * b) - (4 * a * c);
            //deltaK = Math.Sqrt(delta);
            //deltaK1 = (int)deltaK;
            //x1 = (-b + deltaK1) / (2 * a);
            //x2 = (-b - deltaK1) / (2 * a);
            //Console.WriteLine("Wartość delta wynosi: {0}", delta);
            //Console.WriteLine("Pierwiastek z delta wynosi: {0:F2}", deltaK);
            //Console.WriteLine("x = {0}{1}", x1, x2);
            //Console.ReadLine();



            //2.1
            //double c, f;
            //Console.WriteLine("Podaj stopnie celsjusza: ");
            //c = Convert.ToDouble(Console.ReadLine());
            //f = 32 + ((9.0 / 5) * c);
            //Console.WriteLine("Stopnie w Farenheit wynoszą:{0}", f);
            //Console.ReadLine();











            // -- 2.6 -- prezentacja wyników / output presentation


            //2.19
            //int suma = 10;
            //double x = 10.23256, y = 62.36, wskaznik = 0.45;
            //string imie = "Ala", naz = "Nowak";
            //Console.WriteLine("1. Imię: {0,15} Nazwisko: {1,55}", imie, naz);
            //Console.WriteLine("2. Imię: {0,15} Nazwisko: {1,50}", imie, naz);
            //Console.WriteLine("2. Imię: {0,10} Nazwisko: {1,50}", imie, naz);
            //Console.WriteLine("2. Imię: {0,5} Nazwisko: {1,60}", imie, naz);
            //Console.WriteLine("2. Imię: {0} Nazwisko: {1,65}", imie, naz);
            //Console.WriteLine("2a. Imię: {0,-15} Nazwisko: {1,-5}", imie, naz);
            //Console.WriteLine("2a. Imię: {0,-15} Nazwisko: {1,-10}", imie, naz);
            //Console.WriteLine("2a. Imię: {0,-15} Nazwisko: {1,-15}", imie, naz);
            //Console.WriteLine("3. Wartość: {0, 10} to suma", suma);
            //Console.WriteLine("4. Wartość: {0, -10} to suma", suma);
            //Console.WriteLine("5. Wskaźnik: {0, 8:P}", wskaznik);
            //Console.WriteLine("6. Waga: {0, 10}kg", x);
            //Console.WriteLine("7. {0, -10:F4} (cztery cyfry po przecinku)", x);
            //Console.WriteLine("8. Wartość: X={0, -10:F4}, Y={1,-10:F2}", x, y);
            //Console.WriteLine("9. A ta liczba będzie w klamrach {{{0}}}", y);
            //Console.ReadLine();
            // -- 2.5 --


            //2.17

            //int x = 1, y = 1;
            //Console.WriteLine((x++ + 2) * ++y);
            //Console.ReadKey();

            //Console.WriteLine(6 / 2 * (2 + 1));
            //Console.ReadLine();

            //int a, b, c = 10;
            //a = b = c;
            //Console.WriteLine(a);
            //Console.WriteLine(a + b + c);
            //Console.ReadLine();


            //String Lessons


            //2.15
            //Console.WriteLine("Linia1\nLinia2s"); //przejście do nowej linii
            //Console.WriteLine("Wzrost 170\tWaga 80"); //t - tabulacja
            //Console.WriteLine(@"Wzrost 170\tWaga 80"); //@ - Dosłowna interpretacja
            //Console.WriteLine("C:\\System\\Windows"); //Podwójne \\ wstawia jedno \
            //Console.WriteLine("Tytuł filmu: \"Rój\""); //\" wstawia "
            //Console.ReadLine();

            //2.14
            //string tekst;
            //Console.WriteLine("Give a name:");
            //tekst = Console.ReadLine();
            //Console.WriteLine(tekst + 10);
            //Console.ReadLine();

            //2.13
            //string tekst;
            //Console.WriteLine("Please enter your name: ");
            //tekst = Console.ReadLine();
            //tekst = "Cześć " + tekst;
            //Console.WriteLine(tekst);
            //Console.WriteLine(tekst.Length);
            //Console.ReadLine();


        }
    }
}
