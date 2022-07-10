using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A=20, B=10;
            //C# 'ın refactoring özelliğini kullanarak
            //a ve b değişkenlerimizi bütün kodalrda rename yapabiliriiz.

            //aritemtik operatörler
            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A * B);

            Console.WriteLine(A / B);

            Console.WriteLine(A % B);

            //ilişkisel operatörler
            Console.WriteLine(A < B);
            Console.WriteLine(A > B);
            Console.WriteLine(A <= B);
            Console.WriteLine(A >= B);
            Console.WriteLine(A == B);
            Console.WriteLine(A != B);

            Console.WriteLine(!(A > B &&  A<5));
            Console.WriteLine(A < B || B>5);







        }
    }
}
