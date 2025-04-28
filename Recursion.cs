using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmos
{
    internal class Recursion
    {
        public void countDown (int number)
        { 
            Console.WriteLine (number);
            if(number > 0)
            {
                countDown (number - 1);
            }
            else
            {
                Console.WriteLine("Happy new year!");
            }
        }
    }

    internal class FactorialWithRecursion
    {
        public int calculateFactorial(int number)
        {
            if(number > 1)
            {
                int aux;
                aux = calculateFactorial(number - 1);
                number = number * aux;
            }
            return number;
        }
    }

    internal class TorresHanoi
    {
        public void hanoi(int n, int source, int dest, int aux)
        {
            if (n > 0)
            {
                hanoi(n-1, source, aux, dest);
                Console.WriteLine("Disk from position " + source + " to " + dest);
                hanoi(n - 1, aux, dest, source);
            }
        }
    }

    internal class Mult
    {
        public int mult1(int n, int c)
        {
            if (c < 2)
            {
                c = c + 1;
                int r = mult1 (n + 1, c);
                n = n * r;
            }
            return n;
        }
    }
}
