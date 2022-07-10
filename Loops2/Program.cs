using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            while (sayac<=10)
            {
                Console.WriteLine(sayac);
                sayac = sayac + 1;
                //sayac++;
                //sayac+=1;
            }
        }
    }
}
