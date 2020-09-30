using System;

namespace Matrix
{
    public class Matrix
    {
        public int [,] elements { get; }

        public int Rows { get; set; }

        public int Columns { get; set; }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            elements = new int[rows, columns];
        }

        public int[,] FillMatrix ()
        {
            Random random = new Random();
            for (int i = 0; i < elements.GetLength(0); i++)
            {
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    elements[i, j] = random.Next(100);
                }
            }
            return elements;
        }

        public int SumOfDiagonalElements()
        {
            int sum = 0;
            for (int i = 0; i < elements.GetLength(0); i++)
            {
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    if (i == j) sum += elements[i, j];
                }
            }
            return sum;
        }
    }
}
