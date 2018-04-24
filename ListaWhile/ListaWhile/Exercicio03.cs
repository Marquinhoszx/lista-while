using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Exercicio03
    {
        public Exercicio03()
        {
            Console.Write("DIgite um peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            while ((peso > 0) && (peso < 300))
            {
                Console.Write("Digite um peso: ");
                peso = Convert.ToDouble(Console.ReadLine());
            }










        }
    }
}
