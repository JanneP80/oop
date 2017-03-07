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
    //public float startingLevelInBeginning =0 ;

    public partial class SkiJumpMainForm : Form
    {
        public static float startingLevelInBeginning = 0;
        //private string jumpLength;
        List<SkiJumper> skiJumpers = new List<SkiJumper>();
        //List<CurrentStandings> standings = new List<CurrentStandings>(); // ei tarvitse

        public SkiJumpMainForm()
        {
            InitializeComponent();
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
            // int HillSize = 0;

            // int n = 0;
            // string jumpLenght;

            skiJumpers.Add(new SkiJumper(1, "Adam Malycz", 0));
            skiJumpers.Add(new SkiJumper(2, "Martin Schmitdt", 0));
            skiJumpers.Add(new SkiJumper(3, "Jari Puikkonen", 0));
            skiJumpers.Add(new SkiJumper(4, "Matti Hautamäki", 0));
            skiJumpers.Add(new SkiJumper(5, "Noriaki Kasai", 0));

            competitorNameComboBox.DataSource = skiJumpers;
            competitorNameComboBox.DisplayMember = "competitorName";

            jury1comboBox.Items.AddRange(juryPoints);
            jury2ComboBox.Items.AddRange(juryPoints);
            jury3comboBox.Items.AddRange(juryPoints);
            jury4comboBox.Items.AddRange(juryPoints);
            jury5comboBox.Items.AddRange(juryPoints);
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
            /* if (jumpLengthTextBox.Text != null)
            {
                int x = int.Parse(jumpLengthTextBox.Text);
            }
            else
            { //Value is null 
            }
            */
            PointsCalculator.gatherAllDataFromFields(jumpLength3);

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

            var value = float.Parse(pointsTextBox.Text);
            skiJumpers[competitorNameComboBox.SelectedIndex].Points = value; // Add points on competitor

            // TODO!!! listbox2 näyttää tilanteen
            // Todo!! kutsu tässä CurrentStandings -> standingsListView

            //listBox2.Items.Insert(skiJumpers[comboBox1.SelectedIndex].Points);
            // listBox2.DataSource = skiJumpers[comboBox1.SelectedIndex].Points;
            //standingsListBox.Refresh();

            string[] args = Environment.GetCommandLineArgs(); // show in console points is set ok
            foreach (string arg in args)
            {
                Console.WriteLine("{0}", skiJumpers[competitorNameComboBox.SelectedIndex].CompetitorName);
                Console.WriteLine("{0}", skiJumpers[competitorNameComboBox.SelectedIndex].Points);
                Console.WriteLine("{0}", skiJumpers[competitorNameComboBox.SelectedIndex].Id);
                Console.WriteLine();
            }

            //clearing for next jump
            jumpLengthTextBox.Text = "";
            pointsTextBox.Text = "";
            jury1comboBox.Text = null;
            jury2ComboBox.Text = null;
            jury3comboBox.Text = null;
            jury4comboBox.Text = null;
            jury5comboBox.Text = null;

            competitorNameComboBox.Focus(); // ready for next jumper
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public static void startGateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void standingsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
