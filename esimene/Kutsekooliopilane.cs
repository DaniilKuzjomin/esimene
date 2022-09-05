using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
    class Kutsekooliopilane : Isik
    {
        public string oppeasutus;
        public string eriala;
        public string kursus;
        public int toetus;

        public Kutsekooliopilane(string oppeasutus, string eriala, int kursus, int toetus, string klass, string spetsialiseerumine, string nimi, int sunniaasta, sugu InimSugu, double maksuvaba, double palk) : base(nimi, sunniaasta, InimSugu, maksuvaba, palk)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;
        }

        public int arvutaVanus()
        {
            int praeguneAasta = DateTime.Now.Year;
            int vanus = praeguneAasta - sunniaasta;
            return vanus;
        }


        public override double arvSisse(double maksuvaba, double tulumaks, double palk)
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }
        public override void printInfo()
        {
            Console.WriteLine($"Tema õppeasutus on {oppeasutus} ja tema eriala on {eriala}, ta on kursusel #{kursus} ja tema toetus on {toetus}, tema töötasu on {arvSisse(palk, maksuvaba, tulumaks)}, tema nimi on {nimi}, ta on {InimSugu} ja tema vanus on {arvutaVanus()}");
        }

    }
}
