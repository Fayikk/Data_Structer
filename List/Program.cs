using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Program
    {
        static void Main(string[] args)
        {
            //tanımlama
            //new referans tip oluştururken kullanılır.
            //var anahtar sözcüğü ile sayıalrın tipine çalışma zamanında karar verebilirsiniz.
            //List<int> sayilar = new List<int>(); 

            string program = "Python";
            string[] seri = new string[] { "product", "company", "apple","banana" };
            var kelimeler = new List<string>() { "fayik","Veznedaroglu","Fırat Üniversitesi","Yazılım Mühendisligi"};
            //sayilar.Add(10);string ifade tanımlaması yaptığımzı için int türünden değişken tanımlaması yapamayız.
            kelimeler.Add("Software");
            kelimeler.Add(program);

            kelimeler.AddRange(seri);//aşağıdaki foreach döngüsüyle aynı anlama gelmektedir.
            kelimeler.AddRange(new string[] { "grape","moon","stars" });
            //Insert işlemiyle'de ekleme işlemini yapmış oluruz.

            //foreach (var s in seri)
            //{
            //    //kelimeler.Add(s);bu şekilde sonradan aynı tür oluşturulan farklı bir nesneyi diğer nesneyle birleştirme işlemine tabi tutabiliriz.
            //}
            //kelimeler.Remove("grape"); grape karakterini dizi'den silecektir.
            //kelimeler.RemoveAt(1);  Yapılara göre 1.indeksteki yeri silecektir.

            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }

            
            
            
                       
        }
    }
}
