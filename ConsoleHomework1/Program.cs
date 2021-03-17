using System;

namespace ConsoleHomework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int d;
            char c;
            a=Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToChar(Console.ReadLine());
            switch (c) {
                case '+':
                    d= a + b;
                    break;
                case '-':
                    d = a - b;
                    break;
                case '*':
                    d = a * b;
                    break;
                case '/':
                    d = a / b;
                    break;
                default:
                    d = 1999;
                    break;

            
      
            }


            Console.WriteLine(d);
        }
    }
}
