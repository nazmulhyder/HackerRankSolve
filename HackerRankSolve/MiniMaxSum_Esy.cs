using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolve
{
    public  class MiniMaxSum_Esy
    {
        public static void Main()
        {
            List<int> aa = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aa => Convert.ToInt32(aa)).ToList();
            Result.miniMaxSum(aa);
        }
    }
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            List<long> tmpList  = new List<long>();

            for (int i = 0; i < arr.Count; i++)
            {
                long tmpSum = 0;
                for (int j = 0; j < arr.Count; j++)
                {
                    if (j!=i)
                    {
                        tmpSum+= arr[j];
                    }
                }

                tmpList.Add(tmpSum);
            }


            Console.WriteLine(tmpList.Min()+" " +tmpList.Max());
        }

    }
}
