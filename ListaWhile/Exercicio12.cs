using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Exercicio12
    {
        public Exercicio12()
        {
            int contador = 0;
            double quantidadeDeProdutos = 5;

            while (quantidadeDeProdutos!=contador)
            {
                // TODO: NIIN
                contador = contador + 1;
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Valor: ");
                double valor = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantidade de produtos: ");
                quantidadeDeProdutos = Convert.ToInt32(Console.ReadLine());

                double resultado = quantidadeDeProdutos * valor;

                double valorComDesconto = resultado - 150;
                Console.WriteLine("Valor total: "+ valorComDesconto);
            }













        }
























    }
}
