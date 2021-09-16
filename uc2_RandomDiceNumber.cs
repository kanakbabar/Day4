using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    class uc2_RandomDiceNumber
    {
        public static void DiceRoll()
        {
            int player1;
            Random rd = new Random();
            player1 = rd.Next(1, 7);
            Console.WriteLine("The player1 gets the dice number is: " + player1);

        }
    }
}
