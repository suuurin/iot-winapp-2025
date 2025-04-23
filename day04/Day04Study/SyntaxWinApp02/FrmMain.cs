namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // ������ DB���� �����ͷε� �� �Ʒ��� �۾����� ����
            // �迭 ����
            string[] fruits = { "���", "�ٳ���", "����", "����", "��纣��" };
            CboArray.Items.Clear();
            CboArray.Items.AddRange(fruits);  // �迭�� �޺��ڽ��� �Ҵ�
            //CboArray.SelectedIndex = 0;

            // ����Ʈ ���� - �� ����� �� ����
            List<string> lFruits = ["���", "����ƾ", "���ø���", "�ڸ�", "�θ���"];

            /*  List<string> lFruits = new List<string>();
                lFruits.Add("���");
                lFruits.Add("����ƾ");
                lFruits.Add("���ø���");
                lFruits.Add("�ڸ�"); */
            CboList.DataSource = lFruits;

            // ��ųʸ� ���� - DB �ڵ鸵�� ���� ���� ���Ǵ� ���
            Dictionary<string, string> dCountry = new Dictionary<string, string>()
            {
                {"KR", "���ѹα�"},
                {"US", "�̱�"},
                {"JP", "�Ϻ�"},
                {"CN", "�߱�"},
                {"IN", "�ε�"},
                {"PH", "�߸�"}
            };
            CboDictionary.DataSource = new BindingSource(dCountry, null);
            CboDictionary.DisplayMember = "Value";  // ����ڿ��� ���̴� �̸�
            CboDictionary.ValueMember = "Key";      // ���������� ���õǴ� ��
            CboDictionary.SelectedIndex = 0;

            // foreach�� �ݺ�ó��
            string result = "";
            foreach (var item in dCountry)
            {
                Console.WriteLine(item.ToString());
                //Console.WriteLine($"{item.Key}, {item.Value}");
            }
        }

        private void CboArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = CboArray.SelectedItem.ToString();
            MessageBox.Show($"������ ������ {selected}�Դϴ�", "�����ϴ� ����",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = CboList.SelectedItem.ToString();
            MessageBox.Show(selected, "���õ� ����",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CboDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kvp = (KeyValuePair<string, string>)CboDictionary.SelectedItem;
            string key = kvp.Key;
            string value = kvp.Value;

            MessageBox.Show($"���õ� Ű�� {key}, ���� {value}", "���õȱ���",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
