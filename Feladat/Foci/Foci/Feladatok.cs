using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foci
{
    internal class Feladatok
    {            
        public static List<Meccs> meccsek = new();
        public Feladatok(string filename)
        {
            foreach (var item in File.ReadAllLines(filename, Encoding.UTF8).Skip(1))
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
        
        public void Feladat2()
        {
            Console.WriteLine("2. feladat:");
            Console.Write("Írja be egy fordulónak a számát: ");
            int megadottFordulo = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < meccsek.Count(); i++)
            {
                if (meccsek[i].Fordulo == megadottFordulo)
                {
                    Console.WriteLine($"{meccsek[i].HazaiCsapat}-{meccsek[i].VendegCsapat}: {meccsek[i].HazaiVegeredmeny}-{meccsek[i].VendegCsapat} ({meccsek[i].HazaiFelido}-{meccsek[i].VendegFelido})");
                }
            }
        }

        public void Feladat3()
        {
            Console.WriteLine("\n3. feladat:");
            for (int i = 0;i < meccsek.Count();i++)
            {
                if (meccsek[i].HazaiFelido < meccsek[i].HazaiVegeredmeny)
                {
                    Console.WriteLine($"{meccsek[i].Fordulo}. forduló {meccsek[i].HazaiCsapat}");
                }
                else if (meccsek[i].VendegFelido < meccsek[i].VendegVegeredmeny)
                {
                    Console.WriteLine($"{meccsek[i].Fordulo}. forduló {meccsek[i].VendegCsapat}");
                }
            }
        }
    }
}
