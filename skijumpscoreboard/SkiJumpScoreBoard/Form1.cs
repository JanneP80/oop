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
            List<SkiJumper> skiJumpers = new List<SkiJumper>();
            int HillSize = 0;


            skiJumpers.Add(new SkiJumper(1, "Adam Malycz", 0));
            skiJumpers.Add(new SkiJumper(2, "Martin Schmitdt", 0));
            skiJumpers.Add(new SkiJumper(3, "Jari Puikkonen", 0));
            skiJumpers.Add(new SkiJumper(4, "Matti Hautamäki", 0));
            skiJumpers.Add(new SkiJumper(5, "Noriaki Kasai", 0));

            comboBox1.DataSource = skiJumpers;
            comboBox1.DisplayMember = "competitorName";


        }

        private void SkiJumpMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
