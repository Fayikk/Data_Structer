using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition_Statements
{
    public class Program
    {
        static void Main(string[] args)
        {
            Simple_sample();
        }

        private static void Simple_sample()
        {
            var k = (char)Console.Read();//Normalde Read()fonksiyonu int değerler karşılık gelmektedir
            //ancak biz manule olarak girilen değerin char tipinde olduğunu bilfiriyoruz dolayısıyla artık char tip değer döndürecektir.            
            Console.WriteLine(k);
            Console.ReadKey();
            if (char.IsDigit(k))
            {
                Console.WriteLine("Rakamdır!");
            }
            else if (char.IsLower(k))
            {
                Console.WriteLine("Küçük karakterdir");

            }
            else if (char.IsUpper(k))
            {
                Console.WriteLine("büyük karakterdir");
            }
            else
            {
                Console.WriteLine("tanımlanamayan karakter.");
            }
        }

        private static void Absolute_value()
        {
            //Mutal değerli ifade için bir örnek yazmış olduk.
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine($"|{n}|={n * -1}");//burada bir interpolasyon örneği görmüş olduk
            }
            else
            {
                Console.WriteLine($"|{n}|={n}");
            }
        }

        private static void odd_even()
        {
            //tek -- çift
            Console.WriteLine("bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            //Yukarıda tip dönüşümlerinin nasıl yapılacağını görmüş olduk
            if (sayi % 2 == 0)
            {
                Console.WriteLine("sayi cifttir");
            }
            else
            {
                Console.WriteLine("sayi tektir");
            }
        }
    }
}
