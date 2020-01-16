using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCSharpWiederholung
{
    class TeilnehmerIn<T,V>
    {
        //Teilzeit,Vollzeit,Geringfügig
        // public string Art { get; set; }


        // T ist ein"formaler Datentype"
        //T wird später beim Definiern des Objektes
        //"Konkretisiert"
        //Z.B
        // TeilnehmerIn<string> t1=new TeilnehmerIn<string>();
        // TeilnehmerIn<int> t2 = new TeilnehmerIn<int>();
        // TeilnehmerIn<ArtEnum>

        public T Art { get; set; }
        public V Entlohnug { get; set; }
    }
}
