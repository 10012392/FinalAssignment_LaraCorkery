//Lara Corkery (10012392)
//Final Assessment (2D Array) Program Three 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main()
        {
            //Random number generator 
            Random rand = new Random();


            //Declaring arrays (matrixA, matrixB)
            int[,] matrixA = new int[3, 3];
            int[,] matrixB = new int[3, 3];

            Console.WriteLine("Matrix A");

            //For loop interate  through 2D Array 
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    matrixA[i, j] = rand.Next(-10, 10);
                    Console.Write(matrixA[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n     +");
            Console.WriteLine("Matrix B");

            //Second for loop  
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    matrixB[i, j] = rand.Next(-10, 10);
                    Console.Write(matrixB[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n     =");
            Console.ReadLine();
            Console.WriteLine("Matrix C");

            //Adds together matrixA and matrixB then displays the output 
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(matrixA[i, j] + matrixB[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Press Enter To Exit");
            Console.ReadLine();
         
        }
    }
}

