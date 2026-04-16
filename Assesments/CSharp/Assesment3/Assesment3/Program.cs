using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment3
{
     class Cricket_Team
    {
        public static List<int> PlayerScores=new List<int>();
        public static int PointsCalculation(int no_of_matches)
        {
            Console.WriteLine("Enter the Scores of the Player");
            for(int i = 0; i < no_of_matches; i++)
            {
                int Scores = Convert.ToInt32(Console.ReadLine());
                PlayerScores.Add(Scores);
            }

            Console.WriteLine("The Average Scores of the Player:");
            int Avg = 0;
            foreach(var i in PlayerScores)
            {
                Avg += i;
            }
            Console.WriteLine(Avg/no_of_matches);

            Console.WriteLine("The Sum of Scores of the Player");
            int Sum = PlayerScores.Sum();
            Console.WriteLine(Sum);
            return no_of_matches;
            

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the No of Matches");
            try
            {
                int no_of_matches = Convert.ToInt32(Console.ReadLine());
                PointsCalculation(no_of_matches);

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Enter the Valid Number");
            }

        }
    }
}

