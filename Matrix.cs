using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmos
{
    /*internal class Matrix
    {
        public void matrices()
        {
            int[,] numbers = new int[9,3];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int result = 1;
                    for(int x = 0; x < j+1; x++)
                    {
                        result = result * (i+1);
                    }
                    numbers[i,j] = result;
                    Console.Write(numbers[i,j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }*/

    internal class JaggedArray
    {
        public void jagged()
        {
            //aqui pido el numero de filas 
            Console.WriteLine("Set the number of rows: ");
            string input = Console.ReadLine();
            int rows = int.Parse(input);

            //aqui creo la matriz irregular estableciendo de cuantos espacios es el arreglo principal
            int[][] matriz = new int[rows][];
       
            //aqui voy a preguntar cuantas columnas o espacios debe tener cada uno de los arreglos que cree antes
            for(int i = 0; i < matriz.Length; i++)
            {
                Console.WriteLine("Set the number of columns/spaces for row: " + (i+1));
                string inputB = Console.ReadLine();
                int columns = int.Parse(inputB);
                matriz[i] = new int[columns];
            }

            //for(int i = 0;i < matriz.Length; i++)
            //{
              //  for(int j = 0; j < matriz[i].Length; j++)
                //{
                  //  Console.Write(matriz[i][j] + " ");
                //}
                //Console.WriteLine();
            //}

            for (int i = 0; i < matriz.Length; i++)
            {
                int result = 1;
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    result = result * (i+1);
                    matriz[i][j] = result;
                    Console.Write(matriz[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }


    /*
    public class MatrixA
    {
        public int[,] MatrizA { get; private set; }
        public MatrixA()
        {
            MatrizA = new int[,]
            {
                { 3, 1, -2},
                { 0, 4, 2 },
                { 7, 5, 1 }
            };
            Console.WriteLine("Matriz A");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    Console.WriteLine(MatrizA[i,j]);
                }
            }
            Console.WriteLine("Elemento en 1,2: " + MatrizA[1,2]);
            Console.WriteLine("Elemenot en 2,1: " + MatrizA[2, 1]);
        
        }
    }

    public class MatrixB
    {
        public int[,] MatrizB { get; private set; }
        public MatrixB()
        {
            MatrizB = new int[,]
            {
                { -1, 0, 8},
                { 3, 6, 9 },
                { 0, 0, 3 }
            };
            
            Console.WriteLine("Matriz B");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(MatrizB[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Elemento en 1,2: " + MatrizB[1, 2]);
            Console.WriteLine("Elemenot en 2,2: " + MatrizB[2, 2]);
            
        }
    }

    public class MatrixC
    {
        public void matricesC()
        {
            MatrixA matrixA = new MatrixA();
            MatrixB matrixB = new MatrixB();

            int[,] matrizA = matrixA.MatrizA;
            int[,] matrizB = matrixB.MatrizB;
            int[,] matrizC = new int[3, 3];
            
            for (int i = 0;i < 3; i++)
            {
                for(int s= 0; s < 3; s++)
                {
                    int resMult = 0;
                    int sumMult = 0;

                    for (int j=0; j < 3; j++)
                    {
                        resMult = matrizA[i,j] * matrizB[j,s];
                        sumMult = sumMult + resMult;
                        matrizC[i,s] = sumMult;
                    }
                }
            }
            Console.WriteLine("Matriz C");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrizC[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    } */

}
