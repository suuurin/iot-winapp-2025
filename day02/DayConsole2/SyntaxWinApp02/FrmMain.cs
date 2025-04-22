using Microsoft.VisualBasic;
using System.ComponentModel;

namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {

            // 연산자 : =, -, +, *, /, %, +=, -=, 
            // &&, ||, &, |, ^, !
            // C, C++와 동일
            int val = 2 ^ 10;

            int result = 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2;

            //MessageBox.Show(((3 > 2) && (10 < 9)).ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show(result.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void BtnMsg2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요! 메시지2 버튼을 눌렀군요?", "눌렀군요", MessageBoxButtons.OK);
        }
    }
}
