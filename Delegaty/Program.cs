using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    class Program
    {

        delegate void NaszDelegat();

        static void Dodaj() { Console.WriteLine("Dodaj"); }
        static void Odejmij() { Console.WriteLine("Odejmij"); }

        /* static void Dodaj() { Console.WriteLine("dodaj"); }
         static void Usun() { Console.WriteLine("usun"); }
         static void Wypisz(string wypisz) { Console.WriteLine(wypisz); }
         delegate void NaszDelegat();
         delegate void DelegatZStringiem(string M);
         delegate void DelegatZInnejKlasy(string tekst);*/
        static void Main(string[] args)
        {
            /*string tekst = Console.ReadLine();
            NaszDelegat nowyDelegat = new NaszDelegat(Dodaj);
            nowyDelegat();
            nowyDelegat += Usun;
            nowyDelegat += Usun;
            nowyDelegat();


            JakiesMetody jakies = new JakiesMetody();
            DelegatZInnejKlasy delegat = jakies.Metoda1;//jak się odwołać do delegatu z innej klasy

            DelegatZStringiem delegatZStringiem = delegate (string M)
            {
                Console.WriteLine(M);
            };//delegaty anonimowe-tworzymy metodę bezpośrednio przywiązaną do delegatu, bez nazwy
            delegatZStringiem += Wypisz;
            Func<string, string> uzycieGotowychDelegatow = (string a) => { return a; };
            Console.WriteLine(uzycieGotowychDelegatow(tekst)) ;
            Action<string> delegatAction = Wypisz;*/

            NaszDelegat delegat = Dodaj;
            delegat += Odejmij;
            delegat -= Dodaj;
            delegat();

            Func<int, int, int> gotowyDelegat = (int a, int b) => { return a; };
            gotowyDelegat = (int a, int b) => { Console.WriteLine("cac"); return a + a; };
            //gotowyDelegat = a => a + a;
            Console.WriteLine(gotowyDelegat(5, 1));
            Action delegat1 = Dodaj;
        }
    }
}

