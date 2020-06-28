using System;
using System.Collections.Generic;
using System.Text;

namespace MENU1
{
    class menu
    {
        interface Iaaaa
        {
         
        }
        protected int numer;

        public int Numer
        {
            get { return numer; }
            set { numer = value; }
        }

        protected double cena;

        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }

        protected string nazwa;

        public  string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        public menu(int numer, double cena, string nazwa)
        {
            this.numer = numer;
            this.nazwa = nazwa;
            this.cena = cena;
        }
        public virtual void WypiszInfo()
        {
            Console.WriteLine("{0} {1}zł {2}" , numer, cena,nazwa);
        }
        
    }
}
