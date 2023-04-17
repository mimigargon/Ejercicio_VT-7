using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_VT_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[10];
            randomNumber(lista);
        }

        static void randomNumber (int[] lista)
        {
            Random aleatorio = new Random();
            for(int i = 0; i < lista.Length; i++)
            {
                lista[i] = aleatorio.Next(51);
            }
               printRandomNumber(lista);

        }

        static void printRandomNumber(int[] lista)
        {
            for(int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);

            }

        }
    }
}
