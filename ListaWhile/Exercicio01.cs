using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaWhile
{
    class Exercicio01
    {
        public Exercicio01()
        {
            Console.WriteLine("Digite um nome,caso queira sair escreva fim ");
            string nome = Console.ReadLine();


            while (nome != "fim")
            {

                Console.WriteLine("Digite um nome,caso queira sair escreva sair ");
                nome = Console.ReadLine();
            }
           
                














        }
    }
}
