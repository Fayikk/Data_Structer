using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structer
{
    internal class start
    {
        static void Main(string[] args)
        {

            string ifade = "\nBTK\t akademi\a programlma \nöğreniyorum";
            Console.WriteLine(ifade);
            //burada kaçış ıfadeleirimiz \n ifadeisidr alt satıra inmemizi sağlıyor. 
            //\t ile bir tab kadar boşluk bırakmamıza yarayacktır.
        }   // \a ifadesi ile bir alert sesi duymamızı sağlayacaktır

        private static void simple_valiables()
        {
            int sayi = 5;
            Console.WriteLine(sayi);  //3
            Console.WriteLine(sayi + 2); //3+2=5
                                         //Console.WriteLine(sayi*sayi); burada yorum satırlarını oluşturmayı öğrendik
                                         //açıklama ifadeleri yazılacaktır. Console.WriteLine(sayi-5);
        }

        private static void DegiskenBasitOrnegi()
        {
            int sayi = 1;
            double pi = 3.14;
            char secim = 'e';
            string isim = "zafer";
            bool dogruMu = false;
        }
    }
}
