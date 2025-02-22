using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmos
{
    //This class multiplies 2 numbers and returns the result
    internal class multiplicar
    {
        public int multiply(int a, int b)
        {
            int c = 0;
            for(int i = 0; i < b; i++)
            {
                c = c + a;
            }
            return c;
        }
    }
    //This class divides two numbers and returns the result
    internal class dividir
    {
        public int divide (int x, int y)
        {
            int z = 0;
            int result = 0;
            int restante = 0;
            for (int i = 0; z < x; i++)
            {
                //
                if((z + y) <= x)
                {
                    z = z + y;
                    result = result + 1;
                }
                else
                {
                    restante = x - z;
                    z = z + y;
                }
                Console.WriteLine("Restante: " + restante);
                
            }
            return result;
        }
    }
    //This class returns a number elevated to a power, e.g. 9 squared
    internal class potencia
    {
        public int power(int a, int b)
        {
            int resultPower = 1;
            for(int i = 0; i < b; i++)
            {
                resultPower = resultPower * a;
            }
            return resultPower;
        }
    }
    //This class returns the factorial of a number
    internal class factorial
    {
        public int factorial2(int a)
        {
            int contador = 0;
            int fact = a;
            for (int i = 0; i < a; i++)
            {
             
                contador = a - (i+1);
                if (contador > 0)
                {
                    fact = fact * contador;
                }
                
            }return fact;
        }
    }
    //This class evaluates if a number given is consider a real number
    //https://en.wikipedia.org/wiki/Real_number
    internal class numeroReal
    {
        public bool realnumber(int a)
        {
            int sum = 0;
            for(int i = 1;i < a; i++)
            {
                if(a%i == 0)
                {
                    sum = sum + i;
                }
            }
            if(sum == a)
            {
                return true;
            }return false;
        }
    }
    //This class evaluates if two numbers given can be considered firneldy numbers 
    //https://en.wikipedia.org/wiki/Friendly_number
    internal class  numerosAmigos
    {
        public bool amigo(int a, int b)
        {
            int sumaA = 0;
            int sumaB = 0;
            for(int i = 1;i < a; i++)
            {
                if(a%i == 0)
                {
                    sumaA = sumaA + i;
                }
            }
            if(sumaA == b)
            {
                for(int o = 1; o < b; o++)
                {
                    if (b%o == 0)
                    {
                        sumaB = sumaB + o;
                    }
                }
                if(sumaB == a)
                {
                    return true;
                }
            }return false;
        }
    }

    ////This class evaluates if a number given can be considered "cool".
    ///A number is "cool" if it can be expressed as the sum of consecutive natural numbers starting from 1.
    ///e.g. 10 is cool because 1+2+3+4=10 1+2+3+4=10 <summary>
    /// e.g. 15 is cool because 1+2+3+4+5=15.
    /// 
    /// but 7 can not be considered cool because
    /// 1+2+3 = 6 
    /// 1+2+3+4 = 10 
    /// </summary>
    internal class numeroCool
    {
        public bool cool(int a)
        {
            int sum = 0;
            for(int i = 1; sum < a; i++)
            {
                sum = sum + i;
            }
            if(sum == a)
            {
                return true;
            }return false;
        }
    }
}
