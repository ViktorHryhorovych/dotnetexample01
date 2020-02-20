using System;

namespace ConsoleApp6
{
    public class Program
    {
        static public int Example(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " + c.ToString());
            return c;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть друге число");
            int b = int.Parse(Console.ReadLine());
            Example(a, b);
            Console.ReadLine();
        }
    }
}
