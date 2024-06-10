using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurzio
{
    internal class recursions
    {
        public recursions() { ABC_feltoltes(); }
        public int Szorzas(int szorzando, int szorzo)
        {
            if (szorzo == 0) return 0;
            else return Szorzas(szorzando,szorzo - 1) + szorzando;
        }
        public int Hatvany(int alap, int kitevo)
        {
            if(kitevo == 0) return 1;
            else return  Szorzas( Hatvany(alap, kitevo - 1), alap);
        }
        /*Faktoriális
         * fibonacci n.  eleme*/
        public int Faktorialis(int fakt)
        {
            if (fakt == 0) return 1;
            else return Szorzas(Faktorialis(fakt-1), fakt);
            //else return fakt * Faktorialis(fakt - 1);
        }
        public int Fibonacci(int n) // a sorozat egy eleme
        {
            if (n < 2) return n;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        //Decimálisból binárisba váltás rekurzívan
        public string Binaris(int szam)
        {
            if (szam == 0) return "";
            else return "" + Binaris(szam / 2) + (szam % 2);
        }
        Dictionary<int,string> ABC = new Dictionary<int,string>();
        private void ABC_feltoltes()
        {
            for (int i = 0; i < 10; i++)
            {
                ABC.Add(i, i.ToString());
            }
            for (int i = 10; i < 16; i++)
            {
                ABC.Add(i, (char)(i + 55) + "");
            }
        }
        public string SzamrendszerValto(int szam, int szr)
        {
            if (szam == 0) return "";
            else return  SzamrendszerValto(szam / szr, szr) + (szam % szr) + ABC[(szam % szr)];
        }
        public int Binominalis(int n, int k)
        {
            if (k == 0 || k == n) return 1;
            else return Binominalis(n - 1, k - 1) + Binominalis(n - 1, k);
        }
    }
}
