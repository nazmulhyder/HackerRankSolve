using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolve
{
    public class Staircase_Esy
    {
        /* ======print======
         *    #
         *   ##
         *  ###
         */
       public static void Main(string[] args)
       {

           Console.WriteLine("Enter the N");
           int n = Convert.ToInt16(Console.ReadLine());
           Result.staircase(n);
           
       }

       class Result
       {
           public static void staircase(int n)
           {
               for (int i = n; i > 0; i--)
               {
                   for (int j = 1; j <= n; j++)
                   {
                       Console.Write(j >= i ? "#" : " ");
                   }
                   Console.WriteLine("");
               }
            }
        }
    }
}
