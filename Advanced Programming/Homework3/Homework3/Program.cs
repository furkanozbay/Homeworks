using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();

            while (true)
            {
                Console.Write("Enter the dimension of matrix(Bigger than 1, Lower than 10): ");
                try
                {
                    int dimension = int.Parse(Console.ReadLine());

                    if (dimension < 1 || dimension > 10)
                    {
                        Console.WriteLine();

                        continue;
                    }
                    else
                    {
                        int[,] numbers = new int[dimension, dimension];

                        for (int i = 0; i < dimension; i++)
                        {
                            for (int j = 0; j < dimension; j++)
                            {
                                numbers[i, j] = random.Next(1, 9);
                            }
                        }
                        Matrix matrix = new Matrix();
                        matrix.numbers = numbers;
                        Console.WriteLine(determinant(matrix));
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Dimension must be bigger than 1, lower than 10.\n");
                }
            }
        }
        public static int determinant(Matrix matrix)
        {
            int sum = 0;

            //To display the initial matrix
            matrix.writeNumbers();
            Console.WriteLine();
            //To display the initial matrix

            if (matrix.getSize() < 1)
            {
                return 0;
            }
            else if (matrix.getSize() == 1)
            {
                return matrix.getSize();
            }
            else if (matrix.getSize() == 2)
            {
                return matrix.numbers[0, 0] * matrix.numbers[1, 1] - matrix.numbers[0, 1] * matrix.numbers[1, 0];
            }
            int sign;
            for (int i = 0; i < matrix.getSize(); i++)
            {
                sign = (i % 2 == 0) ? 1 : -1;
                sum += sign * matrix.numbers[0, i] * determinant(Matrix.createSubMatrix(matrix, 0, i));
            }


            return sum;
        }

    }
}
