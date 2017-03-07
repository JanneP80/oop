using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiJumpScoreBoard
{

    class PointsCalculator
    {
        public static void gatherAllDataFromFields(Int32 jumpLength3)
        {

            string[] args = Environment.GetCommandLineArgs();
            foreach (string arg in args)
            {
                Console.WriteLine("Checking calculations: ");
            }


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
            windSumAvg = (windSumAvg / 5); // non-rounded

            string[] args2 = Environment.GetCommandLineArgs();
            foreach (string arg in args2)
            {
                Console.WriteLine("non rounded wind {0}, ", windSumAvg);
            }

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

            //  Array ja for Array max ja array min vähenentään jurypointsista
            // Array ja sort ja ottaa kolme keskimmäistä // toimii

            var currentJumper = SkiJumpMainForm.competitorNameComboBox.SelectedIndex;

            calculatePoints(currentJumper, jumpLength3, windSumAvg, juryPoints);
        }

        public static void calculatePoints(object p, Int32 jumpLength2, float sumAvg, List<float> juryPoints)
        {
            // calculate jump length +judges +wind + gate = sum
            // skiJumpers[currentJumper].Points =
            var startingLevel = float.Parse(SkiJumpMainForm.startGateComboBox.Text);
            // Tuulen voimakkuuden keskiarvo x (K - piste - 36) / 20
            //var _jurypoints;

            juryPoints.Sort((x, y) => x.CompareTo(y));
            var jurypoints = juryPoints[1] + juryPoints[2] + juryPoints[3];

            string[] args2 = Environment.GetCommandLineArgs();

            foreach (string arg in args2)
            {
                // Console.WriteLine("wind {0}", WindList[2]);
                Console.WriteLine("jury points, {0}", jurypoints);
                // do stuff
            }

            var points = 0 + (double)+jurypoints;
            var hillSize = Convert.ToInt32(SkiJumpMainForm.hillSizeTextBox.Text);

            if (startingLevel < SkiJumpMainForm.startingLevelInBeginning) // staring level compensator
            {
                // jos lähtee ylempää vähennetään pituusmetreinä 1m = 5m eli 5x lavanmuutos
                // näin voi laittaa kertoimeksi -5, jolloin menee suoraan syötetyllä lavamuutoksella
                var levelEffect = startingLevel * -5;
                points += levelEffect;

                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("starting level: {0}", levelEffect);
                    //Console.WriteLine("jury 2 {1} and 3 {2}:", juryPoints[2], juryPoints[3]);
                }
            }

            if (startingLevel > SkiJumpMainForm.startingLevelInBeginning) // staring level compensator
            {
                // jos lähtee ylempää vähennetään pituusmetreinä 1m = 5m eli 5x lavanmuutos
                // näin voi laittaa kertoimeksi -5, jolloin menee suoraan syötetyllä lavamuutoksella
                var levelEffect = startingLevel * -5;
                points += (levelEffect * 1.8);

                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("starting level: {0}", (levelEffect * 1.8));
                    //Console.WriteLine("jury 2 {1} and 3 {2}:", juryPoints[2], juryPoints[3]);
                }
            }


            if (jumpLength2 > Convert.ToInt32(SkiJumpMainForm.hillSizeTextBox.Text)) // hill size =textbox3
            {
                //points += 60;

                points += 60 + ((jumpLength2 - hillSize) * 1.8); // jump over K
                                                                 //
                string[] args5 = Environment.GetCommandLineArgs();
                foreach (string arg in args5)
                {
                    Console.WriteLine(" jump points: {0}", points);
                }

                //

            }
            else // how about under k-point
            {
                points += 60 - ((hillSize - jumpLength2) * 1.8);
            }

            //rounding wind
            var windSumAvg2 = (sumAvg * (hillSize - 36) / 20);
            windSumAvg2 = windSumAvg2 * 2;
            windSumAvg2 = Convert.ToSingle(Math.Round(windSumAvg2, MidpointRounding.AwayFromZero));
            windSumAvg2 = windSumAvg2 / 2;
            windSumAvg2 = Convert.ToSingle((windSumAvg2 * 1.8));

            points += windSumAvg2; // K-point effects on "36" somehow // wind points

            //
            string[] args4 = Environment.GetCommandLineArgs();
            foreach (string arg in args4)
            {
                Console.WriteLine(" wind points: {0}", windSumAvg2);

            }
            //
            SkiJumpMainForm.pointsTextBox.AppendText("" + points);

        }
    }
}
