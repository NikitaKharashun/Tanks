using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_Tanks.BaseClass;
using Nikita_Tanks.Interfaces;

namespace Nikita_Tanks.BaseClass
{
    class Team : ITeam
    {
        public string Name { get; private set; }
        public int AmountOfTanks {get; private set; }
        public Tank[] Members { get; private set; } 
        public Team(string name, int amountOfTanks)
        {
            Name = name;
            AmountOfTanks = amountOfTanks;
        }


        public void Setter (string name)
        {
            Tank[] team = new Tank[AmountOfTanks];
            var rnd = new Random();

            for (int i = 0; i < AmountOfTanks; i++)
            {
                team[i] = new Tank(name, rnd.Next(10, 100), rnd.Next(10, 100), rnd.Next(10, 100));
            }

            Members = team;
        }


        public Tank this[int index]
        {
            get => (index < AmountOfTanks && AmountOfTanks >= 0) ? Members[index] : null;

            private set
            {
                if (index < AmountOfTanks && index >= 0)
                    Members[index] = value;
                else
                    Console.WriteLine("Индекс за пределами");
            }
        }
    }
}
