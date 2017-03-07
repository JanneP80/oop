using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkiJumpScoreBoard
{
    // public float startingLevelInBeginning =0 ;

    public partial class SkiJumpMainForm : Form
    {
        private float startingLevelInBeginning = 0;
        //private string jumpLength;
        List<SkiJumper> skiJumpers = new List<SkiJumper>();
        //List<CurrentStandings> standings = new List<CurrentStandings>(); // ei tarvitse

        public SkiJumpMainForm()
        {
            InitializeComponent();
            
            //List<SkiJumper> skiJumpers = new List<SkiJumper>();
            // List<float> juryPoints = new List<float>()
            object[] juryPoints =
            {
                0,
                0.5F,
                1,
                1.5F,
                2,
                2.5F,
                3,
                3.5F,
                4,
                4.5F,
                5,
                5.5F,
                6,
                6.5F,
                7,
                7.5F,
                8,
                8.5F,
                9,
                9.5F,
                10,
                10.5F,
                11,
                11.5F,
                12,
                12.5F,
                13,
                13.5F,
                14,
                14.5F,
                15,
                15.5F,
                16,
                16.5F,
                17,
                17.5F,
                18,
                18.5F,
                19,
                19.5F,
                20
            };
            int HillSize = 0;

            // int n = 0;
            // string jumpLenght;

            skiJumpers.Add(new SkiJumper(1, "Adam Malycz", 0));
            skiJumpers.Add(new SkiJumper(2, "Martin Schmitdt", 0));
            skiJumpers.Add(new SkiJumper(3, "Jari Puikkonen", 0));
            skiJumpers.Add(new SkiJumper(4, "Matti Hautamäki", 0));
            skiJumpers.Add(new SkiJumper(5, "Noriaki Kasai", 0));

            competitorNameComboBox.DataSource = skiJumpers;
            competitorNameComboBox.DisplayMember = "competitorName";

            // var currentJumper = comboBox1.SelectedIndex;

            // if (jumpLenght < 0)
            // {
            //   textBox1.AppendText("Please insert jump length");
            //}

            jury1comboBox.Items.AddRange(juryPoints);
            jury2ComboBox.Items.AddRange(juryPoints);
            jury3comboBox.Items.AddRange(juryPoints);
            jury4comboBox.Items.AddRange(juryPoints);
            jury5comboBox.Items.AddRange(juryPoints);
            /*
            comboBox3.DataSource = juryPoints;
            comboBox4.DataSource = juryPoints;
            comboBox5.DataSource = juryPoints;
            comboBox6.DataSource = juryPoints;
            */
            // var tempvar = Convert.ToInt32(textBox1.Text);
            //skiJumpers[currentJumper].Points = Convert.ToInt32(textBox1.Text);
            //skiJumpers[currentJumper].Points = textBox1.Text;
            /*
            if (skiJumpers[currentJumper].Points < 1)
            {
                textBox1.AppendText("Please insert number greater than one. ");
                //textBox1.
            } 
            else if (skiJumpers[currentJumper].Points > 1)
            {
                //skiJumpers. textBox1.Text;
            }*/
            //int ii = int.Parse(textBox3.Text);
            //skiJumpers[comboBox1.SelectedIndex].Points = ii;

            // TODO!!! fix text box3 -> points
            //if textBox3_TextChanged() == true
            /*
            int value;

            if (int.TryParse(textBox2.Text, out value)) 
            {
                //parsing successful 
                skiJumpers[comboBox1.SelectedIndex].Points = value;
                listBox2.Refresh();
            }
            else
            {
                //parsing failed. 
            }
            */
            //skiJumpers[comboBox1.SelectedIndex].Points = Convert.ToInt32(textBox2.Text);
            //(int.TryParse(textBox2.Text));
        }

        private void SkiJumpMainForm_Load(object sender, EventArgs e)
        {
            hillSizeTextBox.Focus();// hill size
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;

            if (!double.TryParse(jumpLengthTextBox.Text, out parsedValue))
            {
                jumpLengthTextBox.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jumpLength3 = (Convert.ToInt32(jumpLengthTextBox.Text));

            //TODO!!! tyhjä klikkaus pois

            /*
            if (comboBox1.SelectedItem != null)
            {
                int x = int.Parse(comboBox1.SelectedItem.ToString());
            }
            else
            { //Value is null 
            }*/

            //var jumpLength = 123;

            
            //TODO!!! korjaa sopimaan omaan
            string[] tempArray = jumpLengthTextBox.Lines;

            // Loop through the array and send the contents of the array to debug window.
            for (int counter = 0; counter < tempArray.Length; counter++)
            {
                System.Diagnostics.Debug.WriteLine(tempArray[counter]);

            }
            
            string[] args = Environment.GetCommandLineArgs();
            foreach (string arg in args)
            {
                Console.WriteLine("Checking calculations: ");
                // do stuff
            }

            List<float> WindList = new List<float>(); // windmeter list

            try
            {
                string[] txtNumbers = WindMeterTextBox2.Text.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    float number = float.Parse(nbr);
                    WindList.Add(number);
                }
            }
            catch (Exception exce)
            {
            }
            float windSumAvg =0;
            for (int i=0; i < 5; i++)
            {
                windSumAvg  += WindList[i];
            }

            windSumAvg  = (windSumAvg  / 5);
            //rounding
            windSumAvg = windSumAvg * 2;
            Math.Round(windSumAvg, MidpointRounding.AwayFromZero);
            windSumAvg = windSumAvg / 2;

            string[] args2 = Environment.GetCommandLineArgs();
            foreach (string arg in args2)
            {
                //Console.WriteLine("wind {0}", WindList[2]);
                Console.WriteLine("wind {0}", windSumAvg );
            }

            
            List<float> juryPoints = new List<float>(); // jury points list x5 for each jury member

            try
            {
                string[] txtNumbers = jury1comboBox.Text.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    float number = float.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
            }
            try
            {
                string[] txtNumbers = jury2ComboBox.Text.Split('\n'); // Cap C
                foreach (string nbr in txtNumbers)
                {
                    float number = float.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
            }
            try
            {
                string[] txtNumbers = jury3comboBox.Text.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    float number = float.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
            }
            try
            {
                string[] txtNumbers = jury4comboBox.Text.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    float number = float.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
            }
            try
            {
                string[] txtNumbers = jury5comboBox.Text.Split('\n');
                foreach (string nbr in txtNumbers)
                {
                    float number = float.Parse(nbr);
                    juryPoints.Add(number);
                }
            }
            catch (Exception exce)
            {
            }
            
            //  Array ja for Array max ja array min vähenentään jurypointsista
            // Array ja sort ja ottaa kolme keskimmäistä // toimii
            
            var currentJumper = competitorNameComboBox.SelectedIndex;

            calculatePoints(currentJumper, jumpLength3, windSumAvg , juryPoints);
        }

        private void calculatePoints(object p, Int32 jumpLength2, float sumAvg, List<float> juryPoints)
        {
            // calculate jump length +judges +wind + gate = sum
            // skiJumpers[currentJumper].Points =
            var startingLevel = float.Parse(startGateComboBox.Text);
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
            
            var points = 0 + (double) + jurypoints;
            var hillSize = Convert.ToInt32(hillSizeTextBox.Text);
            
            if (startingLevel < startingLevelInBeginning) // staring level compensator
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

            if (startingLevel > startingLevelInBeginning) // staring level compensator
            {
                // jos lähtee ylempää vähennetään pituusmetreinä 1m = 5m eli 5x lavanmuutos
                // näin voi laittaa kertoimeksi -5, jolloin menee suoraan syötetyllä lavamuutoksella
                var levelEffect = startingLevel * -5;
                points += (levelEffect*1.8);

                string[] args3 = Environment.GetCommandLineArgs();
                foreach (string arg in args3)
                {
                    Console.WriteLine("starting level: {0}", levelEffect);
                    //Console.WriteLine("jury 2 {1} and 3 {2}:", juryPoints[2], juryPoints[3]);
                }
            }
            

            if (jumpLength2 > Convert.ToInt32(hillSizeTextBox.Text)) // hill size =textbox3
            {
                //points += 60;
                points += 60+ ((jumpLength2-hillSize) * 1.8); // jump over K
                
            }
            else // how about under k-point
            {
                points += 60 - ((hillSize-jumpLength2) * 1.8);
            }
            points += (sumAvg * (hillSize-36)/20); // K-point effects on "36" somehow // wind
            string[] args4 = Environment.GetCommandLineArgs();
            foreach (string arg in args4)
            {
                Console.WriteLine(" wind points: {0}", ((sumAvg * (hillSize - 36) / 20)*1.8));
                
            }
            pointsTextBox.AppendText("" + points);


            //points += sumAvg * (hillSize);
            //return points;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox1.DataSource = juryPoints;
            float parsedValue;

            if (!float.TryParse(jury1comboBox.Text, out parsedValue))
            {
                jury1comboBox.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) // points after calculation
        {
            double parsedValue;

            if (!double.TryParse(hillSizeTextBox.Text, out parsedValue))
            {
                hillSizeTextBox.Text = "";
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;

            if (!double.TryParse(pointsTextBox.Text, out parsedValue))
            {
                pointsTextBox.Text = "";
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // sending information forward
            
            var value= float.Parse(pointsTextBox.Text);

            skiJumpers[competitorNameComboBox.SelectedIndex].Points = value;
            this.standingsListBox.DisplayMember = (skiJumpers[competitorNameComboBox.SelectedIndex].CompetitorName);

            // TODO!!! listbox2 näyttää tilanteen
            //listBox2.Items.Insert(skiJumpers[comboBox1.SelectedIndex].Points);
           // listBox2.DataSource = skiJumpers[comboBox1.SelectedIndex].Points;
            standingsListBox.Refresh();
            // textBox4.AppendText("{0}", skiJumpers[comboBox1.SelectedIndex].CompetitorName);
            /*
            if (int.TryParse(textBox2.Text)) // points
            {
                //parsing successful 
                skiJumpers[comboBox1.SelectedIndex].Points = value;
                listBox2.Refresh();
            }
            else
            {
            
            //parsing failed. 
        }*/
            string[] args = Environment.GetCommandLineArgs();

            foreach (string arg in args)
            {
                Console.WriteLine("{0}", skiJumpers[competitorNameComboBox.SelectedIndex].CompetitorName);
                Console.WriteLine("{0}", skiJumpers[competitorNameComboBox.SelectedIndex].Points);
                Console.WriteLine("{0}", skiJumpers[competitorNameComboBox.SelectedIndex].Id);
                Console.WriteLine();
                // do stuff
            }

            //clearing for next jump
            jumpLengthTextBox.Text = "";
            pointsTextBox.Text = "";
            jury1comboBox.Text = null;
            jury2ComboBox.Text = null;
            jury3comboBox.Text = null;
            jury4comboBox.Text = null;
            jury5comboBox.Text = null;

            competitorNameComboBox.Focus();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void startGateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*
public class Int32TextBox : TextBox
{
protected override void OnKeyPress(KeyPressEventArgs e)
{
base.OnKeyPress(e);

NumberFormatInfo fi = CultureInfo.CurrentCulture.NumberFormat;

string c = e.KeyChar.ToString();
if (char.IsDigit(c, 0))
return;

if ((SelectionStart == 0) && (c.Equals(fi.NegativeSign)))
return;

// copy/paste
if ((((int)e.KeyChar == 22) || ((int)e.KeyChar == 3))
&& ((ModifierKeys & Keys.Control) == Keys.Control))
return;

if (e.KeyChar == '\b')
return;

e.Handled = true;
}
}

protected override void WndProc(ref System.Windows.Forms.Message m)
{
const int WM_PASTE = 0x0302;
if (m.Msg == WM_PASTE)
{
string text = Clipboard.GetText();
if (string.IsNullOrEmpty(text))
return;

if ((text.IndexOf('+') >= 0) && (SelectionStart != 0))
return;

int i;
if (!int.TryParse(text, out i)) // change this for other integer types
return;

if ((i < 0) && (SelectionStart != 0))
return;
}
base.WndProc(ref m);
}*/
    }

}
