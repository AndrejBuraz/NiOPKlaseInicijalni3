using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanjeKlase3
{
    class Vozilo
    {
        public bool JeLiLeti, JeLiPlovi;

        public void KudaVozi()
        {
            Console.WriteLine("JeLiLeti: " + this.JeLiLeti + "\nJeLiPlovi: " + this.JeLiPlovi);
        }

        public Vozilo()
        {
        }

        public bool JeLiLeti1 { get => JeLiLeti; set => JeLiLeti = value; }
        public bool JeLiPlovi1 { get => JeLiPlovi; set => JeLiPlovi = value; }
    }

    class Brod : Vozilo
    {
        public Brod()
        {
            this.JeLiPlovi = true;
            this.JeLiLeti = false;
        }
    }

    class Zrakoplov : Vozilo
    {
        public Zrakoplov()
        {
            this.JeLiPlovi = false;
            this.JeLiLeti = true;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Brod brod = new Brod();
            Zrakoplov zrakoplov = new Zrakoplov();
            Console.WriteLine("Brod: ");  
            brod.KudaVozi();
            Console.WriteLine("Zrakoplov: ");
            zrakoplov.KudaVozi();
            Console.ReadKey();
        }
    }
}
