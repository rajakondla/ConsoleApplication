using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Matrix
    {
        static void Main()
        {
            int[,] matrix = new int[3, 3];
            Console.Write("Enter number to set First matrix row:");
            int r = Int16.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Enter number to set column:");
            int c = Int16.Parse(Console.ReadLine());
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            int[,] matrix2 = new int[3, 3];
            Console.Write("Enter number to set second matrix row:");
            int r1 = Int16.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Enter number to set column:");
            int c1 = Int16.Parse(Console.ReadLine());
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    matrix2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    Console.Write(matrix2[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("---------------------------");
            int[,] add=new int[3,3];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    add[i, j] = matrix[i, j] + matrix2[i, j];
                }
            }
            Console.WriteLine("Result of matrix addition is:");
            if (r > r1 & c > c1)
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        Console.Write(add[i, j]);
                        Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                else
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c1; j++)
                    {
                        Console.Write(add[i, j]);
                        Console.Write(" ");
                    }
                    Console.Write("\n");
                }
            }
            
        }
    }

