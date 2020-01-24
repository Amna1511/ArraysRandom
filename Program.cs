using System;
using System.Collections.Generic;

namespace ArraysRandom
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] array = new int[6];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
              Console.WriteLine(" {0}",array[i] = random.Next(1,40));
              
            }
            Console.ReadKey(); 
            //for (int i = 1; i < array.Length; i++)
            //{
            //    Console.WriteLine(" {0}", array[i]);
            //}
            //Console.ReadLine();
        }
    }
}
