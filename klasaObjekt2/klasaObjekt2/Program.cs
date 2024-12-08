using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaObjekt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        class Zrakoplov
        {
            private string Naziv;
            private double SnagaMotora;
            private int DosegLeta;

            public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
            {
                Naziv = naziv;
                SnagaMotora = snagaMotora;
                DosegLeta = dosegLeta;
            }

            public override string ToString() => $"{Naziv}, {SnagaMotora} kW, {DosegLeta} km";
        }

        var x380 = new Zrakoplov("Airbus", 2000, 6000);
        var C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
        var PC21 = new Zrakoplov("Pilatus", 1200, 1333);

        Console.WriteLine(x380);
Console.WriteLine(C162);
Console.WriteLine(PC21);

        
        
        }
}
}
