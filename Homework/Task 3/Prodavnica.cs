using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Task_3
{
    class Prodavnica
    {
        public static void Main(string[] args)
        {
            string nazivProdavnice = "Strz";
            string[] nazivArtikla = { "Mleko", "Jaja", "So", "Hleb", "Voda" };
            double[] kolicina = { 2, 4, 3, 7, 1 };
            string[] jedinica = { "Litar", "Komad", "Kilogram", "Komad", "Litar" };
            bool[] akcija = { true, false, true, true, false };
            double[] pdv = { 0.1, 0.2, 0.2, 0, 0 };
            double[] cena = { 120, 110, 150, 90, 60 };
            double cenaSaPdv = 0;
            double cenaBezPdv = 0;
            double cenaArtikla = 0;
            

            Console.WriteLine("\n\t\t Prodavnica: " + nazivProdavnice + "\n");
            Console.WriteLine("\n\t\t Racun broj: 123ACD");
            Console.WriteLine("\n\tStavke racuna: \n\t---------------------------------------------------------");

            for (int i = 0; i < nazivArtikla.Length; i++)
            {
                cenaArtikla = cena[i] * kolicina[i];
                Console.WriteLine("\t {0}\t {1} \t {2} \t din/{3} \t {4}dinara \t PDV[{5}]", nazivArtikla[i], kolicina[i], cena[i], jedinica[i], cenaArtikla, pdv[i]);
                //Console.WriteLine("\t" + nazivArtikla[i] + "\t  " + kolicina[i] + " x " + cena[i] + " din/+\t" + cenaArtikla + " din\n");

                if (akcija[i])
                {//popust 10%
                    cenaArtikla *= 0.9;
                }
                cenaBezPdv += (cenaArtikla - cenaArtikla * pdv[i]);
                cenaSaPdv += cenaArtikla;
            }
            Console.WriteLine("\t---------------------------------------------------------");
            Console.WriteLine("\tUkupna cena proizvoda bez PDV je {0} dinara", cenaBezPdv);
            Console.WriteLine("\t---------------------------------------------------------");
            Console.WriteLine("\tUkupna cena proizvoda sa PDV(23%) je {0} dinara", cenaSaPdv);
            Console.ReadKey();




        }
    }
}
