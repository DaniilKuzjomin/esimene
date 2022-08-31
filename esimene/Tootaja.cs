using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
    class Tootaja : Isik
    {

        public string asutus;
        public string amet;


        public Tootaja(string asutus, string amet, string nimi, int sunniaasta, sugu InimSugu, double maksuvaba, double palk, double tulumaks):base(nimi, sunniaasta, InimSugu, maksuvaba,)
        {
            this.asutus = asutus;
            this.amet = amet;
            this.maksuvaba = maksuvaba;
        }

        public object Sugu { get; private set; }

        public double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            double netopalk = ((tootasu - maksuvaba) * (1-(tulumaks / 100))) + maksuvaba;
            return netopalk;
        }

        public override void printInfo()
        {
            Console.WriteLine($"Tema asutus on {asutus}, ta töötab {amet}, tema netto palk on, tema nimi on {nimi} {Sugu} ja {arvutaVanus} ");
        }

        private object arvutaSissetulek(int palk, int maksuvaba, double tulumaks)
        {
            throw new NotImplementedException();
        }
    }
}
