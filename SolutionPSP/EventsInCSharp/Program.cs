using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsInCSharp
{
    class Fahrzeug
    {
        public event Action ZuSchnell;
        public double AktuellGeschwindigkeit { get; set; }

        public void GasGeben(double erhoehung)
        {
            AktuellGeschwindigkeit += erhoehung;
            if (AktuellGeschwindigkeit > 70)
            {
                ZuSchnell();
            }
        }



    }
    class Program
    {

        static void Main(string[] args)
        {
            Fahrzeug f1 = new Fahrzeug()
            {
                AktuellGeschwindigkeit = 0
            };
            f1.ZuSchnell += SieFahrenZuSchnell; // += oder -=
            f1.ZuSchnell += RotAlarm; // += oder -=

            f1.GasGeben(10); // 10 Km/h
            f1.GasGeben(90);
            f1.GasGeben(-50);
            f1.GasGeben(30);
        }

        public static void RotAlarm()
        {
            Console.WriteLine("Vorsicht - RotAlarm");
        }
        public static void SieFahrenZuSchnell()
        {
            Console.WriteLine("Vorsicht - bitte bremsen");
        }
    }
}
