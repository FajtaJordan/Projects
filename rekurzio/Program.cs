using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurzio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region szorzas
            /*Console.WriteLine("Kérem a szorzandót!");
            int sznd = SzamBe();
            Console.WriteLine("Kérem a szorzót");
            int szrz = SzamBe();
            recursions RK = new recursions();
            Console.WriteLine(sznd+" * "+szrz+" = " + RK.Szorzas(sznd,szrz));*/
            #endregion
            #region hatvanyozas
            /*Console.WriteLine("Kérem a alapot!");
            int Alap = SzamBe();
            Console.WriteLine("Kérem a szorzót");
            int Kitevo = SzamBe();
            recursions RK = new recursions();
            Console.WriteLine(Alap + " * " + Kitevo + " = " + RK.Hatvany(Alap, Kitevo));*/
            #endregion
            #region faktoriális
            /*Console.WriteLine("Kérem a számot!");
            int Fakt = SzamBe();
            recursions RK = new recursions();
            Console.WriteLine(Fakt+"!"+" = "+ RK.Faktorialis(Fakt));
            */
            #endregion
            #region Fibonacci sorozat
            /* Console.WriteLine("Hány Fibonacci elemet irjak ki?");
             int f = SzamBe();
             recursions RK = new recursions();
             for (int i = 0; i < f; i++)
             {
                 Console.WriteLine(RK.Fibonacci(i) + " ");
             }
             Console.WriteLine();*/
            #endregion
            #region Bináris váltó
            /*Console.WriteLine("Kérem a decimális számot!");
            int dec = SzamBe();
            recursions RK = new recursions();
            Console.WriteLine(dec+"d = "+ RK.Binaris(dec) + "b");*/
            #endregion
            #region Bármilyen váltó
            /*Console.WriteLine("Kérem a decimális számot!");
            int dec = SzamBe();
            Console.WriteLine("Kérem a Számrendszert!");
            int szr = SzamBe();
            
            string felirat = "";
            switch (szr)
            {
                case 2: felirat = "b"; break;
                case 8: felirat = "o"; break;
                case 10: felirat = "d"; break;
                case 16: felirat = "h"; break;
                default:
                    felirat = " számrendszer " + szr;
                    break;
            }
            recursions RK = new recursions();
            Console.WriteLine(dec + " d =" + RK.SzamrendszerValto(dec,szr) + " " + felirat);*/
            #endregion
            #region Binominális tétel
            Console.WriteLine("Hányadik fokot kéred?");
            int fokszam = SzamBe();
            recursions RK = new recursions();
            for (int k = 0; k < fokszam; k++)
            {
                Console.WriteLine(RK.Binominalis(fokszam,k) + "");
            }
            #endregion
            Console.ReadKey();
        }
        static int SzamBe()
        {
            int szam = 0;
            do { Console.WriteLine("Kérek egy egész számot"); ; } while (!int.TryParse(Console.ReadLine(), out szam) || szam<=0);
            return szam;
        }
       
    }
}
