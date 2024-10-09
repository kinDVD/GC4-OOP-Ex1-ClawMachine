using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GC4_OOP_Ex1_ClawMachine
{
    static class ClawMachine
    {
        public static List<Reward> AllRewards { get; } = new List<Reward>
        {
            new Reward ("Cheap Candy", 0.50m),
            new Reward ("Cheap Candy", 0.50m),
            new Reward ("Cheap Candy", 0.50m),
            new Reward ("Candy Bar", 1.00m),
            new Reward ("Candy Bar", 1.00m),
            new Reward ("Stuffed Animal", 10.00m)
        };
        public static decimal CostToPlay { get; } = 1.50m;

        public static Reward GetReward()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, AllRewards.Count);
            return AllRewards[num];
        }

        public static bool MadeProfit(Reward reward)
        {
            bool profit = false;
            if (reward.Value > CostToPlay)
            {
                profit = true;
            }
            return profit;
        }
        public static void Play()
        {
            Reward reward = GetReward();
            Console.WriteLine($"{reward.Name}: ${reward.Value}");
            bool profit = MadeProfit(reward);
            if(profit == true)
            {
                Console.WriteLine("You made a profit");
            }
            {
                Console.WriteLine("You lost money");
            }
        }
    }
}
