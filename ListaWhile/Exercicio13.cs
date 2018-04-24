using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Exercicio13
    {
        public Exercicio13()
        {
            int contador = 0;
            Console.WriteLine("Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            while (contador < 1000)
            {
                contador = contador + 1;
                int vezes = numero * contador;
                Console.WriteLine(numero + " X " + contador+ " = "+ vezes);



            }








        }
    }
}
