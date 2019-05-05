using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MatrixMultiplication
    {
        static void Main()
        {
            Console.Write("Enter number to set row:");
            int r = Int16.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Enter number to set column:");
            int c = Int16.Parse(Console.ReadLine());
            int[,] matrix=new int[r,c];
            Console.WriteLine("Enter numbers:");
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
            Console.WriteLine("-------------------------------");
            Console.Write("Enter number to set second matrix row:");
            int r1 = Int16.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Enter number to set column:");
            int c1 = Int16.Parse(Console.ReadLine());
            int[,] matrix2 = new int[r1,c1];
            Console.WriteLine("Enter for 2 matrix numbers:");
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
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Result of the matrix multiplication is:");
            int a,b;
            if(r>=r1&&c>=c1)
            {
            a=r;b=c;
            }
            else
            {
            a=r1;b=c1;
            }
            int[,] mul = new int[a,b];
            for (int i = 0;i<a;i++ )
            {
                for (int j = 0; j < b; j++)
                {
                    mul[i, j] = matrix[i, 0] * matrix2[0, j];
                }
            }
            int[,] mul2 = new int[a,b];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mul2[i, j] = matrix[i, 1] * matrix2[1, j];
                }
            }
            int[,] result=new int[a,b];
            Console.WriteLine("=========================");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                   Console.Write(result[i, j] = mul[i, j] + mul2[i, j]);
                   Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
    }
}
