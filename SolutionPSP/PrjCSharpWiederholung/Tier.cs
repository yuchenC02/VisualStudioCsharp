using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCSharpWiederholung
{
    //Abstract Definition / Vorlage-Blueprint
    //Attribute,Memberbariablen,Eigenschaften,Properties
    //.Net Properties get; set;
    class Tier
    {
        // public Membervariablen
        public string Name;
        public double Gewicht;

        //Encapsulation, C#Style beginn mit_
        private int _alterInJahren;
        public int AlterInJahren// .NET Property (readonly or wirteonly)
        {
            get
            {
                return _alterInJahren;
            }
            set
            {
                _alterInJahren = value;
            }
        }
        //private string _Geschlecht;
        //public string Geschlecht { get => _Geschlecht; set => _Geschlecht = value; } //(Bearbeiten-Umgestalten-Feld Kapseln)

        // Automatic .NET Property -- codesnippet prop
        public string Bezeichnung { get; set; }

        //static  instanz ist nicht nötig
        public static int InstanzAnzahl;
        //Konstruktor ---ctor +tab+tab
        public Tier()
        {
            InstanzAnzahl++;
        }

        public int GetAlterInMonaten()
        {
            //lokale Variable
            int ergebinis = AlterInJahren * 12;
            return ergebinis;

        }
        // overlaoding anhand der Übergabeparameter
        public int GetAlterInMonaten(int multiplaktionsfaktor)
        {
            //lokale Variable
            int ergebinis = AlterInJahren * multiplaktionsfaktor;
            return ergebinis;

        }
    }
}
