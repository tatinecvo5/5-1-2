using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int[] array = new int[n];
            float S = 0;
            for (int i = 0; i < n; i++)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                array[i] = k;
                S += array[i];
            }
            Console.WriteLine("сумма={0}", S);
            float a = S / n;
            Console.Write("среднее={0:f2}", a);
            Console.Read();
        }
    }
}
