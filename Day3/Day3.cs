using System.Linq;
using System.Collections.Generic;
using System;

namespace AOC2021
{
    public static class Day3
    {
        public static string Part1()
        {
            List<string> input = FileReader.ReadFile(@"Day3\day3Input.txt").ToList();

            string gammaRate = "";
            string epsilonRate = "";
            // Loop through each Column
            for (int i = 0; i < 12; i++)
            {
                var oneCount = 0;
                var zeroCount = 0;
                // Loop through each row
                foreach (var item in input)
                {
                    var lookup = item[i]; //Get index i from that row
                    if (lookup == '1')
                        oneCount++;
                    if (lookup == '0')
                        zeroCount++;
                }
                if (oneCount > zeroCount)
                {
                    gammaRate += "1";
                    epsilonRate += "0";
                }

                if (zeroCount > oneCount)
                {
                    gammaRate += "0";
                    epsilonRate += "1";
                }
            }
            var gammaRateInt = Convert.ToInt32(gammaRate, 2);
            var epsilonRateInt = Convert.ToInt32(epsilonRate, 2);
            return (gammaRateInt * epsilonRateInt).ToString();
        }
    }
}