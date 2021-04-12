using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    class PlayerRollsDie
    {
        
        public static void DieRoll()
        {
            //int START_POSITION = 0;
            Random random = new Random();
            int dieValue = random.Next(0, 6);
            Console.WriteLine(" Player die roll position = " + dieValue);
        }
    }
}
   
