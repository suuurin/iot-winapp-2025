namespace MoodPlan
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            LblDate = new Label();
            LblTime = new Label();
            timerClock = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            cboWeather = new ComboBox();
            LblWeather = new Label();
            picWeather = new PictureBox();
            monthCalendar1 = new MonthCalendar();
            cboMood = new ComboBox();
            picMood = new PictureBox();
            LblSelectDate = new Label();
            LblMood = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeather).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMood).BeginInit();
            SuspendLayout();
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.Location = new Point(44, 17);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(12, 15);
            LblDate.TabIndex = 0;
            LblDate.Text = "-";
            // 
            // LblTime
            // 
            LblTime.AutoSize = true;
            LblTime.Location = new Point(143, 17);
            LblTime.Name = "LblTime";
            LblTime.Size = new Size(12, 15);
            LblTime.TabIndex = 1;
            LblTime.Text = "-";
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "clock.png");
            imageList1.Images.SetKeyName(1, "sun");
            imageList1.Images.SetKeyName(2, "cloudy");
            imageList1.Images.SetKeyName(3, "rain");
            imageList1.Images.SetKeyName(4, "happy");
            imageList1.Images.SetKeyName(5, "normal");
            imageList1.Images.SetKeyName(6, "sad");
            imageList1.Images.SetKeyName(7, "angry");
            // 
            // cboWeather
            // 
            cboWeather.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWeather.FormattingEnabled = true;
            cboWeather.Items.AddRange(new object[] { "맑음", "흐림", "비" });
            cboWeather.Location = new Point(523, 15);
            cboWeather.Name = "cboWeather";
            cboWeather.Size = new Size(48, 23);
            cboWeather.TabIndex = 3;
            cboWeather.SelectedIndexChanged += cboWeather_SelectedIndexChanged;
            // 
            // LblWeather
            // 
            LblWeather.AutoSize = true;
            LblWeather.Location = new Point(449, 19);
            LblWeather.Name = "LblWeather";
            LblWeather.Size = new Size(38, 15);
            LblWeather.TabIndex = 4;
            LblWeather.Text = "날씨 :";
            // 
            // picWeather
            // 
            picWeather.Location = new Point(491, 15);
            picWeather.Name = "picWeather";
            picWeather.Size = new Size(24, 24);
            picWeather.SizeMode = PictureBoxSizeMode.StretchImage;
            picWeather.TabIndex = 5;
            picWeather.TabStop = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(1, 2);
            monthCalendar1.Location = new Point(33, 85);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // cboMood
            // 
            cboMood.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMood.FormattingEnabled = true;
            cboMood.Items.AddRange(new object[] { "행복", "보통", "우울", "나쁨" });
            cboMood.Location = new Point(524, 85);
            cboMood.Name = "cboMood";
            cboMood.Size = new Size(48, 23);
            cboMood.TabIndex = 2;
            // 
            // picMood
            // 
            picMood.Location = new Point(492, 85);
            picMood.Name = "picMood";
            picMood.Size = new Size(24, 24);
            picMood.TabIndex = 1;
            picMood.TabStop = false;
            // 
            // LblSelectDate
            // 
            LblSelectDate.AutoSize = true;
            LblSelectDate.Location = new Point(290, 89);
            LblSelectDate.Name = "LblSelectDate";
            LblSelectDate.Size = new Size(38, 15);
            LblSelectDate.TabIndex = 7;
            LblSelectDate.Text = "날짜 :";
            // 
            // LblMood
            // 
            LblMood.AutoSize = true;
            LblMood.Location = new Point(449, 89);
            LblMood.Name = "LblMood";
            LblMood.Size = new Size(38, 15);
            LblMood.TabIndex = 8;
            LblMood.Text = "기분 :";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 461);
            Controls.Add(LblMood);
            Controls.Add(LblSelectDate);
            Controls.Add(picMood);
            Controls.Add(monthCalendar1);
            Controls.Add(cboMood);
            Controls.Add(picWeather);
            Controls.Add(LblWeather);
            Controls.Add(cboWeather);
            Controls.Add(pictureBox1);
            Controls.Add(LblTime);
            Controls.Add(LblDate);
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MoodPlan";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeather).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblDate;
        private Label LblTime;
        private System.Windows.Forms.Timer timerClock;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private ComboBox cboWeather;
        private Label LblWeather;
        private PictureBox picWeather;
        private MonthCalendar monthCalendar1;
        private ComboBox cboMood;
        private PictureBox picMood;
        private Label LblSelectDate;
        private Label LblMood;
    }
}
