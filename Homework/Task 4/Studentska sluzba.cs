using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Task4
{
    class Studentska_sluzba
    {

        public static void Main(string [] args)
        {

            string nastavniciTxt = "1,Petar,Petrović,Docent\n2,Jovan,Jovanović,Docent\n3,Marko,Marković,Asistent\n4,Nikola,Nikolić,Redovni Profesor\n5,Lazar,Lazić,Asistent";
            string predmetiTxt = "1,Matematika\n2,Fizika\n3,Elektrotehnika\n4,Informatika";
            string studentiTxt = "1,E1 01/2016,Jovanović, Zarko,Loznica\n2,E2 02/2015,Prosinečki,Strahinja,Novi Sad\n3,E2 33/2016,Savić,Nebojša,Inđija\n4,SW 36/2013,Sekulić,Ana,Niš\n5,E2 157/2013,Nedeljković,Vuk,Novi Sad\n6,E1 183 / 2013,Klainić,Jovana,Sombor\n7,E2 44 / 2015,Bojana,Panić,Sr.Mitrovica";

            object[,] nastavnici = { }, predmeti = { }, studenti = { };

            UcitajStudente(studentiTxt, ref studenti);
            IspisiStudente(studenti);

            int studentId = 3;
            IspisStudentaPoId(studentId,  studenti);

            

            UcitajNastavnike(nastavniciTxt, ref nastavnici);
            IspisNastavnika(nastavnici);
            int nastavnikId = 3;
            IspisNastPoId(nastavnikId,  nastavnici);


            UcitajPredmete(predmetiTxt, ref predmeti);
            IspisPredmeta(predmeti);
            int predmetId = 3;
            IspisPredmetaId(predmetId, predmeti);
            
            IspisStudenataE2(studenti, "E2");
            IspistStudenataPoUpisu(studenti);
            Console.ReadKey();
        }

        public static void UcitajNastavnike(string nastavniciTxt, ref object [,] nastavnici)
        {
            string[] nast = nastavniciTxt.Split('\n'); //u niz stringova "nast" stavljamo splitovane podatke iz "nastavniciTxt"

            nastavnici = new object[nast.Length, 4]; // objektu nastavnici odredjujemo duzinu niza i elemente u svakom nizu
                                    //1 - imena 0 - identifikatori, , 2 - prezimena, 3 - zvanja

            for(int i = 0; i < nast.Length; i++)
            {
                string[] podaciNastavnika = nast[i].Split(','); 

                nastavnici[i, 0] = Int32.Parse(podaciNastavnika[0]);
                nastavnici[i, 1] = podaciNastavnika[1];
                nastavnici[i, 2] = podaciNastavnika[2];
                nastavnici[i, 3] = podaciNastavnika[3];
                
            }

        }

        public static void IspisNastavnika(object [,] nastavnici)
        {
            Console.WriteLine("Nastavnici su: ");

            for(int i = 0; i < nastavnici.GetLength(0); i++)
            {
                Console.WriteLine("Id [{0}] je profesor {1} {2}, koji ima zvanje: {3}.", nastavnici[i, 0] , nastavnici[i,1], nastavnici[i, 2], nastavnici[i,3]);
            }
        }


        public static void IspisNastPoId(int id, object [,] nastavnici)
        {
            for(int i = 0; i < nastavnici.GetLength(0); i++)
            {
                if (id == (int)nastavnici[i, 0])
                {
                    Console.WriteLine("Nastavnik {0} {1} koji ima zvanje {2}, je nastavnik sa zadatim id: [{3}]", nastavnici[i, 1], nastavnici[i, 2], nastavnici[i, 3], nastavnici[i, 0]);
                }
            }
        }

        public static void UcitajStudente(string studentiTxt, ref object [,] studenti)
        {
            string [] stud = studentiTxt.Split('\n');

            studenti = new object[stud.Length, 5];

            for( int i = 0; i < stud.Length; i++)
            {
                string[] podaciStudenta = stud[i].Split(',');


                studenti[i, 0] = Int32.Parse(podaciStudenta[0]);
                studenti[i, 1] = podaciStudenta[1];
                studenti[i, 2] = podaciStudenta[2];
                studenti[i, 3] = podaciStudenta[3];
                studenti[i, 4] = podaciStudenta[4];


            }
           


           

        }


        public static void IspisiStudente(object [,] studenti)
        {
            Console.WriteLine("Studenti: ");
            for (int i = 0; i < studenti.GetLength(0); i++)
            {

                Console.WriteLine("Id [{0}] Student: {1} {2} je smer i godina : {3}, iz mesta: {4} ", studenti[i, 0], studenti[i, 2], studenti[i, 3], studenti[i, 1], studenti[i, 4]);


            }
        }
       


        public static void IspisStudentaPoId(int id, object [,] studenti)
        {
            for(int i = 0; i < studenti.GetLength(0); i++)
            {
                if(id == (int)studenti[i, 0])
                {
                    Console.WriteLine("Student {0} {1} na smeru i godini {2}, iz mesta {3}, ima id {4}", studenti[i,2], studenti[i, 3], studenti[i,1], studenti[i,4], studenti[i, 0]);
                }
            }
        }

        public static void UcitajPredmete(string predmetiTxt, ref object [,] predmeti)
        {
            string[] pred = predmetiTxt.Split('\n');

            predmeti = new object[pred.Length, 2];

            for(int i = 0; i < pred.Length; i++)
            {
                string[] podaciPredmeta = pred[i].Split(',');

                predmeti[i, 0] = Int32.Parse(podaciPredmeta[0]);
                predmeti[i, 1] = podaciPredmeta[1];
            }
        }

        public static void IspisPredmeta(object [,] predmeti)
        {
            Console.WriteLine("Predmeti su: ");
             for(int i = 0; i < predmeti.GetLength(0); i++)
            {
                Console.WriteLine("Id [{0}] predmet je: {1}.", predmeti[i, 0], predmeti[i, 1]);
            }
        }
        
        public static void IspisPredmetaId(int id, object [,] predmeti)
        {
            for(int i = 0; i < predmeti.GetLength(0); i++)
            {
                if(id == (int)predmeti[i,0])
                {
                    Console.WriteLine("Predmet sa zadatim id je: [{0}] : {1}", predmeti[i, 0], predmeti[i, 1]);
                }
            }
        }

        public static void IspisStudenataE2(object [,] studenti, string smer)
        {
            Console.WriteLine("Studenti sa smera {0} su: ", smer);

            for(int i = 0; i < studenti.GetLength(0); i++)
            {
                 
                if (((string)studenti[i, 1]).ToLower().Contains((string)smer.ToLower()))
                {
                    Console.WriteLine("Id {0},{1} {2} iz {3}.", studenti[i, 0], studenti[i, 2], studenti[i,3], studenti[i,4]);
                }
            }
            
        }

        public static void IspistStudenataPoUpisu(object [,] studenti)
        {
            int ukupno2012=0, ukupno2013 = 0, ukupno2014 = 0, ukupno2015 = 0, ukupno2016 = 0;

            for (int i = 0; i < studenti.GetLength(0); i++)
            {
               // prvi nacin: int godina = Int32.Parse(((string)studenti[i, 1]).Split(new char[] { '/' })[1]);


                //drugi nacin
                string k = (string)studenti[i, 1]; // napravili smo string k koji je (E1 01/2016)

                var splits = k.Split('/');//podelili smo ga po kosoj crti

                var godina = int.Parse(splits[1]); //dobili smo var godinu koju parsiramo u int i to je 2016

                //E1 01/2016

                switch (godina)
                {
                    case 2016:
                        ukupno2016++;
                        break;
                    case 2015:
                        ukupno2015++;
                        break;
                    case 2014:
                        ukupno2014++;
                        break;
                    case 2013:
                        ukupno2013++;
                        break;
                    case 2012:
                        ukupno2012++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Statistika upisa: \n***************************************");
            Console.WriteLine(ukupno2016 > 0 ? "U 2016 je upisalo fakultet " + ukupno2016 + " studenta" : "U 2016 nije bilo upisanih studenata");
            Console.WriteLine(ukupno2015 > 0 ? "U 2015 je upisalo fakultet " + ukupno2015 + " studenta" : "U 2015 nije bilo upisanih studenata");
            Console.WriteLine(ukupno2014 > 0 ? "U 2014 je upisalo fakultet " + ukupno2014 + " studenta" : "U 2014 nije bilo upisanih studenata");
            Console.WriteLine(ukupno2013 > 0 ? "U 2013 je upisalo fakultet " + ukupno2013 + " studenta" : "U 2013 nije bilo upisanih studenata");
            Console.WriteLine(ukupno2012 > 0 ? "U 2012 je upisalo fakultet " + ukupno2012 + " studenta" : "U 2012 nije bilo upisanih studenata");
            Console.WriteLine("***************************************");
        }




    }
  }

