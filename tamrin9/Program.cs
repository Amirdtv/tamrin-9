using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin10
{
    internal class Program
    {
        private static void test ( int[ , ] a)
        {
            int i, j;
            for (i = 0; i <= 49; i++)
            {
                for(j = 1; j <=48; j++)
                {
                    a[i, j] = (a[i, j - 1] + a[i, j] + a[i, j + 1])/3;
                }
            }
            for (i = 0; i <= 49; i++)
            {
                for (j = 0; j <= 49; j++)
                {
                    Console.WriteLine(a[i, j]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[ , ] a = new int[50 , 50];
            test( a );
        }
    }
}
