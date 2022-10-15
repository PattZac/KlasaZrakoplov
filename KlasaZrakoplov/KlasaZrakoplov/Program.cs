using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaZrakoplov
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciranje objekt 2
            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Zrakoplov PC21 = new Zrakoplov("Pilatus", 1200, 1333);

            Console.WriteLine("Zrakoplov x380");
            Console.WriteLine(x380.ToString());
            Console.WriteLine("\r\nZrakoplov C162");
            Console.WriteLine(C162.ToString());
            Console.WriteLine("\r\nZrakoplov PC-21");
            Console.WriteLine(PC21.ToString());

            Console.ReadKey();
        }
    }

    class Zrakoplov
    {
        //svojstva
        private string naziv;
        private double snagaMotora;
        private int dosegLeta;

        public override string ToString()
        {
            string ispis = "Naziv: " + this.naziv
            + "\r\nSnaga Motora: " + this.snagaMotora + " kW"
            + "\r\nDoseg Leta: " + this.dosegLeta + " km";
            return ispis;
        }

        public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
        {
            this.naziv=naziv;
            this.snagaMotora=snagaMotora;
            this.dosegLeta=dosegLeta;
        }
    }
}
