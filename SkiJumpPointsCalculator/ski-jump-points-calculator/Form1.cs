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
        public static float StartingLevelInBeginning = 0;
        List<SkiJumper> skiJumpers = new List<SkiJumper>();
        //List<CurrentStandings> standings = new List<CurrentStandings>(); // somewhere 

        public SkiJumpMainForm()
        {
            InitializeComponent();
                                 // jumping order, name, points
            skiJumpers.Add(new SkiJumper(1, "Adam Malycz", 0));
            skiJumpers.Add(new SkiJumper(2, "Martin Schmitdt", 0));
            skiJumpers.Add(new SkiJumper(3, "Jari Puikkonen", 0));
            skiJumpers.Add(new SkiJumper(4, "Matti Hautamäki", 0));
            skiJumpers.Add(new SkiJumper(5, "Noriaki Kasai", 0));

            competitorNameComboBox.DataSource = skiJumpers;
            competitorNameComboBox.DisplayMember = "competitorName";
        }

        private void SkiJumpMainForm_Load(object sender, EventArgs e)
        {
            hillSizeTextBox.Focus();// hill size
        }
        
        private void nextCompetitorButton_Click(object sender, EventArgs e)
        {
            decimal parsevalue;
            if (!decimal.TryParse(pointsTextBox.Text, out parsevalue))
            {
                pointsTextBox.Text = "0"; // Also fucntions as: competitor is not jumping and gets 0 points here
            }
            var points = decimal.Parse(pointsTextBox.Text);
            
            string[] args = Environment.GetCommandLineArgs(); // show in console points is set ok
            foreach (string arg in args)
            {
                Console.WriteLine("{0}", skiJumpers[competitorNameComboBox.SelectedIndex].CompetitorName);
                Console.WriteLine("{0}", skiJumpers[competitorNameComboBox.SelectedIndex].Points);
                Console.WriteLine("{0}", skiJumpers[competitorNameComboBox.SelectedIndex].Id);
                Console.WriteLine();
            }
            currentStandingsListView.Text = null;
            
            skiJumpers = skiJumpers.OrderByDescending(x => x.Points).ToList();
            int p = 1;

            foreach (var skijumper in skiJumpers)
            {
                currentStandingsListView.Text += p + ". " + skijumper.CompetitorName  + "\t" + skijumper.Points + " Points\n";
                p++;
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
            // roundGroupBox.Text = "Round 2";

        }

        private void calculatePointsButton_Click(object sender, EventArgs e)
        {
            decimal parsevalue;
            if (!decimal.TryParse(jumpLengthTextBox.Text, out parsevalue))
            {
                jumpLengthTextBox.Text = "0"; // Also fucntions as: competitor is not jumping and gets 0 points here
            }
            var points = decimal.Parse(jumpLengthTextBox.Text);

            decimal juryPoints = 0;
            decimal lengthPoints = 0;
            decimal gatePoints = 0;
            decimal windPoints = 0;
            decimal jumpTotalPoints = 0;
            // var currentJumper = competitorNameComboBox.SelectedIndex;
            //var currentJumper = SkiJumpMainForm.competitorNameComboBox.SelectedIndex;

            juryPoints = PointsCalculator.CalcJuryPoints(jury1PointsComboBox.Value, jury2PointsComboBox.Value, jury3PointsComboBox.Value,
               jury4PointsComboBox.Value, jury5PointsComboBox.Value);
            lengthPoints = PointsCalculator.CalcLengthPoints(hillSizeTextBox.Text, jumpLengthTextBox.Text);
            gatePoints = PointsCalculator.CalcStartGatePoints(startGateComboBox.Text);
            windPoints = PointsCalculator.CalcWindPoints(windMeter1.Value, windMeter2.Value, windMeter3.Value, windMeter4.Value, windMeter5.Value, hillSizeTextBox.Text);
            jumpTotalPoints = juryPoints + lengthPoints + gatePoints + windPoints;
            
            pointsTextBox.AppendText("" + jumpTotalPoints);
            skiJumpers[competitorNameComboBox.SelectedIndex].Points = jumpTotalPoints; // Add points on competitor
        }
        
        private void jumpLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal parsedValue;

            if (!decimal.TryParse(jumpLengthTextBox.Text, out parsedValue))
            {
                jumpLengthTextBox.Text = "";
            }
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
        
        private void roundGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void currentStandingsListView_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
