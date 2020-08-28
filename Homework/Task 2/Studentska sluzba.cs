using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Task_2
{
    class Studentska_sluzba
    {
         static void Main(string [] args)
        {
            string nastavniciTxt = "1,Petar,Petrović,Docent\n2,Jovan,Jovanović,Docent\n3,Marko,Marković,Asistent\n4,Nikola,Nikolić,Redovni Profesor\n5,Lazar,Lazić,Asistent";
 
            string predmetiTxt = "1,Matematika\n2,Fizika\n3,Elektrotehnika\n4,Informatika";

            int[] nastavnikIds, predmetIds;
            string[] nastavnikImena, nastavnikPrezimena, nastavnikZvanja, predmetNazivi;

            UcitajNastavnike(nastavniciTxt, out nastavnikIds, out nastavnikImena, out nastavnikPrezimena, out nastavnikZvanja);
            IspisNastavnike(nastavnikIds, nastavnikImena, nastavnikPrezimena, nastavnikZvanja);
            int nastavnikId = 2;
            IspisNastavnikaPoId(nastavnikId, nastavnikIds, nastavnikImena, nastavnikPrezimena, nastavnikZvanja);

            int predmetId = 3;
            UcitajPredmete(predmetiTxt, out predmetIds, out predmetNazivi);
            IspisPredmeta(predmetIds, predmetNazivi);
            IspisPredmetaPoId(predmetId, predmetIds, predmetNazivi);

            Console.ReadKey();

        }

        private static void UcitajNastavnike(string nastavniciTxt, out int[] nastavnikIds, out string[] nastavnikImena, out string [] nastavnikPrezimena, out string [] nastavnikZvanja)
        {
            string[] nastavnici = nastavniciTxt.Split('\n');

            nastavnikIds = new int[nastavnici.Length];
            nastavnikImena = new string[nastavnici.Length];
            nastavnikPrezimena = new string[nastavnici.Length];
            nastavnikZvanja = new string[nastavnici.Length];

            for(int i = 0; i < nastavnici.Length; i++)
            {
                string[] podaciNastavnika = nastavnici[i].Split(',');

                nastavnikIds[i] = Int32.Parse(podaciNastavnika[0]);
                nastavnikImena[i] = podaciNastavnika[1];
                nastavnikPrezimena[i] = podaciNastavnika[2];
                nastavnikZvanja [i] = podaciNastavnika[3];


            }




        }

        private static void IspisNastavnike(int[] nastavnikIds, string[] nastavnikImena, string[] nastavnikPrezimena, string[] nastavnikZvanja)
        {
            Console.WriteLine("Nastavnici: ");
            for(int i=0; i<nastavnikIds.Length; i++)
            {

                Console.WriteLine("Id [{0}] Nastavnik {1} {2} je u zvanju {3}", nastavnikIds[i], nastavnikImena[i], nastavnikPrezimena[i], nastavnikZvanja[i]);

                
            }
        }

        private static void IspisNastavnikaPoId(int nastavnikId, int[] nastavnikIds, string[] nastavnikImena, string[] nastavnikPrezimena, string[] nastavnikZvanja)
        {
            for(int i = 0; i < nastavnikIds.Length; i++)
            {
                if (nastavnikId == nastavnikIds[i])

                    Console.WriteLine("Nastavnik sa id oznakom {0} je {1} {2} i njegovo zvanje je {3}.", nastavnikIds[i], nastavnikImena[i], nastavnikPrezimena[i], nastavnikZvanja[i]);
            }
        }

        private static void UcitajPredmete(string predmetiTxt, out int[] predmetIds, out string[] predmetNazivi)
        {
            string[] predmeti = predmetiTxt.Split('\n');

            predmetIds = new int[predmeti.Length];
            predmetNazivi = new string[predmeti.Length];

            for (int i = 0; i < predmeti.Length; i++)
            {
                string[] podaciPredmeta = predmeti[i].Split(',');

                predmetIds[i] = Int32.Parse(podaciPredmeta[0]);
                predmetNazivi[i] = podaciPredmeta[1];

            }
        }

        private static void IspisPredmeta(int[] predmetIds, string[] predmetNazivi)
        {
            Console.WriteLine("Predmeti su: ");
            for(int i = 0; i < predmetIds.Length; i++)
            {
                Console.WriteLine("Id [{0}] je predmet: {1}", predmetIds[i], predmetNazivi[i]);
            }
        }

        private static void IspisPredmetaPoId(int predmetId, int[] predmetIds, string [] predmetNazivi )
        {
            for(int i = 0; i < predmetIds.Length; i++)
            {
                if (predmetId == predmetIds[i])
                {
                    Console.WriteLine("Predmet sa id [{0}] je: {1}.", predmetIds[i], predmetNazivi[i]);
                }

               
            }
        }


    }
}
