using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._11._20.oop._1
{
    internal class Car
    {
        public string Nev { get; set; }
        public int Penz { get; set; }
        public double Fogyasztas { get; set; }
        public double TankMeret { get; set; }
        public double JelenlegiUzemanyag { get; set; }

        public Car(string nev, int penz, double fogyasztas, double tankMeret)
        {
            Nev = nev;
            Penz = penz;
            Fogyasztas = fogyasztas;
            TankMeret = tankMeret;
            JelenlegiUzemanyag = tankMeret;
        }

        public void Utazas(double tavolsag)
        {
            double szuksegesUzemanyag = tavolsag / Fogyasztas;

            if (JelenlegiUzemanyag >= szuksegesUzemanyag)
            {
                Console.WriteLine($"{Nev} utazik {tavolsag} km-t.");
                JelenlegiUzemanyag -= szuksegesUzemanyag;
            }
            else
            {
                Console.WriteLine($"{Nev} nem rendelkezik elegendő üzemanyaggal. Megáll az utántöltéshez.");
                UzemanyagToltes();
            }
        }
        private bool elsoMegallas = true;

        public void UzemanyagToltes()
        {
            if (elsoMegallas)
            {
                if (Penz > 0 && Benzinkut.JelenlegiTartalom > 0)
                {
                    double toltesMennyiseg = Math.Min(TankMeret - JelenlegiUzemanyag, Benzinkut.JelenlegiTartalom);
                    double koltseg = toltesMennyiseg * Benzinkut.UzemanyagAr;

                    if (Penz >= koltseg)
                    {
                        Console.WriteLine($"{Nev} utántölt {toltesMennyiseg} liter üzemanyagot.");
                        JelenlegiUzemanyag += toltesMennyiseg;
                        Penz -= (int)koltseg;
                        Benzinkut.JelenlegiTartalom -= toltesMennyiseg;
                        Console.WriteLine($"{Nev} fizetett {koltseg} pénzt az utántöltésért.");
                    }
                    else
                    {
                        Console.WriteLine($"{Nev} nem rendelkezik elegendő pénzzel az utántöltéshez. Megáll.");
                        elsoMegallas = false;
                    }
                }
                else
                {
                    Console.WriteLine($"{Nev} nem tudja újratölteni az üzemanyagot. Megáll.");
                    elsoMegallas = false;
                }
            }
        }

        public bool Mozgaskeszseg()
        {
            return JelenlegiUzemanyag > 0;
        }

        public bool Megallt()
        {
            return !Mozgaskeszseg() && !Nev.Contains("(megállt)");
        }
    }
}
