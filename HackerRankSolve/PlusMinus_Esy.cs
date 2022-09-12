using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace HackerRankSolve
{
    // SOLVED
    public class PlusMinus_Esy
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }

    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            double zeroCount = 0;
            double posCount = 0;
            double negCount = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == 0)
                    zeroCount++;
                if (arr[i] > 0)
                    posCount++;
                if (arr[i] < 0)
                    negCount++;

            }

            Console.WriteLine((posCount / arr.Count).ToString("N6"));
            Console.WriteLine((negCount / arr.Count).ToString("N6"));
            Console.WriteLine((zeroCount / arr.Count).ToString("N6"));
        }

    }


}
