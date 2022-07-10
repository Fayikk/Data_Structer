using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            do
            {
                //TODO
                i = i + 2;
                Console.WriteLine(i);

            }while (i<=n);
        }
    }
}
