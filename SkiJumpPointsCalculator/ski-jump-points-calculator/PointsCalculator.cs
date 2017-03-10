using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SkiJumpPointsCalculator
{
    internal class PointsCalculator
    {
        internal static decimal CalcWindPoints(decimal wind1, decimal wind2, decimal wind3, decimal wind4, decimal wind5, decimal text2)
        {
            var hillSize = text2;
            List<decimal> windList = new List<decimal>() { wind1, wind2, wind3, wind4, wind5 }; // windmeter list
            decimal windSumAvg = windList.Sum();

            windSumAvg = (windSumAvg / 5); // non-rounded

            string[] args2 = Environment.GetCommandLineArgs();
            foreach (string arg in args2)
            {
                Console.WriteLine("non rounded wind {0}, ", windSumAvg);
            }

            //rounding wind
            var windSumAvg2 = (windSumAvg * (hillSize - 36) / 20);
            windSumAvg2 = windSumAvg2 * 2;
            windSumAvg2 = (Math.Round(windSumAvg2, MidpointRounding.AwayFromZero));
            windSumAvg2 = windSumAvg2 / 2;
            windSumAvg2 = (windSumAvg2 * (decimal)1.8);

            // K-point effects on "36" somehow // wind points
            string[] args4 = Environment.GetCommandLineArgs();
            foreach (string arg in args4)
            {
                Console.WriteLine(" wind points: {0}", windSumAvg2);
            }
            return windSumAvg2;
        }

        internal static decimal CalcStartGatePoints(decimal text)
        {
            // var startingLevel = decimal.Parse(text);
            var startingLevel = text;
            decimal levelEffect = 0;
            var points = 0 + levelEffect;

            // jos lähtee ylempää vähennetään pituusmetreinä 1m = 5m eli 5x lavanmuutos
            // näin voi laittaa kertoimeksi -5, jolloin menee suoraan syötetyllä lavamuutoksella

            levelEffect = startingLevel * -5;
            points += (levelEffect * (decimal)1.8);

            string[] args3 = Environment.GetCommandLineArgs();
            foreach (string arg in args3)
            {
                Console.WriteLine("starting level: {0}", (levelEffect * (decimal)1.8));
            }

            return points;
        }

        internal static decimal CalcLengthPoints(decimal hillSizeTextBox, decimal jumpLengthTextBox)
        {
            // var hillSize = Convert.ToDecimal(hillSizeTextBox);
            var hillSize = hillSizeTextBox;
            var jumpLength2 = jumpLengthTextBox;

            decimal points = 0;

            if (jumpLength2 > hillSize) // hill size =textbox3
            {
                points += 60 + ((jumpLength2 - hillSize) * (decimal)1.8); // jump over K
                                                                          //
                string[] args5 = Environment.GetCommandLineArgs();
                foreach (string arg in args5)
                {
                    Console.WriteLine(" jump points: {0}", points);
                }
                // not even nessessary to do this comparision. just calc directly always compared to 0 start level

            }
            else // how about under k-point
            {
                points += 60 - ((hillSize - jumpLength2) * (decimal)1.8);
            }
            return points;
        }

        internal static decimal CalcJuryPoints(decimal judge1, decimal judge2, decimal judge3, decimal judge4, decimal judge5)
        {
            List<decimal> juryPoints = new List<decimal>() { judge1, judge2, judge3, judge4, judge5 }; // jury points list x5 for each jury member

            juryPoints.Sort((x, y) => x.CompareTo(y));
            var jurypoints = juryPoints[1] + juryPoints[2] + juryPoints[3];

            string[] args2 = Environment.GetCommandLineArgs();

            foreach (string arg in args2)
            {
                Console.WriteLine("jury points, {0}", jurypoints);
            }
            return jurypoints;
        }
    }
}