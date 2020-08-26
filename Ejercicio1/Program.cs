using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
1. Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
valor máximo, el valor mínimo y el promedio.
 */
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            numeros = new int[5];
            int aux;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero {0}:", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());

                if(i==0)
                {
                    aux = numeros[i];
                }
            }
        }
    }
}
