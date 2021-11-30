using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba2_klase_i_objekti
{
    class KlasaC
    {

        public int Zbroj(int[] niz)
        {
            
            int zbroj = 0;

            for (int brojac=0; brojac < niz.Length; brojac++)
            {
                zbroj+=niz[brojac];
            }
            return zbroj;
        }

        public double Prosjek(int[] niz)
        {
            double zbroj = Zbroj(niz);
            double prosjek = zbroj/niz.Length;
            return prosjek;
        }

    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] niz = new int[5];
            int redniBroj = 1;

            /*int zbroj;
            double prosjek;*/

            Console.WriteLine("Vježba 2 - kalse i obkjekti\n");
            Console.WriteLine("Upiši 5 brojeva. ");

            for(int brojac=0; brojac<niz.Length; brojac++)
            {    
                
                Console.Write(redniBroj + ". broj: ");
                niz[brojac]=Convert.ToInt32(Console.ReadLine());
                redniBroj++;


            }

            KlasaC objekt = new KlasaC();
            /*
            zbroj = objekt.Zbroj(niz);
            Console.WriteLine("Zbroj članova niza je: " + zbroj);

            prosjek = objekt.Prosjek(niz);
            Console.WriteLine("Prosjek članova niza je: " + prosjek);
            */

            Console.WriteLine("Zbroj članova niza je: " + objekt.Zbroj(niz));
            Console.WriteLine("Prosjek članova niza je: " + objekt.Prosjek(niz));

            Console.ReadKey();
        }
    }
}
