using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC_4_PlayerAtWinPosition
    {
        public static void WinPosition()
        {
            int currentPosition = 0;
            int startPosition = 0;
            int win = 100;
            int position = 0;
            const int noPlay = 1;
            const int ladder = 2;
            const int snake = 3;

            Random random = new Random();
            int r = random.Next(1, 7);
            int option = random.Next(1, 4);
            while(position<win)
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
                            position = currentPosition;
                            if (position < win)
                            {
                                currentPosition += r;
                                Console.WriteLine("Player moves in ladder at position: " + r);
                            }
                            else if (currentPosition> win)
                            {
                                currentPosition = position;
                            }
                        }
                        break;
                    case snake:
                        {
                            if (currentPosition > 0)
                            {

                                position -= r;
                                Console.WriteLine("Player bitten by snake at position: " + r);
                            }
                            else if (currentPosition<0)
                            {
                                currentPosition= startPosition;
                            }
                        }
                        break;
                }
                Console.WriteLine("The Final position is: "+position);
            }
        }
    }
}
