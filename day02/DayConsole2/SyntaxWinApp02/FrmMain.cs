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

            // ������ : =, -, +, *, /, %, +=, -=, 
            // &&, ||, &, |, ^, !
            // C, C++�� ����
            int val = 2 ^ 10;

            int result = 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2;

            //MessageBox.Show(((3 > 2) && (10 < 9)).ToString(), "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show(result.ToString(), "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void BtnMsg2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�ȳ��ϼ���! �޽���2 ��ư�� ��������?", "��������", MessageBoxButtons.OK);
        }
    }
}
