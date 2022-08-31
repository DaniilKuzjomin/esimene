using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
    abstract class Isik
    {
        public string nimi;
        public int sunniaasta;
        public int vanus;
        public enum sugu { mees, naine }
        public sugu InimSugu;
        public double sissetulek;
        public double maksuvaba;
        public double palk;
        public double tulumaks;

        /*public Isik(sugu inimSugu, string nimi = "---", int sunniaasta=0)
        {
            this.nimi = nimi;
            this.sunniaasta = sunniaasta;
            this.InimSugu=inimSugu;
        }*/

        public Isik(string nimi, int sunniaasta, int vanus, sugu inimSugu, int maksuvaba, int tulumaks)
        {
            this.nimi = nimi;
            this.sunniaasta = sunniaasta;
            this.vanus = vanus;
            InimSugu = inimSugu;
        }
        
        public Isik() { }

        protected Isik(string nimi, int sunniaasta, sugu sugu, int maksuvaba, int palk)
        {
            this.nimi = nimi;
            this.sunniaasta = sunniaasta;
            this.InimSugu = InimSugu;
        }

        public abstract void printInfo();

        public int arvutaVanus()
        {
            int praeguneAasta = DateTime.Now.Year;
            int vanus = praeguneAasta - sunniaasta;
            return vanus;
        }

        public void arvutaSissetulek()
        {
            
        }

        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
    }
}
