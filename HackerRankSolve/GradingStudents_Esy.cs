using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolve
{
    public class GradingStudents_Esy
    {
        public static void Main(String[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades);

            Console.WriteLine("THE RESULT IS:");
            foreach (var item in result)
            {
                Console.WriteLine(item+" ");
            }
        }
    }

    public static class Result
    {
        /*
    * Complete the 'gradingStudents' function below.
    *
    * The function is expected to return an INTEGER_ARRAY.
    * The function accepts INTEGER_ARRAY grades as parameter.
    */

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();
            foreach (var item in grades)
            {
                if (item % 5 ==0)
                {
                    result.Add(item);
                }
                else
                {
                    int intHelp = 1;
                    int tmpItem = item;
                    while (tmpItem % 5 != 0)
                    {
                        if (40-tmpItem > 2)
                        {
                            result.Add(tmpItem);
                            break;
                        }

                        else
                        {
                            tmpItem = tmpItem + intHelp;
                            if (tmpItem % 5 == 0)
                            {
                                tmpItem = (tmpItem - item) < 3 ? tmpItem : item;
                                result.Add(tmpItem);
                                break;
                            }
                        }
                        

                    }

                }
            }

            return result;
        }

    }
}
