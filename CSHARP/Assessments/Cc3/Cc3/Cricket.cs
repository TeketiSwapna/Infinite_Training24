using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cc3
{
  
    public class Cricket
    {
        public void PointsCalculation(int matches_played)
        {
            int[] scores = new int[matches_played];  
            for (int i = 0; i < matches_played; i++)
            {
                Console.Write($"Enter scores {i + 1}: ");
                scores[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;
            foreach (int score in scores)
            {
                total += score;
            }
            int avg = (int)total / matches_played;
            Console.WriteLine($"Sum of scores: {total}");
            Console.WriteLine($"Average score: {avg:F2}");
            Console.Read();
        }
    }
    public class Test1
    {
        public static void Main()
        {
            Console.Write("Enter no.of matches played: ");
            int matches_played = int.Parse(Console.ReadLine());
            Cricket cricket = new Cricket();
            cricket.PointsCalculation(matches_played);
        }
    }
}

