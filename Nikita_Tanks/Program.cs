using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_Tanks.BaseClass;


namespace Nikita_Tanks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество танков в команде: ");
            int.TryParse(Console.ReadLine(), out int size);      
            
            var firstTeam = new Team("Русские", size);
            var secondTeam = new Team("Немцы", size);

            firstTeam.Setter("T-34");
            secondTeam.Setter("Panther");

            BattleField.Battle(firstTeam, secondTeam);
            Console.ReadKey();
        }
    }
}
