using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Exercicio04
    {
        public Exercicio04()
        {
            int contador = 0;
            
            
            Console.WriteLine("Digite quantos carros você deseja cadastrar: ");
            int carrosCadastrados = Convert.ToInt32(Console.ReadLine());

            while (contador != carrosCadastrados)
            {

                //somaValor = contador + somaValor;
                contador = contador + 1;
                Console.Write("Modelo do carro: ");
                string modeloCarro = Console.ReadLine();

                Console.Write("Valor do Carro:R$ ");
                double valorDoCarro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ano do Carro: ");
                double anoCarro = Convert.ToDouble(Console.ReadLine());

                Console.Clear();

            }

            Console.Clear();

            //double mediaAno = AnoCarro / contador;
            //double mediaValorCarro = somaValor / contador;

            //Console.WriteLine("Média dos anos dos carros: " + mediaAno);
            //Console.WriteLine("Média do valor do carro: " + mediaValorCarro);



















        }

    }
}
