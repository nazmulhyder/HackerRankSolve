using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolve
{
    public class TimeConversion_Esy
    {
        public static void Main(string[] args)
        {
            string ss = Console.ReadLine();
            string result = Result.timeConversation(ss);
            Console.WriteLine(result);
        }
    }

    public static class Result
    {
        public static string timeConversation(string timeStr)
        {
            //hour :: split string and take the first index 
            int hh = Int32.Parse(timeStr.Split(":")[0]);
            //StringBuilder convertedDatetime = new StringBuilder();
            string convertedDatetime = "";
            //INPUT SAMPLE : "12:01:00AM"
            //OUTPUT SAMPLE : "12:01:00"

            if (timeStr[8] == 'A')
            {
                if (hh.Equals(12))
                {
                    //Console.Write("00");
                    convertedDatetime = "00";
                    for (int i = 2; i <=7; i++)
                    {
                        //Console.Write(timeStr[i]);
                        convertedDatetime += timeStr[i];
                    }
                }
                else
                {
                    for (int i = 0; i <= 7; i++)
                    {
                        //Console.Write(timeStr[i]);
                        convertedDatetime += timeStr[i];
                    }
                }

            }

            if (timeStr[8] == 'P')
            {
                if (hh.Equals(12))
                {
                    for (int i = 0; i <= 7; i++)
                    {
                        //Console.Write(timeStr[i]);
                        convertedDatetime += timeStr[i];
                    }
                }
                else
                {
                    hh = 12 + hh;
                    //Console.Write(hh);
                    convertedDatetime = Convert.ToString(hh);
                    for (int i = 2; i <= 7; i++)
                    {
                        //Console.Write(timeStr[i]);
                        convertedDatetime += timeStr[i];
                    }
                }

            }

            return convertedDatetime;
        }
    }
}
