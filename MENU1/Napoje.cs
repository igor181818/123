using System;
using System.Collections.Generic;
using System.Text;

namespace MENU1
{
    class Napoje : menu
    {
       
        private int objetosc;

        public int Objetosc
        {
            get { return objetosc; }
            set { objetosc = value; }
        }
        public Napoje(int numer,string nazwa, double cena, int objetosc) : base(numer,cena,nazwa)
        {
            this.numer = numer;
            this.cena = cena;
            this.objetosc = objetosc;
        }
        List<Napoje> napoj = new List<Napoje>();
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("{0}ml", objetosc);
        }
    }
}
