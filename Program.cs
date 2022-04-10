using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var a = new Complex(1, -4);
            var b = new Complex(2, 5);
            var c = new Complex(1, -4);
            Console.WriteLine("Комплексні чмсла:");
            String cmd = a.ToString();
            Console.WriteLine($"a = {cmd}");
            cmd = b.ToString();
            Console.WriteLine($"b = {cmd}");
            cmd = c.ToString();
            Console.WriteLine($"c = {cmd}\n");

            Complex x = new Complex();
            x = x.Subtraction(a, b);
            cmd = x.ToString();
            Console.WriteLine($"Віднімання: а - b = {cmd}");

            x = x.Division(a, c);
            cmd = x.ToString();
            Console.WriteLine($"Ділення: а / c = {cmd}");

            x = x.Conj(a);
            cmd = x.ToString();
            Console.WriteLine($"Комплексно спряжене число: а = {cmd}");

            bool test = x.Comparison1(a,b);
            Console.WriteLine($"Попівняння: а і b = {test}");
            test = x.Comparison1(a, c);
            Console.WriteLine($"Попівняння: а і c = {test}\n");
            Console.WriteLine("Перевантаження:");
            
            x = a + b;
            cmd = x.ToString();
            Console.WriteLine($"a + b = {cmd}");
            x = a - b;
            cmd = x.ToString();
            Console.WriteLine($"a - b = {cmd}");
            x = a * b;
            cmd = x.ToString();
            Console.WriteLine($"a * b = {cmd}");
            x = a / b;
            cmd = x.ToString();
            Console.WriteLine($"a / b = {cmd}");
            x = a^2;
            cmd = x.ToString();
            Console.WriteLine($"a^2 = {cmd}");
            a++;
            cmd = a.ToString();
            Console.WriteLine($"a++ = {cmd}");
            a--;
            cmd = a.ToString();
            Console.WriteLine($"a-- = {cmd}");
            ++a;
            cmd = a.ToString();
            Console.WriteLine($"++a = {cmd}");
            --a;
            cmd = a.ToString();
            Console.WriteLine($"--a = {cmd}");


            Console.ReadKey();
        }
    }
}
