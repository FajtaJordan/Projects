using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._11._20.oop._1
{
    internal class Benzinkut
    {
        public static double JelenlegiTartalom { get; set; }
        public static double UzemanyagAr { get; set; }

        static Benzinkut()
        {
            JelenlegiTartalom = 1000;
            UzemanyagAr = 2.5;
        }
    }
}
