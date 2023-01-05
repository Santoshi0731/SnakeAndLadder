using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Player_Moves
    {
        public static void Player_Moves_Position()
        {
            Random random = new Random();
            int rollDie = random.Next(1, 6);

            Console.WriteLine("Player Roll The Die with number = " + rollDie);

            int rollPosition = 0;

            if (rollDie!=rollPosition )
            {
                Console.WriteLine("Player Not Roll The Die with stay in the same position");
            }
            //else if(rollDie==rollPosition)
            //{
               // Console.WriteLine("The player moves ahead by the number of position received in the die");
            //}



        }
    }
}
