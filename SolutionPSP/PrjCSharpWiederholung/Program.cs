using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCSharpWiederholung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo World!");

            // Instanzieren,Object erstellen
            int zahl = 12;

            int j = zahl;

            j = 20;

            // new forder speicher dynamisch an
            Tier t1 = new Tier();
            t1.AlterInJahren = 27;

            Tier t2 = null;
            t2 = new Tier();
            t1.AlterInJahren = 30;


            t2 = t1;
            t2.AlterInJahren = 5;

            Console.WriteLine(t2.GetAlterInMonaten());

            // Debuggen Breakpoint setzen, links aussen oder F9
            // Debug start mit F5

            TeilnehmerIn < int,string> teil1 = new TeilnehmerIn<int, string>();
            teil1.Art = 0;

            TeilnehmerIn<string, string> teil2 = new TeilnehmerIn<string, string>();
            teil2.Art = "Teilzeit";

            TeilnehmerIn<Arbeitszeitmodel,int> teil3 = new TeilnehmerIn<Arbeitszeitmodel, int>();
            teil3.Art = new Arbeitszeitmodel();
            teil3.Art.MinStunden = 15;
            teil3.Art.MaxStunden = 15;


            TeilnehmerIn<int, Entlohnungsschema<string>> teil5 = new TeilnehmerIn<int, Entlohnungsschema<string>>();
                    
            teil5.Entlohnug = new Entlohnungsschema<string>();
            teil5.Art = 12;
            teil5.Entlohnug.Bezeichnung = "Kollektiv";

            TeilnehmerIn<string, Entlohnungsschema<int>> teil6 = new TeilnehmerIn<string, Entlohnungsschema<int>>();
            teil6.Art ="Gering";
            teil6.Entlohnug = new Entlohnungsschema<int>();
            teil6.Entlohnug.Bezeichnung = 2;

            System.Collections.Generic.Dictionary<int, Tier> meineTiere; // wie map mit key and value in java

            meineTiere = new Dictionary<int, Tier>();
            meineTiere.Add(1, new Tier(){
                AlterInJahren = 12,
                Bezeichnung ="Hase"
                   });
            meineTiere.Add(2, new Tier()
            {
                AlterInJahren = 2,
                Bezeichnung = "Vogel"
            });

            foreach (var tier in meineTiere)
            {
                Console.WriteLine(tier.Key);
                Console.WriteLine(tier.Value.Bezeichnung);
            }

            List<string> lvs = new List<string>();
            lvs.Add("PSP");
            lvs.Add("Databankparogrammierung");
            lvs.Add("JavaScript");
            foreach (string eintrag in lvs)
            {
                Console.WriteLine(eintrag);
            }
        }
    }
}
