using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Task_1
{
    class _1
    {
        public static void Main(string [] args)
        {
            string nazivProdavnice = "GamePlay";
            string[] nazivArtikla = { "GtaV", "Mortal Kombat", "Pes2020", "Fifa Street", "NFS HotPursuit" };
            double[] kolicina = { 2, 4, 3, 7, 1 };
            double[] cena = { 1000, 800, 1100, 900, 1400 };

            double cenaArtikla = 0; 
            double ukupnaCena = 0;

            Console.WriteLine("\n\t\t Prodavnica: " + nazivProdavnice + "\n");
            Console.WriteLine("\n\t\t Racun broj: 123ACD");
            Console.WriteLine("\n\tStaveke racuna: \n\t------------------------------");

            for(int i = 0; i < nazivArtikla.Length; i++)
            {
                cenaArtikla = cena[i] * kolicina[i];
                Console.WriteLine("\t" + nazivArtikla[i] + "\t  " + kolicina[i] + " x " + cena[i] + " din/kom\t" + cenaArtikla + " din\n");
                ukupnaCena += cenaArtikla;

            }

            Console.WriteLine("\tUkupna cena proizvoda bez PDV je {0} dinara", ukupnaCena - ukupnaCena * 0.23);
            Console.WriteLine("\tUkupna cena proizvoda sa PDV(23%) je {0} dinara", ukupnaCena);
            Console.ReadKey();




        }
    }
}
