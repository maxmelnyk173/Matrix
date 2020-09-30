using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of rows");
            int rows; 
            while (!int.TryParse(Console.ReadLine(), out rows))
            {
                Console.WriteLine("Input Error! Please enter the number");
            }

            Console.WriteLine("Please enter the number of columns");
            int columns;
            while (!int.TryParse(Console.ReadLine(), out columns))
            {
                Console.WriteLine("Input Error! Please enter the number");
            }

            Matrix newMatrix = new Matrix(rows, columns);
            var filledMatrix = newMatrix.FillMatrix();
            for (int i = 0; i < filledMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < filledMatrix.GetLength(1); j++)
                {
                    if (i==j) { Console.ForegroundColor = ConsoleColor.Red; }
                    else { Console.ForegroundColor = ConsoleColor.Gray; }
                    Console.Write(filledMatrix[i, j] + "\t");
                    Console.ResetColor();
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine(newMatrix.SumOfDiagonalElements());
        }
    }
}

