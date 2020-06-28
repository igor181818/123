using System;
using System.Collections.Generic;
using System.Text;

namespace MENU1
{
    class Jedzenie : menu , 
    {
        
        private int waga;

        public int Waga
        {
            get { return waga; }
            set { waga = value; }
        }
        private bool wege;

        public  bool Wege
        {
            get { return wege; }
            set { wege = value; }
        }
        public Jedzenie(int numer, string nazwa, double cena, int waga,bool wege) : base(numer, cena,nazwa)
        {
            this.numer = numer;
           
            this.cena = cena;
            this.waga = waga;
            this.wege = wege;
        }
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("{0}g{1}", waga, wege);
        }
    }

}
