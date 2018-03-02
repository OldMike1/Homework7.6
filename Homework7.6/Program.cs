using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of lines");
            int lines = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of columns");
            int columns = int.Parse(Console.ReadLine());
            int[,] array = new int[lines,columns];


            int sum = 0;
            for (int i = 0; i < columns; i++)
                sum = sum + i;


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = sum;
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
