using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Exercicio11
    {
        public Exercicio11()
        {
            int quantidadeDeProdutos = 0;
            
            double valor = 0;
            string nome = "";
            

            Console.WriteLine("Caso queira continuar,Digite Continuar/Caso queira sair,digite Sair: ");
            string sair1 = Console.ReadLine();

            while (sair1 != "sair")
            {
                
                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Valor:R$ ");
                valor = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantidade de produtos: ");
                quantidadeDeProdutos = Convert.ToInt32(Console.ReadLine());

                double valorTotal = valor * quantidadeDeProdutos;
                double valorTotal5 = (valorTotal * 5) / 100;
                double valorComDesconto = valorTotal - valorTotal5;

                Console.WriteLine("Valor TOTAL:R$ :"+ valorComDesconto);

                Console.WriteLine("Caso queira continuar,Digite Continuar/Caso queira sair,digite Sair: ");
                sair1 = Console.ReadLine();

            }

















        }
    }
}
