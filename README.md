# Homework-FTN-Informatika
Homework package from the course .Net development FTN Informatika
1.Zadatak 1
Napraviti Visual Studio projekat koji sadrži C# program za evidenciju kupljenih artikala I omogućuje
prikaz fiskalnog računa. Račun je potrebno da sadrži:
 naziv prodavnice
 stavke računa
 ukupna cena bez pdv-a
 ukupna cena sa pdv-om (23%)
Stavka računa je definisana nazivom artikla, količinom I cenom po komadu. Ukupna cena se računa a
ostale vrednosti skladište u nizovima.
Naziv prodavnice se prosleđuje putem argumenata komandne linije. Ostale podatke inicijalizovati
testnim vrednostima.
Zadatak 2
Napisati C# program koji omogućuje prikaz određenih entiteta Studentse Službe. Model je dat u
posebnom fajlu studentska_sluzba_dijagram.pdf (o detaljnom tumačenju slike više naredni čas).
Za entitete potrebno je definisati nizove čije će se vrednosti popuniti parsiranjem teksta. Potrebno je
za svaki tip entiteta napraviti funkcije:
 Učitaj podatke
 Ispiši sve podatke
 Ispiši podatak u donosu na identifikator (predmet_id, nastavnik_id,...)
Entiteti nastavnika su opisani tekstom:
"1,Petar,Petrović,Docent\n2,Jovan,Jovanović,Docent\n3,Marko,Marković,Asistent\n4,Nikola,Nikolić,
Redovni Profesor\n5,Lazar,Lazić,Asistent"
Entiteti predmeta su opisani tekstom:
"1,Matematika\n2,Fizika\n3,Elektrotehnika\n4,Informatika"
Nikola Nikolić Modul 1 Termin02 FTN Informatika
2
Zadatak 3
Proširiti zadatak 1 tako da postoji i informacija o tome u čemu je izražena količina (kilogramima,
litrima, komadima). Određeni artikli mogu biti na akciji od 10%. Takođe, određeni proizvodi imaju
10% ili 20% pdv-a, dok postoje i oni proizvodi koji su oslobođeni od pdv-a.
Prilikom obračuna ukupne cene (bez pdv-a i sa pdv-om) voditi računa o akcijama i različitim stopama
pdv-a.
Zadatak 4
Proširiti zadatak 2, tako da se omogući rad sa studentima (učitaj, ispisi sve i ispisi u odnosu na
identifikator). Podaci studenata su opisani tekstom:
"1,E1 01/2016,Jovanović, Zarko,Loznica\n2,E2 02/2015,Prosinečki,Strahinja,Novi Sad\n3,E2
33/2016,Savić,Nebojša,Inđija\n4,SW 36/2013,Sekulić,Ana,Niš\n5,E2 157/2013,Nedeljković,Vuk,Novi
Sad\n6,E1 183/2013,Klainić,Jovana,Sombor\n7,E2 44/2015,Bojana,Panić,Sr. Mitrovica"
Zadatak 5
Proširiti zadatak 4, tako da se kreira funkcija koja omogućuje ispis svih studenta koji dolaze sa smera
E2 (Računarstvo i Automatika)
Zadatak 6
Proširiti zadatak 5, tako da se kreira funkcija koja omogućuje ispis statistike broja upisanih studenata
po godinama upisa.
Ispis bi trebao da bude nalik:
*********************************************************************************
U 2016 je upisalo fakultet 2 studenta
U 2015 je upisalo fakultet 2 studenta
U 2014 nije bilo upisanih studenta
U 2013 je upisalo fakultet 3 studenta
*********************************************************************************
