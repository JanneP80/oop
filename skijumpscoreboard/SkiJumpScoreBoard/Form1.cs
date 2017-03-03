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
    public partial class SkiJumpMainForm : Form
    {
        public SkiJumpMainForm()
        {
            InitializeComponent();

            List<SkiJumper> skiJumpers = new List<SkiJumper>();
            int HillSize = 0;
            // int n = 0;

            skiJumpers.Add(new SkiJumper(1, "Adam Malycz", 0));
            skiJumpers.Add(new SkiJumper(2, "Martin Schmitdt", 0));
            skiJumpers.Add(new SkiJumper(3, "Jari Puikkonen", 0));
            skiJumpers.Add(new SkiJumper(4, "Matti Hautamäki", 0));
            skiJumpers.Add(new SkiJumper(5, "Noriaki Kasai", 0));

            comboBox1.DataSource = skiJumpers;
            comboBox1.DisplayMember = "competitorName";

            var currentJumper = comboBox1.SelectedIndex;
            int tempvar = Convert.ToInt32(textBox1.Text);
            skiJumpers[currentJumper].Points = tempvar;
            //skiJumpers[currentJumper].Points = textBox1.Text;
            if (skiJumpers[currentJumper].Points < 1)
            {
                textBox1.AppendText("Please insert number greater than one. ");
                //textBox1.
            } /*
            else if (n < 1)
            {
                textBox1.Text="Please insert number greater than one. "
            }*/
        }

        private void SkiJumpMainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Jump Length
            // 

        }
    }
}
