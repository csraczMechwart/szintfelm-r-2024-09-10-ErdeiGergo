using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foci
{
    internal class Meccs
    {
        public int Fordulo { get; set; }
        public int HazaiVegeredmeny { get; set; }
        public int VendegVegeredmeny { get; set; }
        public int HazaiFelido { get; set; }
        public int VendegFelido { get; set; }
        public string HazaiCsapat { get; set; }
        public string VendegCsapat { get; set; }

        public Meccs(int fordulo, int hazaiVegeredmeny, int vendegVegeredmeny, int hazaiFelido, int vendegFelido, string hazaiCsapat, string vendegCsapat)
        {
            Fordulo = fordulo;
            HazaiVegeredmeny = hazaiVegeredmeny;
            VendegVegeredmeny = vendegVegeredmeny;
            HazaiFelido = hazaiFelido;
            VendegFelido = vendegFelido;
            HazaiCsapat = hazaiCsapat;
            VendegCsapat = vendegCsapat;
        }
    }
}
