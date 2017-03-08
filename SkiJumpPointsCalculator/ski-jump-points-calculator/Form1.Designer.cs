namespace SkiJumpPointsCalculator
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
            this.roundGroupBox = new System.Windows.Forms.GroupBox();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.jumpLengthTextBox = new System.Windows.Forms.TextBox();
            this.windMeterTextBox2 = new System.Windows.Forms.TextBox();
            this.jury5PointsComboBox = new System.Windows.Forms.ComboBox();
            this.jury4PointsComboBox = new System.Windows.Forms.ComboBox();
            this.jury3PointsComboBox = new System.Windows.Forms.ComboBox();
            this.jury2PointsComboBox = new System.Windows.Forms.ComboBox();
            this.jury1PointsComboBox = new System.Windows.Forms.ComboBox();
            this.competitorNameComboBox = new System.Windows.Forms.ComboBox();
            this.currentStandingsListView = new System.Windows.Forms.ListView();
            this.nextCompetitorButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.calculatePointsButton = new System.Windows.Forms.Button();
            this.windMeterListBox = new System.Windows.Forms.ListBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2JumpLength = new System.Windows.Forms.Label();
            this.label1CompetitorName = new System.Windows.Forms.Label();
            this.label1HillSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1StartGate = new System.Windows.Forms.Label();
            this.hillSizeTextBox = new System.Windows.Forms.TextBox();
            this.startGateComboBox = new System.Windows.Forms.ComboBox();
            this.roundGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundGroupBox
            // 
            this.roundGroupBox.Controls.Add(this.pointsTextBox);
            this.roundGroupBox.Controls.Add(this.jumpLengthTextBox);
            this.roundGroupBox.Controls.Add(this.windMeterTextBox2);
            this.roundGroupBox.Controls.Add(this.jury5PointsComboBox);
            this.roundGroupBox.Controls.Add(this.jury4PointsComboBox);
            this.roundGroupBox.Controls.Add(this.jury3PointsComboBox);
            this.roundGroupBox.Controls.Add(this.jury2PointsComboBox);
            this.roundGroupBox.Controls.Add(this.jury1PointsComboBox);
            this.roundGroupBox.Controls.Add(this.competitorNameComboBox);
            this.roundGroupBox.Controls.Add(this.currentStandingsListView);
            this.roundGroupBox.Controls.Add(this.nextCompetitorButton);
            this.roundGroupBox.Controls.Add(this.label6);
            this.roundGroupBox.Controls.Add(this.calculatePointsButton);
            this.roundGroupBox.Controls.Add(this.windMeterListBox);
            this.roundGroupBox.Controls.Add(this.pictureBox5);
            this.roundGroupBox.Controls.Add(this.pictureBox4);
            this.roundGroupBox.Controls.Add(this.pictureBox3);
            this.roundGroupBox.Controls.Add(this.pictureBox2);
            this.roundGroupBox.Controls.Add(this.pictureBox1);
            this.roundGroupBox.Controls.Add(this.label2);
            this.roundGroupBox.Controls.Add(this.label1);
            this.roundGroupBox.Controls.Add(this.label4);
            this.roundGroupBox.Controls.Add(this.label3);
            this.roundGroupBox.Controls.Add(this.label2JumpLength);
            this.roundGroupBox.Controls.Add(this.label1CompetitorName);
            this.roundGroupBox.Location = new System.Drawing.Point(12, 167);
            this.roundGroupBox.Name = "roundGroupBox";
            this.roundGroupBox.Size = new System.Drawing.Size(831, 369);
            this.roundGroupBox.TabIndex = 0;
            this.roundGroupBox.TabStop = false;
            this.roundGroupBox.Text = "Round 1";
            this.roundGroupBox.Enter += new System.EventHandler(this.roundGroupBox_Enter);
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.Location = new System.Drawing.Point(270, 257);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.ReadOnly = true;
            this.pointsTextBox.Size = new System.Drawing.Size(99, 22);
            this.pointsTextBox.TabIndex = 40;
            this.pointsTextBox.Text = "0";
            // 
            // jumpLengthTextBox
            // 
            this.jumpLengthTextBox.Location = new System.Drawing.Point(253, 75);
            this.jumpLengthTextBox.Name = "jumpLengthTextBox";
            this.jumpLengthTextBox.Size = new System.Drawing.Size(99, 22);
            this.jumpLengthTextBox.TabIndex = 39;
            this.jumpLengthTextBox.TextChanged += new System.EventHandler(this.jumpLengthTextBox_TextChanged);
            // 
            // windMeterTextBox2
            // 
            this.windMeterTextBox2.Location = new System.Drawing.Point(691, 75);
            this.windMeterTextBox2.Multiline = true;
            this.windMeterTextBox2.Name = "windMeterTextBox2";
            this.windMeterTextBox2.Size = new System.Drawing.Size(100, 90);
            this.windMeterTextBox2.TabIndex = 38;
            this.windMeterTextBox2.Text = "1\r\n2\r\n3\r\n4\r\n5";
            this.windMeterTextBox2.TextChanged += new System.EventHandler(this.windMeterTextBox2_TextChanged);
            // 
            // jury5PointsComboBox
            // 
            this.jury5PointsComboBox.FormatString = "N2";
            this.jury5PointsComboBox.FormattingEnabled = true;
            this.jury5PointsComboBox.Location = new System.Drawing.Point(439, 195);
            this.jury5PointsComboBox.Name = "jury5PointsComboBox";
            this.jury5PointsComboBox.Size = new System.Drawing.Size(88, 24);
            this.jury5PointsComboBox.TabIndex = 37;
            this.jury5PointsComboBox.Text = "18";
            this.jury5PointsComboBox.SelectedIndexChanged += new System.EventHandler(this.jury5PointsComboBox_SelectedIndexChanged);
            // 
            // jury4PointsComboBox
            // 
            this.jury4PointsComboBox.FormatString = "N2";
            this.jury4PointsComboBox.FormattingEnabled = true;
            this.jury4PointsComboBox.Location = new System.Drawing.Point(439, 165);
            this.jury4PointsComboBox.Name = "jury4PointsComboBox";
            this.jury4PointsComboBox.Size = new System.Drawing.Size(88, 24);
            this.jury4PointsComboBox.TabIndex = 36;
            this.jury4PointsComboBox.Text = "18";
            this.jury4PointsComboBox.SelectedIndexChanged += new System.EventHandler(this.jury4PointsComboBox_SelectedIndexChanged);
            // 
            // jury3PointsComboBox
            // 
            this.jury3PointsComboBox.FormatString = "N2";
            this.jury3PointsComboBox.FormattingEnabled = true;
            this.jury3PointsComboBox.Location = new System.Drawing.Point(439, 135);
            this.jury3PointsComboBox.Name = "jury3PointsComboBox";
            this.jury3PointsComboBox.Size = new System.Drawing.Size(88, 24);
            this.jury3PointsComboBox.TabIndex = 35;
            this.jury3PointsComboBox.Text = "18";
            this.jury3PointsComboBox.SelectedIndexChanged += new System.EventHandler(this.jury3PointsComboBox_SelectedIndexChanged);
            // 
            // jury2PointsComboBox
            // 
            this.jury2PointsComboBox.FormatString = "N2";
            this.jury2PointsComboBox.FormattingEnabled = true;
            this.jury2PointsComboBox.Location = new System.Drawing.Point(439, 105);
            this.jury2PointsComboBox.Name = "jury2PointsComboBox";
            this.jury2PointsComboBox.Size = new System.Drawing.Size(88, 24);
            this.jury2PointsComboBox.TabIndex = 34;
            this.jury2PointsComboBox.Text = "18";
            this.jury2PointsComboBox.SelectedIndexChanged += new System.EventHandler(this.jury2PointsComboBox_SelectedIndexChanged);
            // 
            // jury1PointsComboBox
            // 
            this.jury1PointsComboBox.FormatString = "N2";
            this.jury1PointsComboBox.FormattingEnabled = true;
            this.jury1PointsComboBox.Location = new System.Drawing.Point(439, 75);
            this.jury1PointsComboBox.Name = "jury1PointsComboBox";
            this.jury1PointsComboBox.Size = new System.Drawing.Size(88, 24);
            this.jury1PointsComboBox.TabIndex = 33;
            this.jury1PointsComboBox.Text = "18";
            this.jury1PointsComboBox.SelectedIndexChanged += new System.EventHandler(this.jury1PointsComboBox_SelectedIndexChanged);
            // 
            // competitorNameComboBox
            // 
            this.competitorNameComboBox.FormattingEnabled = true;
            this.competitorNameComboBox.Location = new System.Drawing.Point(55, 75);
            this.competitorNameComboBox.Name = "competitorNameComboBox";
            this.competitorNameComboBox.Size = new System.Drawing.Size(164, 24);
            this.competitorNameComboBox.TabIndex = 32;
            this.competitorNameComboBox.SelectedIndexChanged += new System.EventHandler(this.competitorNameComboBox_SelectedIndexChanged);
            // 
            // currentStandingsListView
            // 
            this.currentStandingsListView.Location = new System.Drawing.Point(55, 217);
            this.currentStandingsListView.Name = "currentStandingsListView";
            this.currentStandingsListView.Size = new System.Drawing.Size(164, 127);
            this.currentStandingsListView.TabIndex = 31;
            this.currentStandingsListView.UseCompatibleStateImageBehavior = false;
            this.currentStandingsListView.SelectedIndexChanged += new System.EventHandler(this.currentStandingsListView_SelectedIndexChanged);
            // 
            // nextCompetitorButton
            // 
            this.nextCompetitorButton.Location = new System.Drawing.Point(439, 254);
            this.nextCompetitorButton.Name = "nextCompetitorButton";
            this.nextCompetitorButton.Size = new System.Drawing.Size(144, 25);
            this.nextCompetitorButton.TabIndex = 30;
            this.nextCompetitorButton.Text = "Next Competitor";
            this.nextCompetitorButton.UseVisualStyleBackColor = true;
            this.nextCompetitorButton.Click += new System.EventHandler(this.nextCompetitorButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Points";
            // 
            // calculatePointsButton
            // 
            this.calculatePointsButton.Location = new System.Drawing.Point(270, 195);
            this.calculatePointsButton.Name = "calculatePointsButton";
            this.calculatePointsButton.Size = new System.Drawing.Size(131, 24);
            this.calculatePointsButton.TabIndex = 28;
            this.calculatePointsButton.Text = "Calculate Points";
            this.calculatePointsButton.UseVisualStyleBackColor = true;
            this.calculatePointsButton.Click += new System.EventHandler(this.calculatePointsButton_Click);
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
            this.windMeterListBox.Location = new System.Drawing.Point(640, 76);
            this.windMeterListBox.Name = "windMeterListBox";
            this.windMeterListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.windMeterListBox.Size = new System.Drawing.Size(44, 84);
            this.windMeterListBox.TabIndex = 27;
            this.windMeterListBox.ValueMember = "int wind";
            // 
            // pictureBox5
            // 
            this.pictureBox5.ImageLocation = "D:\\ekoodi17k\\dev\\oop\\skijumpscoreboard\\SkiJumpScoreBoard\\flags\\NORWAY.png";
            this.pictureBox5.Location = new System.Drawing.Point(545, 195);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ImageLocation = "D:\\ekoodi17k\\dev\\oop\\skijumpscoreboard\\SkiJumpScoreBoard\\flags\\german-flag_small." +
    "gif";
            this.pictureBox4.Location = new System.Drawing.Point(545, 165);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageLocation = "D:\\ekoodi17k\\dev\\oop\\skijumpscoreboard\\SkiJumpScoreBoard\\flags\\japan.png";
            this.pictureBox3.Location = new System.Drawing.Point(545, 135);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "D:\\ekoodi17k\\dev\\oop\\skijumpscoreboard\\SkiJumpScoreBoard\\flags\\FINL0001.GIF";
            this.pictureBox2.Location = new System.Drawing.Point(545, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\ekoodi17k\\dev\\oop\\skijumpscoreboard\\SkiJumpScoreBoard\\flags\\at.png";
            this.pictureBox1.Location = new System.Drawing.Point(545, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Current Standings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Calculate points when all fields are filled.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Wind Meters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Jury Points";
            // 
            // label2JumpLength
            // 
            this.label2JumpLength.AutoSize = true;
            this.label2JumpLength.Location = new System.Drawing.Point(250, 42);
            this.label2JumpLength.Name = "label2JumpLength";
            this.label2JumpLength.Size = new System.Drawing.Size(90, 17);
            this.label2JumpLength.TabIndex = 16;
            this.label2JumpLength.Text = "Jump Length";
            // 
            // label1CompetitorName
            // 
            this.label1CompetitorName.AutoSize = true;
            this.label1CompetitorName.Location = new System.Drawing.Point(52, 42);
            this.label1CompetitorName.Name = "label1CompetitorName";
            this.label1CompetitorName.Size = new System.Drawing.Size(117, 17);
            this.label1CompetitorName.TabIndex = 15;
            this.label1CompetitorName.Text = "Competitor Name";
            // 
            // label1HillSize
            // 
            this.label1HillSize.AutoSize = true;
            this.label1HillSize.Location = new System.Drawing.Point(64, 92);
            this.label1HillSize.Name = "label1HillSize";
            this.label1HillSize.Size = new System.Drawing.Size(152, 17);
            this.label1HillSize.TabIndex = 1;
            this.label1HillSize.Text = "Input Hill Size (K-point)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(487, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ski Jump Score Board Points Calculator";
            // 
            // label1StartGate
            // 
            this.label1StartGate.AutoSize = true;
            this.label1StartGate.Location = new System.Drawing.Point(448, 92);
            this.label1StartGate.Name = "label1StartGate";
            this.label1StartGate.Size = new System.Drawing.Size(353, 17);
            this.label1StartGate.TabIndex = 14;
            this.label1StartGate.Text = "StartGate Level Change compared to Competition start";
            // 
            // hillSizeTextBox
            // 
            this.hillSizeTextBox.Location = new System.Drawing.Point(67, 121);
            this.hillSizeTextBox.Name = "hillSizeTextBox";
            this.hillSizeTextBox.Size = new System.Drawing.Size(99, 22);
            this.hillSizeTextBox.TabIndex = 41;
            this.hillSizeTextBox.TextChanged += new System.EventHandler(this.hillSizeTextBox_TextChanged);
            // 
            // startGateComboBox
            // 
            this.startGateComboBox.FormatString = "N2";
            this.startGateComboBox.FormattingEnabled = true;
            this.startGateComboBox.Location = new System.Drawing.Point(451, 121);
            this.startGateComboBox.Name = "startGateComboBox";
            this.startGateComboBox.Size = new System.Drawing.Size(88, 24);
            this.startGateComboBox.TabIndex = 41;
            this.startGateComboBox.Text = "0";
            this.startGateComboBox.SelectedIndexChanged += new System.EventHandler(this.startGateComboBox_SelectedIndexChanged);
            // 
            // SkiJumpMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 548);
            this.Controls.Add(this.startGateComboBox);
            this.Controls.Add(this.hillSizeTextBox);
            this.Controls.Add(this.label1StartGate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1HillSize);
            this.Controls.Add(this.roundGroupBox);
            this.Name = "SkiJumpMainForm";
            this.Text = "Ski Jump Score Board";
            this.Load += new System.EventHandler(this.SkiJumpMainForm_Load);
            this.roundGroupBox.ResumeLayout(false);
            this.roundGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox roundGroupBox;
        private System.Windows.Forms.Button calculatePointsButton;
        private System.Windows.Forms.ListBox windMeterListBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2JumpLength;
        private System.Windows.Forms.Label label1CompetitorName;
        private System.Windows.Forms.Label label1HillSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1StartGate;
        private System.Windows.Forms.ListView currentStandingsListView;
        private System.Windows.Forms.Button nextCompetitorButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox competitorNameComboBox;
        private System.Windows.Forms.TextBox pointsTextBox;
        private System.Windows.Forms.TextBox jumpLengthTextBox;
        private System.Windows.Forms.TextBox windMeterTextBox2;
        private System.Windows.Forms.ComboBox jury5PointsComboBox;
        private System.Windows.Forms.ComboBox jury4PointsComboBox;
        private System.Windows.Forms.ComboBox jury3PointsComboBox;
        private System.Windows.Forms.ComboBox jury2PointsComboBox;
        private System.Windows.Forms.ComboBox jury1PointsComboBox;
        private System.Windows.Forms.TextBox hillSizeTextBox;
        private System.Windows.Forms.ComboBox startGateComboBox;
    }
}

