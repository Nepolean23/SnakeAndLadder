using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC_3_PlayerChecksForOptions
    {
        public static void OptionsChecking()
        {
            const int noPlay = 1;
            const int ladder = 2;
            const int snake= 3;
            
            Random random= new Random();
            int r = random.Next(1, 7);
            int option=random.Next(1, 4);
            switch(option)
            {
                case noPlay:
                    {
                        Console.WriteLine("Player in NoPlay Position");
                    }
                    break;
                case ladder: 
                    {

                    }
                    break;
            }
        }
    }
}
