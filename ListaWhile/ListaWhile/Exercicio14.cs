using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Exercicio14
    {
        public Exercicio14()
        {
            int contador = 0;
            Console.Write("Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            while (contador < 10)
            {
                contador = contador + 1;
                int resultado = numero * numero - contador;
                Console.WriteLine(resultado);


            }
















        }
    }
}
