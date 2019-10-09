using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_11
{
    class Program
    {
        static void Main()
        {
            int scelta;

            Atleti atleta = new Atleti();

            do
            {
                scelta = menu(atleta);

                switch (scelta)
                {
                    case 1:
                        atleta.Nome(); 
                        Console.ReadLine();
                        break;

                    case 2:
                        atleta.Tempi();
                        break;
                }

            } while (scelta != 0);
        }

        static int menu(Atleti at1)
        {
            int sc;

            Console.Clear();
            Console.WriteLine("1. Inserimento nomi"/*,at1.nome[3]*/);
            Console.WriteLine("2. Gara");
            Console.WriteLine("0. Fine");
            Console.WriteLine("?:");
            sc = int.Parse(Console.ReadLine());
            return sc;
        }
    }
}
