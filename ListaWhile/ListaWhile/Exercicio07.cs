using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class Exercicio07
    {
        public Exercicio07()
        {
            int contador = 0;
            int numeroDeJogadores = 22;
            double peso = 0;
            int idade = 0;
            double altura = 0;
            string nome = "";
            string sexo = "";
            int golsMarcados = 0;
            int cartoesAmarelos = 0;
            int cartoesVermelhos = 0;

            while (contador < numeroDeJogadores)
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Altura: ");
                altura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Sexo: ");
                sexo = Console.ReadLine();

                Console.Write("quantidade de gols marcados: ");
                golsMarcados = Convert.ToInt32(Console.ReadLine());

                Console.Write("Quantidade de cartões amarelos: ");
                cartoesAmarelos = Convert.ToInt32(Console.ReadLine());

                Console.Write("Quantidade de cartões vermelhos: ");
                cartoesVermelhos = Convert.ToInt32(Console.ReadLine());

                numeroDeJogadores = numeroDeJogadores - 1;


            }














        }
    }
}
