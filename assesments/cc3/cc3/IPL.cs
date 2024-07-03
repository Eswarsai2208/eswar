using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3
{
    public class Cricket
    {
        private double[] scores;
        private int numMatches;

        public void Initialize()
        {
            Console.Write("Enter the number of matches: ");
            numMatches = Convert.ToInt32(Console.ReadLine());
            scores = new double[numMatches];
        }
        public void InputScores()
        {
            for (int i = 0; i < numMatches; i++)
            {
                Console.Write($"Enter score for match {i + 1}: ");
                scores[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void CalculateAndDisplayResults()
        {
            double totalSum = 0;
            foreach (double score in scores)
            {
                totalSum += score;
            }
            double average = totalSum / numMatches;
            Console.WriteLine($"Total sum of scores: {totalSum}");
            Console.WriteLine($"Average score: {average}");
            Console.Read();
        }
    }
    class IPL
    {
        static void Main()
        {
            Cricket cricket = new Cricket();
            cricket.Initialize();
            cricket.InputScores();
            cricket.CalculateAndDisplayResults();
        }
    }
}
