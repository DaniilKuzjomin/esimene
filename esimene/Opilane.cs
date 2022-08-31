using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
     class Opilane : Isik
    {

        public string koolinimi;
        public string klass;
        public string spetsialiseerimine;

        public Opilane(string koolinimi, string klass, string spetsialiseerimine):base()
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerimine = spetsialiseerimine;
        }

        public override void printInfo()
        {
            Console.WriteLine("Ta on {0}, Tema nimi on {1}, tema vanus on {2} ja tema sunniaasta on {3}", nimi, sunniaasta,InimSugu );
        }

        public void arvutaSissetulek()
        {
        }
    }
}
