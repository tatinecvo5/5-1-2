using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace двумерный_массив
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            // int[,] array = new int[n,n];
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                //for (int j = 0; j < n; j++)
                //  {
                //  array[i, j] = i, j;
                //  Console.Write("{0}", array[i, j]);
                array[i] = i;
                Console.Write(array[i]);
            }
            //Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                float a = i;
                float a1 = a / 2;
                //Console.WriteLine("{0:f1}", a1);
                int a2 = Convert.ToInt32(a1);
                //Console.WriteLine(a2);
                Console.WriteLine();
                int a3 = a2 * 2;
                int[] array2 = new int[n];
                if (a == a3)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write("1");
                }
                //Console.Write(array2[i]);
            }
            Console.Read();
        }
    }
}
