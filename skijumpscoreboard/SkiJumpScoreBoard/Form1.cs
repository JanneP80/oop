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
        //private string jumpLength;
        List<SkiJumper> skiJumpers = new List<SkiJumper>();

        public SkiJumpMainForm()
        {
            InitializeComponent();
            

            //List<SkiJumper> skiJumpers = new List<SkiJumper>();
            List<float> juryPoints = new List<float>()
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

            comboBox1.DataSource = skiJumpers;
            comboBox1.DisplayMember = "competitorName";

            // var currentJumper = comboBox1.SelectedIndex;

            // if (jumpLenght < 0)
            // {
            //   textBox1.AppendText("Please insert jump length");
            //}

            comboBox2.DataSource = juryPoints;
            comboBox3.DataSource = juryPoints;
            comboBox4.DataSource = juryPoints;
            comboBox5.DataSource = juryPoints;
            comboBox6.DataSource = juryPoints;

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
            //CanFocus.textBox3;
            textBox3.Focus();// hill size
            //Control.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Jump Length
            // 
            //  jumpLenght = textBox1.Text;
            double parsedValue;

            if (!double.TryParse(textBox1.Text, out parsedValue))
            {
                textBox1.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jumpLength3 = (Convert.ToInt32(textBox1.Text));

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
            var windsummum = listBox1.Items;
            var jurypoints = Convert.ToDecimal(comboBox2.Text);
            var currentJumper = comboBox1.SelectedIndex;

            calculatePoints(currentJumper, jumpLength3, windsummum, jurypoints);

        }

        private void calculatePoints(object p, Int32 jumpLength2, ListBox.ObjectCollection summum, decimal jurypoints)
        {
            // skiJumpers[currentJumper].Points =
            

            var points = 0 + (double) +jurypoints;
            if (jumpLength2 > Convert.ToInt32(textBox3.Text)) // hill size =textbox3
            {
                points = jumpLength2 * 1.8 + (double)+jurypoints;
                points += 60;
            }
            else // how about under k-point
            {
                points = jumpLength2 * 1.8 + (double)+jurypoints;
            }
            textBox2.AppendText("" + points);
            
            //return points;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox1.DataSource = juryPoints;
            float parsedValue;

            if (!float.TryParse(comboBox2.Text, out parsedValue))
            {
                comboBox2.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) // points after calculation
        {
            double parsedValue;

            if (!double.TryParse(textBox3.Text, out parsedValue))
            {
                textBox3.Text = "";
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;

            if (!double.TryParse(textBox2.Text, out parsedValue))
            {
                textBox2.Text = "";
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // sending information forward
            
            var value= float.Parse(textBox2.Text);
            skiJumpers[comboBox1.SelectedIndex].Points = value;
            this.listBox2.DisplayMember = (skiJumpers[comboBox1.SelectedIndex].CompetitorName);
           // listBox2.DataSource = skiJumpers[comboBox1.SelectedIndex].Points;
            listBox2.Refresh();
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

            //clearing for next jump
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;

            comboBox1.Focus();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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
