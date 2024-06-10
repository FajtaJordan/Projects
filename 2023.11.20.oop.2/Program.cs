using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._11._20.oop._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Név: ");
            string nev = Console.ReadLine();
            Console.Write("Fizetési kategória: ");
            int fizetesi = int.Parse(Console.ReadLine());
            Console.Write("Éves szabik: ");
            int evesSzabik = int.Parse(Console.ReadLine());
            Console.Write("Eddig kivett szabik: ");
            int EddigKivett = int.Parse(Console.ReadLine());
            Munkavallalo x = new Munkavallalo(nev, fizetesi, evesSzabik, EddigKivett);
            Console.WriteLine(x.evesSzabi);
            Console.WriteLine(x.FizKat);
            Console.WriteLine(x.Nev);
            Console.WriteLine(x.EddigKivettSzabi);
            Console.Write("kivehető szabik:");
            Console.WriteLine(x.KivehetoSzabi());
            Console.ReadKey();
        }
    }
}
