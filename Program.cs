using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {10,2,4,5,0,2,0,7,8,0};
            Console.WriteLine("Исходный массив:");
            foreach (int item in A)
            {
            Console.Write("{0}\t", item);
            }
            Console.WriteLine("\nМассив без нулевых элементов:");
            foreach (int item in A)
            {
                if (item != 0)
                {
                    Console.Write("{0}\t", item);
                }
            }
            Console.ReadKey(); 
        }
    }
}
