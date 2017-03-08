using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkiJumpPointsCalculator
{
    public partial class SkiJumpMainForm : Form
    {
        public static float startingLevelInBeginning = 0;
        List<SkiJumper> skiJumpers = new List<SkiJumper>();
        //List<CurrentStandings> standings = new List<CurrentStandings>(); // ei tarvitse

        public SkiJumpMainForm()
        {
            InitializeComponent();

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

            skiJumpers.Add(new SkiJumper(1, "Adam Malycz", 0));
            skiJumpers.Add(new SkiJumper(2, "Martin Schmitdt", 0));
            skiJumpers.Add(new SkiJumper(3, "Jari Puikkonen", 0));
            skiJumpers.Add(new SkiJumper(4, "Matti Hautamäki", 0));
            skiJumpers.Add(new SkiJumper(5, "Noriaki Kasai", 0));

            competitorNameComboBox.DataSource = skiJumpers;
            competitorNameComboBox.DisplayMember = "competitorName";

            jury1PointsComboBox.Items.AddRange(juryPoints);
            jury2PointsComboBox.Items.AddRange(juryPoints);
            jury3PointsComboBox.Items.AddRange(juryPoints);
            jury4PointsComboBox.Items.AddRange(juryPoints);
            jury5PointsComboBox.Items.AddRange(juryPoints);
        }

        private void SkiJumpMainForm_Load(object sender, EventArgs e)
        {
            hillSizeTextBox.Focus();// hill size
        }



        private void nextCompetitorButton_Click(object sender, EventArgs e)
        {
            // sending information forward
            /*
            float parsevalue;
            if (!float.TryParse(pointsTextBox.Text, out parsevalue))
            {
                pointsTextBox.Text = "0"; // Also fucntions as: competitor is not jumping and gets 0 points here
            }

            var value = float.Parse(pointsTextBox.Text);
             skiJumpers[competitorNameComboBox.SelectedIndex].Points = value; // Add points on competitor
            */
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
            jury1PointsComboBox.Text = null;
            jury2PointsComboBox.Text = null;
            jury3PointsComboBox.Text = null;
            jury4PointsComboBox.Text = null;
            jury5PointsComboBox.Text = null;

            competitorNameComboBox.Focus(); // ready for next jumper
                                            // if all jumpers have jumped, then next round
                                            // ---> 
            // roundGroupBoxText.AppendText = ("Round 2");
        }

        private void calculatePointsButton_Click(object sender, EventArgs e)
        {
            //PointsCalculator.gatherAllDataFromFields();
            decimal juryPoints = 0;
            decimal lengthPoints = 0;
            decimal gatePoints = 0;
            decimal windPoints = 0;
            decimal jumpTotalPoints = 0;
            // var currentJumper = competitorNameComboBox.SelectedIndex;
            //var currentJumper = SkiJumpMainForm.competitorNameComboBox.SelectedIndex;

            juryPoints = PointsCalculator.CalcJuryPoints(jury1PointsComboBox.Text, jury2PointsComboBox.Text, jury3PointsComboBox.Text,
               jury4PointsComboBox.Text, jury5PointsComboBox.Text);
            lengthPoints = PointsCalculator.CalcLengthPoints(hillSizeTextBox.Text, jumpLengthTextBox.Text);
            gatePoints = PointsCalculator.CalcStartGatePoints(startGateComboBox.Text);
            windPoints = PointsCalculator.CalcWindPoints(windMeterTextBox2.Text, hillSizeTextBox.Text);
            jumpTotalPoints = juryPoints + lengthPoints + gatePoints + windPoints;
            
            pointsTextBox.AppendText("" + jumpTotalPoints);
            skiJumpers[competitorNameComboBox.SelectedIndex].Points = jumpTotalPoints; // Add points on competitor
        }
        

        private void startGateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal parsedValue;

            if (!decimal.TryParse(startGateComboBox.Text, out parsedValue))
            {
                startGateComboBox.Text = "";
            }
        }

        private void jumpLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal parsedValue;

            if (!decimal.TryParse(jumpLengthTextBox.Text, out parsedValue))
            {
                jumpLengthTextBox.Text = "";
            }
        }

        private void windMeterTextBox2_TextChanged(object sender, EventArgs e)
        {
            decimal parsedValue;

            if (!decimal.TryParse(windMeterTextBox2.Text, out parsedValue))
            {
                windMeterTextBox2.Text = "";
            }
        }

        private void currentStandingsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void competitorNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hillSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal parsedValue;

            if (!decimal.TryParse(hillSizeTextBox.Text, out parsedValue))
            {
                hillSizeTextBox.Text = "";
            }
        }

        private void jury1PointsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal parsedValue;

            if (!decimal.TryParse(jury1PointsComboBox.Text, out parsedValue))
            {
                jury1PointsComboBox.Text = "";
            }
        }

        private void jury2PointsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal parsedValue;

            if (!decimal.TryParse(jury2PointsComboBox.Text, out parsedValue))
            {
                jury2PointsComboBox.Text = "";
            }
        }

        private void jury3PointsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal parsedValue;

            if (!decimal.TryParse(jury3PointsComboBox.Text, out parsedValue))
            {
                jury3PointsComboBox.Text = "";
            }
        }

        private void jury4PointsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal parsedValue;

            if (!decimal.TryParse(jury4PointsComboBox.Text, out parsedValue))
            {
                jury4PointsComboBox.Text = "";
            }
        }

        private void jury5PointsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal parsedValue;

            if (!decimal.TryParse(jury5PointsComboBox.Text, out parsedValue))
            {
                jury5PointsComboBox.Text = "";
            }
        }

        private void roundGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
