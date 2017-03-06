namespace SkiJumpScoreBoard
{
    partial class SkiJumpMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.jumpLengthTextBox = new System.Windows.Forms.TextBox();
            this.windMeterListBox = new System.Windows.Forms.ListBox();
            this.competitorNameComboBox = new System.Windows.Forms.ComboBox();
            this.jury1comboBox = new System.Windows.Forms.ComboBox();
            this.jury2ComboBox = new System.Windows.Forms.ComboBox();
            this.jury3comboBox = new System.Windows.Forms.ComboBox();
            this.jury4comboBox = new System.Windows.Forms.ComboBox();
            this.jury5comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1calculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hillSizeTextBox = new System.Windows.Forms.TextBox();
            this.button2next = new System.Windows.Forms.Button();
            this.standingsListBox = new System.Windows.Forms.ListBox();
            this.skiJumperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WindMeterTextBox2 = new System.Windows.Forms.TextBox();
            this.textBox4temp = new System.Windows.Forms.TextBox();
            this.skiJumperBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.startGateComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiJumperBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skiJumperBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // jumpLengthTextBox
            // 
            this.jumpLengthTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "JumpLength"});
            this.jumpLengthTextBox.Location = new System.Drawing.Point(273, 218);
            this.jumpLengthTextBox.Name = "jumpLengthTextBox";
            this.jumpLengthTextBox.Size = new System.Drawing.Size(100, 22);
            this.jumpLengthTextBox.TabIndex = 2;
            this.jumpLengthTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // windMeterListBox
            // 
            this.windMeterListBox.DisplayMember = "int wind";
            this.windMeterListBox.FormatString = "N2";
            this.windMeterListBox.FormattingEnabled = true;
            this.windMeterListBox.ItemHeight = 16;
            this.windMeterListBox.Items.AddRange(new object[] {
            "Wind1",
            "Wind2",
            "Wind3",
            "Wind4",
            "Wind5"});
            this.windMeterListBox.Location = new System.Drawing.Point(626, 75);
            this.windMeterListBox.Name = "windMeterListBox";
            this.windMeterListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.windMeterListBox.Size = new System.Drawing.Size(44, 84);
            this.windMeterListBox.TabIndex = 8;
            this.windMeterListBox.ValueMember = "int wind";
            this.windMeterListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // competitorNameComboBox
            // 
            this.competitorNameComboBox.FormattingEnabled = true;
            this.competitorNameComboBox.Location = new System.Drawing.Point(60, 218);
            this.competitorNameComboBox.Name = "competitorNameComboBox";
            this.competitorNameComboBox.Size = new System.Drawing.Size(145, 24);
            this.competitorNameComboBox.TabIndex = 1;
            // 
            // jury1comboBox
            // 
            this.jury1comboBox.FormatString = "N1";
            this.jury1comboBox.FormattingEnabled = true;
            this.jury1comboBox.Location = new System.Drawing.Point(452, 216);
            this.jury1comboBox.Name = "jury1comboBox";
            this.jury1comboBox.Size = new System.Drawing.Size(75, 24);
            this.jury1comboBox.TabIndex = 3;
            this.jury1comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // jury2ComboBox
            // 
            this.jury2ComboBox.FormatString = "N1";
            this.jury2ComboBox.FormattingEnabled = true;
            this.jury2ComboBox.Location = new System.Drawing.Point(452, 246);
            this.jury2ComboBox.Name = "jury2ComboBox";
            this.jury2ComboBox.Size = new System.Drawing.Size(75, 24);
            this.jury2ComboBox.TabIndex = 4;
            // 
            // jury3comboBox
            // 
            this.jury3comboBox.FormatString = "N1";
            this.jury3comboBox.FormattingEnabled = true;
            this.jury3comboBox.Location = new System.Drawing.Point(452, 276);
            this.jury3comboBox.Name = "jury3comboBox";
            this.jury3comboBox.Size = new System.Drawing.Size(75, 24);
            this.jury3comboBox.TabIndex = 5;
            // 
            // jury4comboBox
            // 
            this.jury4comboBox.FormatString = "N1";
            this.jury4comboBox.FormattingEnabled = true;
            this.jury4comboBox.Location = new System.Drawing.Point(452, 306);
            this.jury4comboBox.Name = "jury4comboBox";
            this.jury4comboBox.Size = new System.Drawing.Size(75, 24);
            this.jury4comboBox.TabIndex = 6;
            // 
            // jury5comboBox
            // 
            this.jury5comboBox.FormatString = "N1";
            this.jury5comboBox.FormattingEnabled = true;
            this.jury5comboBox.Location = new System.Drawing.Point(452, 336);
            this.jury5comboBox.Name = "jury5comboBox";
            this.jury5comboBox.Size = new System.Drawing.Size(75, 24);
            this.jury5comboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Competitor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Jump Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Jury Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wind Meter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(487, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ski Jump Score Board Points Calculator";
            // 
            // button1calculate
            // 
            this.button1calculate.Location = new System.Drawing.Point(273, 304);
            this.button1calculate.Name = "button1calculate";
            this.button1calculate.Size = new System.Drawing.Size(124, 26);
            this.button1calculate.TabIndex = 13;
            this.button1calculate.Text = "Calculate points";
            this.button1calculate.UseVisualStyleBackColor = true;
            this.button1calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Calculate points when all fields are filled.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "points";
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.Enabled = false;
            this.pointsTextBox.Location = new System.Drawing.Point(273, 363);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.Size = new System.Drawing.Size(100, 22);
            this.pointsTextBox.TabIndex = 16;
            this.pointsTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\ekoodi17k\\dev\\oop\\skijumpscoreboard\\SkiJumpScoreBoard\\flags\\at.png";
            this.pictureBox1.Location = new System.Drawing.Point(544, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "D:\\ekoodi17k\\dev\\oop\\skijumpscoreboard\\SkiJumpScoreBoard\\flags\\FINL0001.GIF";
            this.pictureBox2.Location = new System.Drawing.Point(544, 246);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageLocation = "D:\\ekoodi17k\\dev\\oop\\skijumpscoreboard\\SkiJumpScoreBoard\\flags\\japan.png";
            this.pictureBox3.Location = new System.Drawing.Point(544, 276);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ImageLocation = "D:\\ekoodi17k\\dev\\oop\\skijumpscoreboard\\SkiJumpScoreBoard\\flags\\german-flag_small." +
    "gif";
            this.pictureBox4.Location = new System.Drawing.Point(544, 306);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.ImageLocation = "D:\\ekoodi17k\\dev\\oop\\skijumpscoreboard\\SkiJumpScoreBoard\\flags\\NORWAY.png";
            this.pictureBox5.Location = new System.Drawing.Point(544, 336);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Input Hill Size (K-point)";
            // 
            // hillSizeTextBox
            // 
            this.hillSizeTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "JumpLength"});
            this.hillSizeTextBox.Location = new System.Drawing.Point(60, 103);
            this.hillSizeTextBox.Name = "hillSizeTextBox";
            this.hillSizeTextBox.Size = new System.Drawing.Size(145, 22);
            this.hillSizeTextBox.TabIndex = 0;
            this.hillSizeTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2next
            // 
            this.button2next.Location = new System.Drawing.Point(521, 397);
            this.button2next.Name = "button2next";
            this.button2next.Size = new System.Drawing.Size(142, 28);
            this.button2next.TabIndex = 24;
            this.button2next.Text = "Next Competitor";
            this.button2next.UseVisualStyleBackColor = true;
            this.button2next.Click += new System.EventHandler(this.button2_Click);
            // 
            // standingsListBox
            // 
            this.standingsListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.skiJumperBindingSource, "Id", true));
            this.standingsListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.skiJumperBindingSource, "CompetitorName", true));
            this.standingsListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.skiJumperBindingSource, "Points", true));
            this.standingsListBox.DataSource = this.skiJumperBindingSource;
            this.standingsListBox.DisplayMember = "CompetitorName";
            this.standingsListBox.FormattingEnabled = true;
            this.standingsListBox.ItemHeight = 16;
            this.standingsListBox.Location = new System.Drawing.Point(60, 336);
            this.standingsListBox.Name = "standingsListBox";
            this.standingsListBox.Size = new System.Drawing.Size(145, 116);
            this.standingsListBox.TabIndex = 25;
            this.standingsListBox.ValueMember = "Points";
            this.standingsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // skiJumperBindingSource
            // 
            this.skiJumperBindingSource.DataSource = typeof(SkiJumpScoreBoard.SkiJumper);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Current Standings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WindMeterTextBox2);
            this.groupBox1.Controls.Add(this.textBox4temp);
            this.groupBox1.Controls.Add(this.windMeterListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 340);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Round 1";
            // 
            // WindMeterTextBox2
            // 
            this.WindMeterTextBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.WindMeterTextBox2.Location = new System.Drawing.Point(676, 75);
            this.WindMeterTextBox2.Multiline = true;
            this.WindMeterTextBox2.Name = "WindMeterTextBox2";
            this.WindMeterTextBox2.Size = new System.Drawing.Size(62, 88);
            this.WindMeterTextBox2.TabIndex = 1;
            this.WindMeterTextBox2.Tag = "windsummum";
            this.WindMeterTextBox2.Text = "1\r\n2\r\n3\r\n4\r\n5";
            // 
            // textBox4temp
            // 
            this.textBox4temp.Location = new System.Drawing.Point(261, 261);
            this.textBox4temp.Name = "textBox4temp";
            this.textBox4temp.Size = new System.Drawing.Size(100, 22);
            this.textBox4temp.TabIndex = 0;
            this.textBox4temp.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // skiJumperBindingSource1
            // 
            this.skiJumperBindingSource1.DataSource = typeof(SkiJumpScoreBoard.SkiJumper);
            // 
            // startGateComboBox
            // 
            this.startGateComboBox.FormattingEnabled = true;
            this.startGateComboBox.Location = new System.Drawing.Point(452, 99);
            this.startGateComboBox.Name = "startGateComboBox";
            this.startGateComboBox.Size = new System.Drawing.Size(121, 24);
            this.startGateComboBox.TabIndex = 28;
            this.startGateComboBox.Text = "0";
            this.startGateComboBox.SelectedIndexChanged += new System.EventHandler(this.startGateComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(449, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(353, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "StartGate Level Change compared to Competition start";
            // 
            // SkiJumpMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 493);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.startGateComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.standingsListBox);
            this.Controls.Add(this.button2next);
            this.Controls.Add(this.hillSizeTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pointsTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1calculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jury5comboBox);
            this.Controls.Add(this.jury4comboBox);
            this.Controls.Add(this.jury3comboBox);
            this.Controls.Add(this.jury2ComboBox);
            this.Controls.Add(this.jury1comboBox);
            this.Controls.Add(this.competitorNameComboBox);
            this.Controls.Add(this.jumpLengthTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "SkiJumpMainForm";
            this.Text = "Ski Jump Score Board";
            this.Load += new System.EventHandler(this.SkiJumpMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiJumperBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skiJumperBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox competitorNameComboBox;
        private System.Windows.Forms.ComboBox jury1comboBox;
        private System.Windows.Forms.ComboBox jury2ComboBox;
        private System.Windows.Forms.ComboBox jury3comboBox;
        private System.Windows.Forms.ComboBox jury4comboBox;
        private System.Windows.Forms.ComboBox jury5comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1calculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox jumpLengthTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pointsTextBox;
        private System.Windows.Forms.ListBox windMeterListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hillSizeTextBox;
        private System.Windows.Forms.Button button2next;
        private System.Windows.Forms.ListBox standingsListBox;
        private System.Windows.Forms.BindingSource skiJumperBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4temp;
        private System.Windows.Forms.TextBox WindMeterTextBox2;
        private System.Windows.Forms.BindingSource skiJumperBindingSource1;
        private System.Windows.Forms.ComboBox startGateComboBox;
        private System.Windows.Forms.Label label10;
    }
}

