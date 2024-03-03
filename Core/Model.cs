using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Matrix
    {
        private int[,] data;
        private int rows;
        private int cols;

      
        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            data = new int[rows, cols];
        }

        
        public Matrix(int[,] data)
        {
            this.rows = data.GetLength(0);
            this.cols = data.GetLength(1);
            this.data = data;
        }

        
        public void InputMatrix()
        {
            Console.WriteLine("Введіть елементи матриці:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Елемент [{i + 1},{j + 1}]: ");
                    data[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        
        public void DisplayMatrix()
        {
            Console.WriteLine("Матриця:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(data[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

       
        public int MaxElement()
        {
            int max = data[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (data[i, j] > max)
                    {
                        max = data[i, j];
                    }
                }
            }
            return max;
        }

     
        public int MinElement()
        {
            int min = data[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (data[i, j] < min)
                    {
                        min = data[i, j];
                    }
                }
            }
            return min;
        }
    }
}