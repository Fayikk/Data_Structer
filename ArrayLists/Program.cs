using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Tanımlama
            ArrayList array = new ArrayList() { 20,"Fırat University",false};
            
            //Ekleme
            //array.Add(10);//int
            //array.Add("Fayik Veznedaroglu");//string
            //array.Add(true);//Boolean türünden değişkenleri araylist içerisinde tutabiliriz

            //Dolaşma
            foreach (var e in array)
            {
                Console.WriteLine($"{e} ");
            }

            //sayı dizisi oluşçturalım
            int[] sayilar = new int[] { 23, 44, 55 };
            array.AddRange(sayilar);
            foreach (var e in array)
            {
                Console.WriteLine($"{e}");
            }
            Console.WriteLine();
            Console.WriteLine(array[4]);//44 ifadesini ekrana yazdıracaktır.

            //Elemana erişme - atama
            Console.WriteLine("******");
            var x = (int)array[0];//(Kutudan çıkarma yaptığımzı bölüm burasıdır).Array başındaki (int) tanımlaması ile cast işlemi yapmılş olduk.
            //Eğer cast işlemi yapmasaydık  aşağıdaki yazdırma işleminde,arraylist tanımlamasını yapmadığımızdan
            //Herhangi bir tip ataması yapmadık.Dolayısıyla convertable hatası almamız cast işleminden önce gayet normal karşılanmalıdır.                                                                                                  
            Console.WriteLine(x+10);
            //Diziden eleman silme
            array.Remove(20);//20 karakterini bulup bellekten sil anlamına gelmektedir.
            array.RemoveAt(1);//indis numarasına sahip elemanın bellekten silinmesine yarar.
            array.RemoveRange(1, 3);//belirlenen aralıktaki elemanların bellekten silinmesine yarar.
            Console.WriteLine();
            foreach (var e in array)
            {
                Console.WriteLine($"{e} ");
            }


        }
    }
}
