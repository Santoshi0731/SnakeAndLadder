using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class RollDie
    {
        public static void RollTheDie()
        {

            int Start_Position = 1;

            Random  random= new Random();
            int rollDie =random.Next(1,6);

            Console.WriteLine("Player Roll The Die with number = " +  rollDie);


        }
    }
}
