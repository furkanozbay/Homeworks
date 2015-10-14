using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Matrix
    {
        public int[,] numbers;

        public Matrix()
        {
          
        }
        public Matrix(int row, int column) {
            this.numbers = new int[row, column];
        }
        public int getSize()
        {
            return this.numbers.GetLength(0);
        }
        public void writeNumbers()
        {
            for (int i = 0; i < this.getSize(); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < this.getSize(); j++)
                {
                    Console.Write(this.numbers[i, j] + " ");
                }
            }
        }
        public static Matrix createSubMatrix(Matrix matrix, int row, int column)
        {
            Matrix mat = new Matrix(matrix.getSize() - 1, matrix.getSize() - 1);
            int r = -1;
            for (int i = 0; i < matrix.getSize(); i++)
            {
                if (i == row)
                    continue;
                r++;
                int c = -1;
                for (int j = 0; j < matrix.getSize(); j++)
                {
                    if (j == column)
                        continue;
                    mat.numbers[r, ++c] = matrix.numbers[i, j];
                }
            }
            return mat;
            

        }
    }
}
