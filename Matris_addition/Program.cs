using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris_addition
{
    public class Program
    {
        static void Main(string[] args)
        {

            //matristeki elemanların toplamını nasıl buluruz?
            int[,] matris = new int[3, 3] { 
                {1,2,3 },
                {4,5,6 },
                {7,8,9 } };
            int sayac = 0;
            for(int i = 0; i < matris.GetLength(0); i++)
            {
                for(int j = 0; j < matris.GetLength(1); j++)
                {
                    sayac=sayac+matris[i, j];
                    

                }
                
            }
            Console.WriteLine(sayac);

        }
    }
}
