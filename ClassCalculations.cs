using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBankaHelisek
{
    public class ClassCalculations
    {
        DateTime today = DateTime.Now;
        public delegate void VystupVysledku(string s);
        public static VystupVysledku VystupMonth { get; set; } = null;
        public static VystupVysledku VystupYear { get; set; } = null;

        // Metoda pro měsíční výpočet
        public static void Month(double a, double b) => VystupMonth?.Invoke(Math.Round((a * b * 0.01),2).ToString());

        // Metoda pro roční výpočet
        public static void Year(double a, double b) => VystupYear?.Invoke(Math.Round((a/(a * b * 0.01)/12),2).ToString());
    }
}
