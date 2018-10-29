using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        public string Name { get; set; }
        public int AmmunitionLevel { get; set; }
        public int ArmorLevel { get; set; }
        public int ManeuverabilityLevel { get; set; }
        static Random rnd = new Random();

        public Tank(string name)
        {
            this.Name = name;
            this.AmmunitionLevel = rnd.Next(0, 100);
            this.ArmorLevel = rnd.Next(0, 100);
            this.ManeuverabilityLevel = rnd.Next(0, 100);

        }

        public void GetInfo() {
            Console.WriteLine("Ammunition Level" + AmmunitionLevel);
            Console.WriteLine("Armor Level" + ArmorLevel);
            Console.WriteLine("Maneuverability Level" + ManeuverabilityLevel);
        }
    }
}
