using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmos
{
    
    internal class arrays
    {
        public void nombre()
        {
            string name = "Valeria Jimenez";
            char [] nameInArray = name.ToCharArray();

            foreach (char c in nameInArray)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine(nameInArray.Length);
        }
    }

    //This class evaluates if a string is a palyndrome
    internal class palindromo
    {
        public bool palin(string name)
        {
            char[] word = name.ToCharArray();

            int size = word.Length - 1;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == word[size])
                {
                    size = size - 1;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
    //This class gets the minimum value, maximum value and the average of an array.
    internal class calcularMinMaxAVG
    {
        public void minMaxAVG(double[] arr)
        {
            double numMayor = arr[0];
            double numMin = arr[0];
            double AVG = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(numMayor < arr[i])
                {
                    numMayor = arr[i];
                }
                if (numMin > arr[i]) 
                {
                    numMin = arr[i];
                }
                AVG = Queryable.Average(arr.AsQueryable());
            }

            Console.WriteLine("El numero mayor del arreglo es: " + numMayor + " el numero menor es: " +  numMin + " y el promedio es: " + AVG);
        }
    }
    //This class implements Buble sorting Algorithm
    internal class Burbuja
    {
        public void algBurbuja(int[] arr)
        {
            bool intercambio;
            int aux = 0;
            for (int o = arr.Length; o > 0; o--)
            {
                intercambio = false;
                for (int i = 0; i < o; i++)
                {
                    if (i < (o - 1))
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            aux = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = aux;
                            intercambio = true;
                        }
                    }

                }
                if (intercambio == false)
                {
                    break;
                }
                Console.WriteLine("Nuevo array: ");
                for (int i = 0; i < arr.Length; i++)
                {

                    Console.WriteLine(arr[i]);
                }
            }
            Console.WriteLine("Array final: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    //This class implements Selection sorting Algrithm
    internal class Seleccion
    {
        public void algSeleccion(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int elemento = i;
                for (int x = i+1; x < arr.Length; x++)
                {
                    if (arr[elemento] > arr[x])
                    {
                        elemento = x;
                    }
                }
                int temporal = 0;
                temporal = arr[i];
                arr[i] = arr[elemento];
                arr[elemento] = temporal;
            }
            Console.WriteLine("Algoritmo de ordenamiento - Seleccion: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
