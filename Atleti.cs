using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_11
{
    class Atleti
    {
        public string[] nome = new string[5];
        public int[] tempi = new int[5];
        Random random = new Random();
        public int kk;
        public int fine = 1;

        public void Nome()
        {
            for (int cnt = 0; cnt < 5; cnt++)
            {
                Console.WriteLine("Inserire nome {0} atleta: ", cnt + 1);
                nome[cnt] = Console.ReadLine();
            }
        }

        public void Tempi()
        {
            int cnt = 0;
            for (cnt = 0; cnt < 5; cnt++)
            {

                tempi[cnt] = (int)random.Next(2000) + 60000;
            }


            

            Console.Clear();
            for (int ii = 0; ii < 5; ii++)
            {
                Console.WriteLine("{0} Atleta {2}: {1}", ii + 1, tempi[ii], nome[ii]);
                for (kk = 0; kk < fine; kk++)
                {
                    Console.WriteLine("{1}: {0}", tempi[kk], nome[kk]);
                }
                fine++;
                Console.ReadLine();
                ordinamento();
            }      
        }

        private void ordinamento()
        {
            bool scambio;
            int appoggio;
            string appoggio2;

            do
            {
                scambio = false;

                for (kk = 0; kk < fine - 1; kk++)
                {
                    if (tempi[kk] > tempi[kk + 1])
                    {
                        appoggio = tempi[kk];
                        tempi[kk] = tempi[kk + 1];
                        tempi[kk + 1] = appoggio;


                        appoggio2 = nome[kk];
                        nome[kk] = nome[kk + 1];
                        nome[kk + 1] = appoggio2;
                        scambio = true;
                    }
                }
            } while (scambio == true);
        }
    }
}
