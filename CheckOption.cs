using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    class CheckOption
    {

        public static void OptionToPlay()
        {
                //Constant
                //const int START_POSITION = 0;
                const int NO_PLAY = 0;
                const int LADDER = 1;
                //const int SNAKE = 2;

                Random random = new Random();
                int option = random.Next(0, 3);
                int dieValue = random.Next(1, 7);
                int player = 0;
                if (dieValue == NO_PLAY)
                {
                    Console.WriteLine("No Play, Pass the chance");
                }
                else if (dieValue == LADDER)
                {


                    player += dieValue;
                    Console.WriteLine("You got Ladder \n player position = " + player);
                }
                else
                {
                    player -= dieValue;
                    Console.WriteLine("You gotSnake \n player position = " + player);
                }
            }
        }
    }
       