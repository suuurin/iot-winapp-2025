namespace MoodPlan
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private Dictionary<DateTime, DayData> dailyData = new Dictionary<DateTime, DayData>();

        private class DayData
        {
            public string Diary { get; set; } = "";
            public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();
        }

        private class TaskItem
        {
            public string Content { get; set; } = "";
            public bool Done { get; set; } = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadFromTextFile(); // ← 텍스트 불러오기

            timerClock.Start(); // 타이머 시작
            UpdateDateTime();   // 첫 표시도 갱신

            DateTime today = DateTime.Today;
            monthCalendar1.SelectionStart = today;
            UpdateMoodUI(today);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToTextFile();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            DateTime now = DateTime.Now;
            string[] weekdays = { "일", "월", "화", "수", "목", "금", "토" };
            string day = weekdays[(int)now.DayOfWeek];
            LblDate.Text = now.ToString("yyyy-MM-dd") + $" ({day})";
            LblTime.Text = now.ToString("HH 시 mm 분");
        }

        private void cboWeather_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboWeather.SelectedItem.ToString())
            {
                case "맑음":
                    picWeather.Image = imageList1.Images["sun"];
                    break;
                case "흐림":
                    picWeather.Image = imageList1.Images["cloudy"];
                    break;
                case "비":
                    picWeather.Image = imageList1.Images["rain"];
                    break;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            UpdateMoodUI(selectedDate);
        }

        private void UpdateMoodUI(DateTime date)
        {
            LblSelectDate.Text = $"날짜 : {date:yy/MM/dd}";

            if (!dailyData.ContainsKey(date))
                dailyData[date] = new DayData();

            txtDiary.Text = dailyData[date].Diary;

            clbTasks.Items.Clear();
            foreach (var task in dailyData[date].Tasks)
            {
                clbTasks.Items.Add(task.Content, task.Done);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string task = txtTask.Text.Trim();
            if (string.IsNullOrWhiteSpace(task)) return;

            DateTime date = monthCalendar1.SelectionStart;
            if (clbTasks.Items.Contains(task)) return;

            if (!dailyData.ContainsKey(date))
                dailyData[date] = new DayData();

            dailyData[date].Tasks.Add(new TaskItem { Content = task, Done = false });
            clbTasks.Items.Add(task, false);
            txtTask.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int selectedIndex = clbTasks.SelectedIndex;
            if (selectedIndex == -1) return;

            DateTime date = monthCalendar1.SelectionStart;
            if (!dailyData.ContainsKey(date)) return;

            clbTasks.Items.RemoveAt(selectedIndex);
            if (selectedIndex < dailyData[date].Tasks.Count)
                dailyData[date].Tasks.RemoveAt(selectedIndex);

            txtTask.Clear();
        }

        private void txtDiary_Leave(object sender, EventArgs e)
        {
            DateTime date = monthCalendar1.SelectionStart;

            if (!dailyData.ContainsKey(date))
                dailyData[date] = new DayData();

            dailyData[date].Diary = txtDiary.Text.Trim();
        }

        private void clbTasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(() =>
            {
                DateTime date = monthCalendar1.SelectionStart;

                if (!dailyData.ContainsKey(date)) return;

                for (int i = 0; i < clbTasks.Items.Count; i++)
                {
                    dailyData[date].Tasks[i].Done = clbTasks.GetItemChecked(i);
                }
            }));
        }

        private void clbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbTasks.SelectedItem != null)
            {
                txtTask.Text = clbTasks.SelectedItem.ToString();
            }
        }

        // 텍스트 저장
        private void SaveToTextFile()
        {
            using (StreamWriter writer = new StreamWriter("data.txt"))
            {
                foreach (var pair in dailyData.OrderBy(p => p.Key))
                {
                    writer.WriteLine(pair.Key.ToString("yyyy-MM-dd"));
                    writer.WriteLine($"일기: {pair.Value.Diary}");

                    foreach (var task in pair.Value.Tasks)
                    {
                        string doneMark = task.Done ? "[O]" : "[X]";
                        writer.WriteLine($"할일: {doneMark} {task.Content}");
                    }

                    writer.WriteLine(); // 구분
                }
            }
        }

        // 텍스트 불러오기
        private void LoadFromTextFile()
        {
            if (!File.Exists("data.txt")) return;

            DateTime currentDate = DateTime.MinValue;
            DayData currentDay = null;

            foreach (var line in File.ReadLines("data.txt"))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                if (DateTime.TryParse(line, out DateTime parsedDate))
                {
                    currentDate = parsedDate;
                    currentDay = new DayData();
                    dailyData[currentDate] = currentDay;
                }
                else if (line.StartsWith("일기:"))
                {
                    currentDay.Diary = line.Substring(3).Trim();
                }
                else if (line.StartsWith("할일:"))
                {
                    string contentLine = line.Substring(4).Trim();
                    bool isDone = contentLine.StartsWith("[O]");
                    string content = contentLine.Substring(3).Trim(); // [O] or [X] 제거

                    currentDay.Tasks.Add(new TaskItem
                    {
                        Content = content,
                        Done = isDone
                    });
                }
            }
        }

    }
}