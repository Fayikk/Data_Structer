using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Arrays2
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[,] matris = new double[,] { 
                { 1, 2, 3 }, 
                { 2, 3, 4 },
                { 3 ,4 ,5} };
            for(int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    //if (i == j)
                    //{
                    //    matris[i, j] = -1;
                    //}
                    //if (matris[i,j]%2==0)
                    // {
                    //     matris[i,j] = 0;
                    //    //matrislerin elemanları içerisinde 2 ye  tam bölünen sayıları 0'a eşitledik
                    // }
                    Console.WriteLine($"{matris[i, j],5}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
