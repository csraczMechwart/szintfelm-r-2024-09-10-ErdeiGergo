using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foci
{
    internal class Feladatok
    {            
        public List<Meccs> meccsek;
        public Feladatok(string filename)
        {
            foreach (var item in File.ReadAllLines(filename, Encoding.UTF8))
            {
                string[] reszek = item.Split(" ");
                int fordulo = Convert.ToInt32(reszek[0]);
                int hazaiVegeredmeny = Convert.ToInt32(reszek[1]);
                int vendegVegeredmeny = Convert.ToInt32(reszek[2]);
                int hazaiFelido = Convert.ToInt32(reszek[3]);
                int vendegFelido = Convert.ToInt32(reszek[4]);
                string hazaiCsapat = reszek[5];
                string vendegCsapat = reszek[6];
                Meccs uj = new Meccs(fordulo, hazaiVegeredmeny, vendegVegeredmeny, hazaiFelido, vendegFelido, hazaiCsapat, vendegCsapat);
                meccsek.Add(uj);
            }
        } 
        //
    }
}
