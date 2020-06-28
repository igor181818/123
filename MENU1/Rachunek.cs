using System;
using System.Collections.Generic;
using System.Text;

namespace MENU1
{
   abstract class Rachunek
    {
      
        private int nrr;

        public int Nrr
        {
            get { return nrr; }
            set { nrr = value; }
        }
        abstract public void Rach();
      public Rachunek(int nrr)
        {
            this.nrr = nrr;
        }

    }
    
    }
