using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SinglePlayer_UC1
    {
        public static void Position()
        {
            int Start_Position = 1 ;

            Random random= new Random();
            int positionCheck = random.Next(2);

            if (positionCheck == Start_Position)
            {
                Console.WriteLine("player Position Start with 0");
            }
            else
            {
                Console.WriteLine("player position with next step");
            }
        }
          
    }
}
