using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Arrays3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Array();
            //bolge ve şehirleri tutan matrisler çok boyutlı matrisler omak zorundadır

            string[,] regions = new string[5, 3] {
            {"İstanbul","Ankara","İzmir" },
            {"Ankara","Konya","Kırıkkale" },
            { "Antalya","Adana","Mersin"},
            { "Rize","Trabzon","Mersin"},
            { "İzmir","Muğla","Manisa"},
            
            };
            //Çok boyutlu dizilere örnek olarak regions dizisi verilebilir.





            //for(int i = 0; i < regions.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j < regions.GetUpperBound(1); j++)
            //    {
            //        Console.WriteLine(regions[i,j]);
            //    }
            //    Console.WriteLine("***");
            //}


        }

        private static void Array()
        {
            string[] students = new string[] { "Engin", "Fayik", "Mustafa" };
            string[] students2 = { "Engin", "Salih", "Derin" };
            //students2[3] = "Ahmet"; dizinin karakter sayısını aşacaktır.

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
        }
    }
}
