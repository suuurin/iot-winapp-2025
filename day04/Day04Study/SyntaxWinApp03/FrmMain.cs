//using static System.Net.Mime.MediaTypeNames;

namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        private string filePath = "Sample.rtf";     // Rich Text Format(msWord ����)

        private ColorDialog DlgColor = new ColorDialog();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //string filePath = "sample.txt"; // ���� ����
            DlgSave.FileName = string.Empty;
            DlgSave.Filter = "RTF����(*.rtf)|*.rtf|Txt����(*.txt)|*.txt";
            DlgSave.Title = "�������� ����";

            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string fullPath = DlgSave.FileName;
                    string ext = Path.GetExtension(fullPath);   // .rtf, .txt

                    if (ext == ".rtf")
                        RtbNote.SaveFile(fullPath, RichTextBoxStreamType.RichText);
                    else if (ext == ".txt")
                        RtbNote.SaveFile(fullPath, RichTextBoxStreamType.PlainText);

                    MessageBox.Show("������ ����Ǿ����ϴ�.", "��������",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"���� ���� : {ex.Message}", "��������",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //try
            //{
            //    // 1. File ���� ���õ� �޼��尡 ���Ե� Ŭ����
            //    // �Ϲ� Txt���� ����
            //    //File.WriteAllText(filePath, RtbNote.Text);

            //    // 2. Rich Text Format���� ����
            //    RtbNote.SaveFile(filePath, RichTextBoxStreamType.RichText);
                
            //    MessageBox.Show("������ ����Ǿ����ϴ�.", "��������",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"���� ���� : {ex.Message}", "��������",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //string filePath = "sample.txt";     // �о�� ����
            // 3. OpenFileDialog ���
            DlgOpen.FileName = string.Empty;    // == "";
            DlgOpen.Filter = "RTF����(*.rtf)|*.rtf|Txt����(*.txt)|*.txt";
            DlgOpen.Title = "RTF���� �б�";

            // ���̾�α�â ����(DialogResult.OK), ���(DialogResult.Cancel)
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fullPath = DlgOpen.FileName;
                    string ext = Path.GetExtension(fullPath);   // .rtf, .txt

                    if (ext == ".rtf")
                        RtbNote.LoadFile(DlgOpen.FileName, RichTextBoxStreamType.RichText);
                    else if (ext == ".txt")
                        RtbNote.LoadFile(DlgOpen.FileName, RichTextBoxStreamType.PlainText);

                    //RtbNote.LoadFile(DlgOpen.FileName, RichTextBoxStreamType.RichText);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"�б� ���� : {ex.Message}", "�����б�",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //try
            //{
            //    if (File.Exists(filePath))
            //    {

            //        // 1. �Ϲ� �ؽ�Ʈ �ε�
            //        // + �߰� (RtbNote.Rtf)�ϸ� �������� �����ε�, ������ ���ϰ� �� �� ������, �ǹ� X
            //        //string content = File.ReadAllText(filePath);
            //        //RtbNote.Text = content;

            //        // 2. Rich Text Format �ε�
            //        RtbNote.LoadFile(filePath, RichTextBoxStreamType.RichText);
            //    }
            //    else
            //    {
            //        MessageBox.Show("������ �������� �ʽ��ϴ�.", "�����б�",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"�б� ���� : {ex.Message}", "�����б�",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            // ����θ� �߰�
            //RtbNote.SelectionColor = Color.Red;

            // ���� ��� 
            //if (RtbNote.SelectionColor == Color.Red)
            //{
            //    RtbNote.SelectionColor = Color.Black; // �ٽ� ������ ���� ������
            //}
            //else
            //{
            //    RtbNote.SelectionColor = Color.Red;
            //}
            if (RtbNote.SelectionLength > 0)
            {
                if (DlgColor.ShowDialog() == DialogResult.OK)
                {
                    RtbNote.SelectionColor = DlgColor.Color;

                    BtnRed.BackColor = DlgColor.Color;
                }
            }
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            Font currFont = RtbNote.SelectionFont;
            FontStyle newStyle;

            if (currFont.Bold)
            {
                newStyle = currFont.Style & ~FontStyle.Bold;    // Bold ����
            }
            else
            {
                newStyle = currFont.Style | FontStyle.Bold; // Bold �߰�
            }
            RtbNote.SelectionFont = new Font(currFont, newStyle);
        }
    }
}
