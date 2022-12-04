using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC_1_SinglePlayer
    {
        public static void SinglePlayer()
        {
            Random random= new Random();
            int dice = random.Next(1, 7); //Generates Random Number
            if(dice==0)
            {
                Console.WriteLine("The Player Ready To Play: "+dice);

            }
            else
            {
                Console.WriteLine("Roll Again");
            }
        }
    }
}
