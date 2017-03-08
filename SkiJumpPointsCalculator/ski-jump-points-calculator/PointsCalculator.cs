using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SkiJumpPointsCalculator
{
    internal class PointsCalculator
    {
        public static void gatherAllDataFromFields()
        {
            //var jumpLength3 = (Convert.ToInt32(SkiJumpMainForm.jumpLengthTextBox.Text));
            //TODO!!! tyhjä klikkaus pois
            /* if (jumpLengthTextBox.Text != null)
            {
                int x = int.Parse(jumpLengthTextBox.Text);
            }
            else
            { //Value is null 
            }
            */
            string[] args = Environment.GetCommandLineArgs();
            foreach (string arg in args)
            {
                Console.WriteLine("Checking calculations: ");
            }

            /*
            List<float> windList = new List<float>(); // windmeter list
            try
            {
                string[] txtNumbers = SkiJumpMainForm.WindMeterTextBox2.Text.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    float number = float.Parse(nbr);
                    windList.Add(number);
                }
            }
            catch (Exception exce)
            {
                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("insert number: {0}", exce);
                }
            }
            float windSumAvg = windList.Sum();
            /*
            float windSumAvg = 0;
            for (int i = 0; i <= 4; i++)
            {
                windSumAvg += windList[i];
            }
            */
            /*
            windSumAvg = (windSumAvg / 5); // non-rounded

            string[] args2 = Environment.GetCommandLineArgs();
            foreach (string arg in args2)
            {
                Console.WriteLine("non rounded wind {0}, ", windSumAvg);
            }
            /*
            /*
            List<float> juryPoints = new List<float>(); // jury points list x5 for each jury member

            try
            {
                string[] txtNumbers = SkiJumpMainForm.jury1comboBox.Text.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    float number = float.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("insert number: {0}", exce);
                }
            }
            try
            {
                string[] txtNumbers = SkiJumpMainForm.jury2ComboBox.Text.Split('\n'); // Cap C
                foreach (string nbr in txtNumbers)
                {
                    float number = float.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("insert number: {0}", exce);
                }
            }
            try
            {
                string[] txtNumbers = SkiJumpMainForm.jury3comboBox.Text.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    float number = float.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("insert number: {0}", exce);
                }
            }
            try
            {
                string[] txtNumbers = SkiJumpMainForm.jury4comboBox.Text.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    float number = float.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("insert number: {0}", exce);
                }
            }
            try
            {
                string[] txtNumbers = SkiJumpMainForm.jury5comboBox.Text.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    float number = float.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("insert number: {0}", exce);
                }
            }
            */
            //  Array ja for Array max ja array min vähenentään jurypointsista
            // Array ja sort ja ottaa kolme keskimmäistä // toimii

           // var currentJumper = SkiJumpMainForm.competitorNameComboBox.SelectedIndex;

            //calculatePoints(currentJumper, jumpLength3, windSumAvg, juryPoints);
        }

        internal static decimal CalcWindPoints(string text, string text2)
        {
            var hillSize = Convert.ToDecimal(text2);

            List<decimal> windList = new List<decimal>(); // windmeter list
            try
            {
                string[] txtNumbers = text.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    decimal number = decimal.Parse(nbr);
                    windList.Add(number);
                }
            }
            catch (Exception exce)
            {
                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("insert number: {0}", exce);
                }
            }
            decimal windSumAvg = windList.Sum();
            /*
            float windSumAvg = 0;
            for (int i = 0; i <= 4; i++)
            {
                windSumAvg += windList[i];
            }
            */
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
            windSumAvg2 = (windSumAvg2 * (decimal) 1.8);

            // K-point effects on "36" somehow // wind points
            string[] args4 = Environment.GetCommandLineArgs();
            foreach (string arg in args4)
            {
                Console.WriteLine(" wind points: {0}", windSumAvg2);
            }
            return windSumAvg2;
        }

        internal static decimal CalcStartGatePoints(string text)
        {
            var startingLevel = decimal.Parse(text);
            decimal levelEffect = 0;
            var points = 0 + (decimal) +levelEffect;

            // jos lähtee ylempää vähennetään pituusmetreinä 1m = 5m eli 5x lavanmuutos
            // näin voi laittaa kertoimeksi -5, jolloin menee suoraan syötetyllä lavamuutoksella

            levelEffect = startingLevel * -5;
            points += (levelEffect * (decimal) 1.8);

            string[] args3 = Environment.GetCommandLineArgs();
            foreach (string arg in args3)
            {
                Console.WriteLine("starting level: {0}", (levelEffect * (decimal)1.8));
            }

            return points;
        }

        internal static decimal CalcLengthPoints(string hillSizeTextBox, string jumpLengthTextBox)
        {
            var hillSize = Convert.ToDecimal(hillSizeTextBox);
            var jumpLength2 = Convert.ToDecimal(jumpLengthTextBox);

            decimal points = 0;

            if (jumpLength2 > hillSize) // hill size =textbox3
            {
                points += 60 + ((jumpLength2 - hillSize) * (decimal) 1.8); // jump over K
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
                points += 60 - ((hillSize - jumpLength2) * (decimal) 1.8);
            }
            return points;
        }

        internal static decimal CalcJuryPoints(string text1, string text2, string text3, string text4, string text5)
        {
            List<decimal> juryPoints = new List<decimal>(); // jury points list x5 for each jury member

            try
            {
                string[] txtNumbers = text1.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    decimal number = decimal.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("insert number: {0}", exce);
                }
            }
            try
            {
                string[] txtNumbers = text2.Split('\n'); // Cap C
                foreach (string nbr in txtNumbers)
                {
                    decimal number = decimal.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("insert number: {0}", exce);
                }
            }
            try
            {
                string[] txtNumbers = text3.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    decimal number = decimal.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("insert number: {0}", exce);
                }
            }
            try
            {
                string[] txtNumbers = text4.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    decimal number = decimal.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("insert number: {0}", exce);
                }
            }
            try
            {
                string[] txtNumbers = text5.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    decimal number = decimal.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("insert number: {0}", exce);
                }
            }
            juryPoints.Sort((x, y) => x.CompareTo(y));
            var jurypoints = juryPoints[1] + juryPoints[2] + juryPoints[3];

            string[] args2 = Environment.GetCommandLineArgs();

            foreach (string arg in args2)
            {
                Console.WriteLine("jury points, {0}", jurypoints);
            }
            return jurypoints;
        }
        
        public static void calculatePoints(object p, Int32 jumpLength2, float sumAvg, List<float> juryPoints)
        {
            
        }
    }
}