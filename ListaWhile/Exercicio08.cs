using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Exercicio08
    {
        public Exercicio08()
        {

            int contador = 0;
            char caracter = ' ' ;
            Console.Write("Quantidade de caracteres: ");
            int qntDeCaracter = Convert.ToInt32(Console.ReadLine());
            string texto = "";
            while (contador != qntDeCaracter)
            {
                contador = contador + 1;

                Console.Write("Caracter: ");
                caracter = Convert.ToChar(Console.ReadLine());
                texto = texto + caracter;


            }
            Console.WriteLine("Frase: "+ texto);















        }
    }
}
