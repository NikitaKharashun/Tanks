using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_Tanks.BaseClass;

namespace Nikita_Tanks.BaseClass
{
    class Tank
    {
        public string Name { get; private set; }
        public int Ammunition { get; private set; }
        public int Armor { get; private set; }
        public int Mobility { get; private set; }

        public Tank(string name, int ammunition, int armor, int mobility)
        {
            Name = name;
            Ammunition = ammunition;
            Armor = armor;
            Mobility = mobility;
        }

        public static int operator - (Tank RussianTanks, Tank GermanTanks)
        {
            int wins = 0;

            wins += RussianTanks.Armor > GermanTanks.Armor ? 1 : -1;
            wins += RussianTanks.Ammunition > GermanTanks.Ammunition ? 1 : -1;
            wins += RussianTanks.Mobility > GermanTanks.Mobility ? 1 : -1;

            Console.WriteLine(wins > 0 ? $"Победа {RussianTanks.Name}" : $"Победа {GermanTanks.Name}");
            return wins;
        }
        public override string ToString() => $"{Name}\t\t {Ammunition}\t {Armor}\t {Mobility}";
    }
}
