using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i<100; i += 5)
            //{
            //    Console.WriteLine(i);
            //}

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //for (int i = a; i < b; i++)
            //{
            //    if (i%3==0)
            //    {
            //        continue;
            //        Console.WriteLine("{0,3}", i);
            //    }

            //}

            int n = 5;
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j <=1; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
        
    }
}
