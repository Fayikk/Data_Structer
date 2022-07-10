using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    public class Program
    {
        enum Islemler//bir değişken tipi olarak kullanılabilri
        {
            Toplama,
            Cikarma,
            Carpma,
            Bolme,
        }
        static void Main(string[] args)
        {
            //Switch_Case struct
            //İŞlemleirimizi enum yapısı ile birlikte gerçekleştireceğiz
            int sayi1=400,sayi2=10;  
            //c# '0' tabanlı indeksleme yapar.
            Islemler secim = (Islemler)(new Random().Next(1,4));//Enum yapısındaki değer tipleri gibi düşünüp uyguluyorum
            switch (secim)
            {
                case Islemler.Toplama:
                    Console.WriteLine($"{sayi1}+{sayi2}={sayi1 + sayi2}");
                    break;
                case Islemler.Cikarma:
                    Console.WriteLine($"{sayi1}-{sayi2}={sayi1 - sayi2}");

                    break;
                case Islemler.Carpma:
                    Console.WriteLine($"{sayi1}*{sayi2}={sayi1 * sayi2}");

                    break;
                case Islemler.Bolme:
                    Console.WriteLine($"{sayi1}/{sayi2}={sayi1 / sayi2}");

                    break;
                default:
                    Console.WriteLine("gecersiz islem \a");
                    break;
            }

        }
    }
}
