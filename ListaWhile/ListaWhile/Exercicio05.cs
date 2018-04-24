using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Exercicio05
    {
        public Exercicio05()
        {
            int opcao = 0;
            double resultado = 0;
            double numero1 = 0;
            double numero2 = 0;
           
            while ((opcao != 5)||(opcao!=5))
            {
            
            Console.WriteLine("Número1: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Número2: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            

                Console.WriteLine("Escolha uma opção: " + "\n" +
                              "1: Somar" + "\n" +
                              "2: Subtrair" + "\n" +
                              "3: Multiplicar" + "\n" +
                              "4: Dvidir" + "\n" +
                              "5: Sair");
                opcao = Convert.ToInt32(Console.ReadLine());


                if (opcao == 1)
                {
                    resultado = numero1 + numero2;
                }
                else if (opcao == 2)
                {
                    resultado = numero1 - numero2;
                }
                else if (opcao == 3)
                {
                    resultado = numero1 * numero2;
                }
                else if (opcao == 4)
                {
                    resultado = numero1 / numero2;
                }
                Console.WriteLine("Resultado: "+ resultado);

                
            }

            



            



            


















        }
    }
}
