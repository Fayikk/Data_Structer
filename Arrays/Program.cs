using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //tanımlama
            int[] numaralar1;
            numaralar1 = new int[3];
            //başlatma
            //Dinamik bir yapıda dizimizi oluşturalım
            //dizinin kaç karakterli yer kaplayacağını belirtmezsek zaten yapımzı dinamik olarak gelecektir.
           int[] numaralar = new int[] {15,25,35,19,98};//yukarida dizi olarak oluşturduğumuz numaralar ifadesinin kaç karakter tutacağını yazmış olduk.
           //bellkete 3 karakterli yer ayırmış olduk.
            
            numaralar1[0] = 1;
            numaralar1[1] = 2;
            numaralar1[2] = 3;
           //numaralar[3] = 4;-> dizimizi 3 karakter olarak tanımladığım için burayıda derlemeye katarsak hata alırız.
            //Console.WriteLine(numaralar[2]);
            for (int i = 0; i < numaralar.Length; i++)
            {
                Console.WriteLine(numaralar[i]);
            }
        }
    }
}
