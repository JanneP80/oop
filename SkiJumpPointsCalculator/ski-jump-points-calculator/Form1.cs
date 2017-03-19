using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ski_jump_points_calculator
{
    public partial class SkiJumpMainForm : Form
    {
        public static float StartingLevelInBeginning = 0;
        List<SkiJumper> _skiJumpers = new List<SkiJumper>();
        //List<CurrentStandings> standings = new List<CurrentStandings>(); // somewhere 
        List<int> _hasJumped = new List<int>();
        List<SkiJumper> _roundOneResults = new List<SkiJumper>();

        public SkiJumpMainForm()
        {
            InitializeComponent();
            // jumping order, name, points
            _skiJumpers.Add(new SkiJumper(1, "Adam Malycz", 0));
            _skiJumpers.Add(new SkiJumper(2, "Martin Schmitdt", 0));
            _skiJumpers.Add(new SkiJumper(3, "Jari Puikkonen", 0));
            _skiJumpers.Add(new SkiJumper(4, "Matti Hautamäki", 0));
            _skiJumpers.Add(new SkiJumper(5, "Noriaki Kasai", 0));

            competitorNameComboBox.DataSource = _skiJumpers;
            competitorNameComboBox.DisplayMember = "competitorName";
        }

        private void SkiJumpMainForm_Load(object sender, EventArgs e)
        {
            hillSizeTextBox.Focus();// hill size
        }

        private void nextCompetitorButton_Click(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs(); // show in console points is set ok
            foreach (string arg in args)
            {
                Console.WriteLine("{0}", _skiJumpers[competitorNameComboBox.SelectedIndex].CompetitorName);
                Console.WriteLine("{0}", _skiJumpers[competitorNameComboBox.SelectedIndex].Points);
                Console.WriteLine("{0}", _skiJumpers[competitorNameComboBox.SelectedIndex].Id);
                Console.WriteLine();
            }
            currentStandingsListView.Text = null;

            _hasJumped.Add(_skiJumpers[competitorNameComboBox.SelectedIndex].Id);


            //clearing fields for the next jump
            jumpLengthTextBox.Value = 0;
            pointsTextBox.Value = 0;
            jury1PointsComboBox.Value = 18;
            jury2PointsComboBox.Value = 18;
            jury3PointsComboBox.Value = 18;
            jury4PointsComboBox.Value = 18;
            jury5PointsComboBox.Value = 18;

            // competitorNameComboBox.SelectedIndex = competitorNameComboBox.SelectedIndex + 1;
            // jumpLengthTextBox.Focus();
            // competitorNameComboBox.Focus(); // ready for next jumper
            // if all jumpers have jumped, then next round
            // ---> 
            // roundGroupBox.Text = "Round 2";
            if (_hasJumped.Count == _skiJumpers.Count)
            {
                if (roundGroupBox.Text == "Round 2") // end of competition
                {
                    // skiJumpers=roundOneResults + skiJumpers;
                    label2.ForeColor = Color.Crimson;
                    label2.Text = "Final Standings";
                    _skiJumpers = _skiJumpers.OrderByDescending(x => x.Points).ToList();
                    int p = 1;

                    foreach (var skijumper in _skiJumpers)
                    {
                        currentStandingsListView.Text += p + ". " + skijumper.CompetitorName + "\t" + skijumper.Points + " Points\n";
                        p++;
                    }
                }
                else
                {
                    // new round happens
                    roundGroupBox.Text = "Round 2";
                    // turn jumping order
                    _hasJumped.Clear();
                    // todo :
                    
                    _skiJumpers = _skiJumpers.OrderByDescending(x => x.Points).ToList();
                    int p = 1;
                    _roundOneResults = _skiJumpers; // can be used somewhere
                    foreach (var skijumper in _skiJumpers)
                    {
                        currentStandingsListView.Text += p + ". " + skijumper.CompetitorName + "\t" + skijumper.Points + " Points\n";
                        p++;
                    }
                    // clear standings
                    _skiJumpers.Reverse();
                    _roundOneResults.Reverse(); // can be used somewhere

                    competitorNameComboBox.DataSource = _skiJumpers;
                    competitorNameComboBox.DisplayMember = "competitorName";
                }
            }
            else
            {
                if (competitorNameComboBox.SelectedIndex < _skiJumpers.Count)
                {
                    competitorNameComboBox.SelectedIndex = (competitorNameComboBox.SelectedIndex + 1);
                }
                // todo tänne tuolta// todo  tämä täältä tuonne alas : //todo!!! täällä
                _skiJumpers = _skiJumpers.OrderByDescending(x => x.Points).ToList();
                int p = 1;

                foreach (var skijumper in _skiJumpers)
                {
                    currentStandingsListView.Text += p + ". " + skijumper.CompetitorName + "\t" + skijumper.Points + " Points\n";
                    p++;
                }

                jumpLengthTextBox.Focus();
            }
        }

        private void calculatePointsButton_Click(object sender, EventArgs e)
        {
            decimal juryPoints = 0;
            decimal lengthPoints = 0;
            decimal gatePoints = 0;
            decimal windPoints = 0;
            decimal jumpTotalPoints = 0;
            // var currentJumper = competitorNameComboBox.SelectedIndex;
            //var currentJumper = SkiJumpMainForm.competitorNameComboBox.SelectedIndex;

            //foreach (int r in hasJumped.Intersect)
            for (int i = 0; i < _hasJumped.Count; i++)
            {
                if (_skiJumpers[competitorNameComboBox.SelectedIndex].Id == _hasJumped[i])
                {
                    errorMessage.Visible = true;
                    goto nahno;
                }
            }

            juryPoints = PointsCalculator.CalcJuryPoints(jury1PointsComboBox.Value, jury2PointsComboBox.Value, jury3PointsComboBox.Value,
               jury4PointsComboBox.Value, jury5PointsComboBox.Value);
            lengthPoints = PointsCalculator.CalcLengthPoints(hillSizeTextBox.Value, jumpLengthTextBox.Value);
            gatePoints = PointsCalculator.CalcStartGatePoints(startGateComboBox.Value);
            windPoints = PointsCalculator.CalcWindPoints(windMeter1.Value, windMeter2.Value, windMeter3.Value, windMeter4.Value, windMeter5.Value, hillSizeTextBox.Value);
            jumpTotalPoints = juryPoints + lengthPoints + gatePoints + windPoints;

            pointsTextBox.Value = jumpTotalPoints;
            if (roundGroupBox.Text == "Round 2") // second round of competition
            {
                // skiJumpers=roundOneResults + skiJumpers;
                jumpTotalPoints = jumpTotalPoints + _skiJumpers[competitorNameComboBox.SelectedIndex].Points;
            }
            _skiJumpers[competitorNameComboBox.SelectedIndex].Points = jumpTotalPoints; // Add points on competitor

            nahno:
            ;
        }

/*
        private void jumpLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal parsedValue;

            if (!decimal.TryParse(jumpLengthTextBox.Text, out parsedValue))
            {
                jumpLengthTextBox.Text = "";
            }
        }
*/

        private void competitorNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }

/*
        private void hillSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal parsedValue;

            if (!decimal.TryParse(hillSizeTextBox.Text, out parsedValue))
            {
                hillSizeTextBox.Text = "";
            }
        }
*/

        private void roundGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void currentStandingsListView_TextChanged(object sender, EventArgs e)
        {

        }

        private void startGateComboBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void jumpLengthTextBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
