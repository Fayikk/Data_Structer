using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizinin boyutunu giriniz");
            int boyut = Convert.ToInt32(Console.ReadLine());
            //Aşağıda tanımalamasını yaptığımız dizinin boyunu buradan kullanıcı belirleyecektir
            int[] sayilar = new int[boyut];
            //Yukarıda int değer tipinden bir sayilar nesnesi oluşturup bellekte oluşturacağı alanı yukarıdaki kullanıcıdan alınacak olan boyut değişkeni belirleyecektir
            var r= new Random();
            //Yukarıda ise var değişken tipi ile bir 'r' nesnesi ürettik ve bellekte bir yer açıp buna'da random dedik.
            
            for (int i = 0; i < sayilar.Length; i++)
            
                sayilar[i] = r.Next(1,10);

            //foreach ifadesi koleksiyonlar arasında dolaşmayı sağlar.
            foreach (int s in sayilar)
            {
                Console.WriteLine($"{s,2} {"=",4} {s*s,5}");
                //sayıların karesini alan programı yukarıda kabatsalak şekilde oluşturmuş olduk.
            }
            

            Console.ReadKey();
        }
    }
}
