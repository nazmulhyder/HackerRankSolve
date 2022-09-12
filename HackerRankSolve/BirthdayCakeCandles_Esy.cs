﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolve
{
    public class BirthdayCakeCandles_Esy
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = Result.birthdayCakeCandles(candles);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

    class Result
    {

        /*
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */

        public static int birthdayCakeCandles(List<int> candles)
        {
            int maxCandle = candles.Max();
            int count = 0;
            foreach (var item in candles)
            {
                if (item.Equals(maxCandle))
                {
                    count++;
                }
            }

            return count;
        }

    }
}
