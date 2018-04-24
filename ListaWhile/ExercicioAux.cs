using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaWhile
{
    class ExercicioAux
    {
        public ExercicioAux()
        {



            int contador = 0;
            while (contador!=11)
            {
                contador = contador + 1;
                string texto1 = "Lorem Ipsum";
                string texto2 = texto1.Substring(0, contador);

                Console.WriteLine(texto2);
            }















        }
    }
}
