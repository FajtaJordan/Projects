using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._11._20.oop._2
{
    internal class Munkavallalo
    {
        internal int eddigKivettSzabi, evesSzabi, fizKat;
        internal string nev;
        public Munkavallalo(string nev, int fizKat, int evesSzabi, int eddigKivettSzabi)
        {
            this.nev = nev;
            this.fizKat = fizKat;
            this.evesSzabi = evesSzabi;
            this.eddigKivettSzabi = eddigKivettSzabi;
        }

        internal int EddigKivettSzabi
        {
            get { return eddigKivettSzabi; }
        }
        internal int FizKat
        {
            get { return fizKat; }
        }
        internal string Nev
        {
            get { return nev; }
        }

        internal int KivehetoSzabi()
        {
            if (fizKat > 0 && fizKat < 6)
            {
                int kivehetoSzabi;
                kivehetoSzabi = evesSzabi - eddigKivettSzabi;
                return kivehetoSzabi;
            }
            else
            {
                Console.WriteLine("Helytelen fizetési kategória");
                return 0;
            }
        }
    }
}
