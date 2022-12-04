using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC_5_ExactWinPosition
    {
        public static void WiningPosition()
        {
            int current_Position = 0;
            int start_Position = 0;
            int win = 100;
            int position = 0;
            const int noPlay = 1;
            const int ladder = 2;
            const int snake = 3;

            Random random = new Random();
            int r = random.Next(1, 7);
            int option = random.Next(1, 4);
            while (position < win)
            {
                switch (option)
                {
                    case noPlay:
                        {
                            Console.WriteLine("Player in same Position");
                        }
                        break;
                    case ladder:
                        {
                            position = current_Position;
                            if (position < win)
                            {
                                current_Position += r;
                                Console.WriteLine("Player moves in ladder at position: " + r);
                            }
                            else if (current_Position > win)
                            {
                                current_Position = position;
                            }
                        }
                        break;
                    case snake:
                        {
                            if (current_Position > 0)
                            {

                                position -= r;
                                Console.WriteLine("Player bitten by snake at position: " + r);
                            }
                            else if (current_Position < 0)
                            {
                                current_Position = start_Position;
                            }
                        }
                        break;
                }
                Console.WriteLine("The Final position reached is: " + position);
            }
    }
}
