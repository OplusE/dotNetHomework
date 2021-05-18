using System;

namespace ConsoleHomework2
{
    class Program
    {

        static void suShu(int x, out int[] a)
        {
            int val = 2;
            a = new int[30];
            int i = 0;
            while (val < x)
            {

                if (x % val == 0)
                {
                    x = x / val;
                }
                else
                {
                    a[i] = x;
                    i++;
                    val++;
                }
            }
        }
            static void max(int[] d)
        {
            int min=1999;
            int max = 0;
            int sum = 0;
            int i = 0;
            int arv;
            for(; d[i]!=0; i++)
            {
                if (d[i] < min)
                    min = d[i];
                if (d[i] > max)
                    max = d[i];
                sum += d[i];
            }
            arv = sum / i;
        }
            static void square(int maxh,int maxw)
        {
            for(int i=0; ; i++)
            {
                if (i > maxw && i > maxh)
                    break;
                
            }

        }
            static void Main(string[] args)
            {
            Console.WriteLine("输入数字：");            
                int b = Convert.ToInt32(Console.ReadLine());
                int[] c;
                c = new int[30];
                suShu(b,out c);
                for(int i=0;i<=30;i++)
                    Console.WriteLine(c[i]);
                    
            }
        }
    }
