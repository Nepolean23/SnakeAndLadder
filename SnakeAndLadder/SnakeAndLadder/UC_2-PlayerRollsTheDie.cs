using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC_2_PlayerRollsTheDie
    {
        public static void DiceRoll()
        {
            Random random= new Random();
            int roll = random.Next(1, 7);//Generates Random Number
            Console.WriteLine("Player Generates The Number: "+roll);
        }
    }
}
