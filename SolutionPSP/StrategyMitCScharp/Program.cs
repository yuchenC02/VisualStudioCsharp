using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMitCScharp
{
    public interface IBegruessung
    {

        string GetGreeting(string firstName);

    }

    public class BegruessungEnglish : IBegruessung
    {
        public string GetGreeting(string firstName)
        {
            return "Hello" + firstName;
        }
    }
    public class BegruessungDeutsch : IBegruessung
    {
        public string GetGreeting(string firstName)
        {
            return "Hallo" + firstName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string vorname = "Hans";
            IBegruessung begrE = new BegruessungEnglish();
            IBegruessung begrD = new BegruessungDeutsch();
            SayHello(vorname, begrE);//Interface
            SayHello(vorname, begrD);
            SayHello(vorname, begrE.GetGreeting); //Delegate
            SayHello(vorname, begrD.GetGreeting);
            SayHello(vorname, HalloAufSteierisch);
            // x fließt in die Methode
            // Ciau ist der Resturant--return muss nicht angegeben werden
            SayHello(vorname, x => "Ciao" + x);
            //Lambda Expression
            SayHello(vorname, x =>
            {
                var erg = "Ciao" + x;
                return erg;
            });

            Calc(2, 5, addieren);
            //Calc(2, 5, substrahieren); =>fliess in
            Calc(2, 5, (x, y) => x - y);
            Calc(2, 5, (x, y) => x + y);
            Calc(2, 5, (x, y) => x * y);
            int[] zahlen = { 2, 4, 7, 12, 23, 30, 50, 2 };
            var ergebnisListe = Array.FindAll(zahlen, x => x > 20 || x==5);

            Console.WriteLine("Zahlen größer als 20");
            foreach (var item in ergebnisListe)
            {
                Console.WriteLine(item);
            }
        }

        public static int addieren(int z1, int z2)
        {
            return z1 + z2;
        }
        private static void Calc(int z1, int z2, Func<int, int, int> berechnung)
        {
            Console.WriteLine(berechnung(z1, z2));
        }

        public static string HalloAufSteierisch(string einVorname)
        {
            return "Servus" + einVorname;
        }

        public static void SayHello(string vorname, Func<string, string> mAdr)
        {
            Console.WriteLine(mAdr(vorname));
        }
        public static void SayHello(string vorname, IBegruessung begr)
        {
            Console.WriteLine(begr.GetGreeting(vorname));
        }
    }
}
