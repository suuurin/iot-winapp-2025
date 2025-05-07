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
            LblSelectDate = new Label();
            txtDiary = new TextBox();
            label1 = new Label();
            clbTasks = new CheckedListBox();
            label2 = new Label();
            txtTask = new TextBox();
            btnAdd = new Button();
            btnDel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeather).BeginInit();
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
            // LblSelectDate
            // 
            LblSelectDate.AutoSize = true;
            LblSelectDate.Location = new Point(291, 85);
            LblSelectDate.Name = "LblSelectDate";
            LblSelectDate.Size = new Size(38, 15);
            LblSelectDate.TabIndex = 7;
            LblSelectDate.Text = "날짜 :";
            // 
            // txtDiary
            // 
            txtDiary.Location = new Point(291, 137);
            txtDiary.Name = "txtDiary";
            txtDiary.Size = new Size(276, 23);
            txtDiary.TabIndex = 8;
            txtDiary.Leave += txtDiary_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 119);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 9;
            label1.Text = "한 줄 일기";
            // 
            // clbTasks
            // 
            clbTasks.BorderStyle = BorderStyle.None;
            clbTasks.CheckOnClick = true;
            clbTasks.FormattingEnabled = true;
            clbTasks.Location = new Point(291, 192);
            clbTasks.Name = "clbTasks";
            clbTasks.Size = new Size(276, 180);
            clbTasks.TabIndex = 10;
            clbTasks.ItemCheck += clbTasks_ItemCheck;
            clbTasks.SelectedIndexChanged += clbTasks_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 174);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 11;
            label2.Text = "할 일 목록";
            // 
            // txtTask
            // 
            txtTask.Location = new Point(291, 382);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(176, 23);
            txtTask.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(473, 382);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(45, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(522, 382);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(45, 23);
            btnDel.TabIndex = 14;
            btnDel.Text = "삭제";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 461);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(txtTask);
            Controls.Add(label2);
            Controls.Add(clbTasks);
            Controls.Add(label1);
            Controls.Add(txtDiary);
            Controls.Add(LblSelectDate);
            Controls.Add(monthCalendar1);
            Controls.Add(picWeather);
            Controls.Add(LblWeather);
            Controls.Add(cboWeather);
            Controls.Add(pictureBox1);
            Controls.Add(LblTime);
            Controls.Add(LblDate);
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiaryPlan";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeather).EndInit();
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
        private Label LblSelectDate;
        private TextBox txtDiary;
        private Label label1;
        private CheckedListBox clbTasks;
        private Label label2;
        private TextBox txtTask;
        private Button btnAdd;
        private Button btnDel;
    }
}
