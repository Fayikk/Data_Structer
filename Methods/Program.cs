using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metod calisti");
            int buyuk=Karsilastir(1,2);//herhangi bir nesne oluşturmadan bu metoda ulaşmak için metodu tanımlarken 'static' tanımlamamız gerekecektir.
            Console.WriteLine(buyuk);
            Console.WriteLine("Metod calismayi bitirdi.");

           double sonuc = KareAl(4);
            var sonuc2 = KareAl(3);
            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc);
        }
        public static int Karsilastir(int A,int B)
        {
            return A > B ? A : B;//yandaki kod parçacığı ile eğer koşul uygunsa A'yı,koşul uygun değilse B'yi dön diyoruz.
        }
        static double KareAl(double sayi)
        {
            /*double kare = sayi * sayi*/;
            return sayi*sayi;
        }
    }
}
