namespace MoodPlan
{

    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private Dictionary<DateTime, string> moodData = new Dictionary<DateTime, string>();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timerClock.Start(); // 타이머 시작
            UpdateDateTime();   // 첫 표시도 갱신

            // 오늘 날짜로 선택 초기화
            DateTime today = DateTime.Today;
            monthCalendar1.SelectionStart = today;

            UpdateMoodUI(today); // 화면에 오늘 날짜/기분 표시
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            DateTime now = DateTime.Now;
            string[] weekdays = { "일", "월", "화", "수", "목", "금", "토" };
            string day = weekdays[(int)now.DayOfWeek];  // 요일 인덱스 → 한글 요일

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
            UpdateMoodUI(selectedDate); // 날짜 선택 시 UI 갱신
        }

        private void UpdateMoodUI(DateTime date)
        {
            string mood = moodData.ContainsKey(date.Date) ? moodData[date.Date] : "보통";

            LblSelectDate.Text = $"날짜 : {date:yy/MM/dd}";
            cboMood.SelectedItem = mood;

            // PictureBox는 이모지 대신 이미지로 보여주고 싶을 경우
            if (mood.Contains("행복"))
                picMood.Image = imageList1.Images["happy"];
            else if (mood.Contains("보통"))
                picMood.Image = imageList1.Images["normal"];
            else if (mood.Contains("우울"))
                picMood.Image = imageList1.Images["sad"];
            else if (mood.Contains("분노"))
                picMood.Image = imageList1.Images["angry"];
        }
    }
}
