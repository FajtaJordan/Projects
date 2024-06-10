using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._11._20.oop._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Benzinkut benzinkut = new Benzinkut();

            List<Car> autok = new List<Car>
        {
            new Car("Ford GT40 MK.II", 200, 10, 50),
            new Car("Porsche 906", 300, 15, 60),
            new Car("Ferrari 275", 150, 8, 40),
            new Car("Alpine A210", 250, 12, 55),
            new Car("Porsche 911", 180, 9, 45),
        };

            Console.WriteLine("----- Kezdeti állapot -----");
            KiirAllapot(autok, benzinkut);

            Random random = new Random();

            do
            {
                for (int i = 0; i < autok.Count; i++)
                {
                    Car auto = autok[i];

                    if (auto.Mozgaskeszseg())
                    {
                        double tavolsag = random.Next(10, 100);
                        auto.Utazas(tavolsag);
                    }
                    else if (!auto.Megallt())
                    {
                        auto.Nev += " (megállt)";
                        Console.WriteLine($"{auto.Nev}");
                    }
                }

            } while (autok.Exists(auto => auto.Mozgaskeszseg()));

            Console.WriteLine("Az összes autó megállt. A szimuláció véget ért.");
            KiirAllapot(autok, benzinkut);
        }

        private static void KiirAllapot(List<Car> autok, Benzinkut benzinkut)
        {
            Console.WriteLine("\n----- Aktuális állapot -----");
            foreach (Car auto in autok)
            {
                Console.WriteLine($"{auto.Nev}: Üzemanyag: {auto.JelenlegiUzemanyag:F2} liter, Pénz: {auto.Penz}");
            }
            Console.WriteLine($"Benzinkút: Tartalom: {Benzinkut.JelenlegiTartalom:F2} liter, Ár: {Benzinkut.UzemanyagAr:F2} literenként");
        }
    }
    
}
