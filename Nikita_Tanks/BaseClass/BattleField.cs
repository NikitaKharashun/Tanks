using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_Tanks.Interfaces;


namespace Nikita_Tanks.BaseClass
{
    class BattleField
    {
        public static void Battle(Team firstTeam, Team secondTeam)
        {
            if (firstTeam.AmountOfTanks > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Состав  Боекомплект  Уровень брони  Маневренность");
                Console.ForegroundColor = ConsoleColor.Red;
                int allWins = 0;

                for (int i = 0; i < firstTeam.AmountOfTanks; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new string('-', 40));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Бой {i + 1}");

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(firstTeam[i]);
                    Console.WriteLine(secondTeam[i]);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new string('-', 40));


                    Console.ForegroundColor = ConsoleColor.Green;
                    allWins += (firstTeam[i] - secondTeam[i]) > 0 ? 1 : -1;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new string('-', 40));
                Console.WriteLine(new string('-', 40));

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(allWins > 0 ? "Победа Русских!!!" : "Победа Немцев!!!");
            }
            else
                Console.WriteLine("Количество танков не должно быть равно нулю");
        }
    }
}