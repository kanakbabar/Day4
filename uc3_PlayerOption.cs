using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    class uc3_PlayerOption
    {
        public static void PlayerPosition()
        {
            Random die = new Random();
            int a = die.Next(1, 7);
            Console.WriteLine("Dice obtain is " + a);
            int position = 0;
            Random option = new Random();
            int Opt = option.Next(1, 4);
            switch (Opt)
            {
                case 1:
                    Console.WriteLine("Player does not Play");
                    break;
                case 2:
                    Console.WriteLine("Player gets a Snake");
                    if ((position - a) < 0)
                        position = 0;
                    else
                        position -= a;
                    break;
                case 3:
                    Console.WriteLine("Player gets a Ladder");
                    position += a;
                    if (position > 100)
                        position = position;
                    break;
            }
            Console.WriteLine("player position: " + position);

        }
    }
}