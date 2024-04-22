namespace pain11._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = hScrollBar1.Value;
            double res = 0;
            if (checkedListBox1.GetItemChecked(0))
            {
                for (int i = 0; i < n + 1; i++) { res = res + Math.Pow(-1, i) * Math.Pow((2 * i + 1), 2); }
            }
            if (checkedListBox1.GetItemChecked(1))
            {
                res = Math.Pow(-1, n) * 2 * Math.Pow((n + 1), 2) - (1 + Math.Pow(-1, n)) / 2;
            }
            result.Text = $"Ñóììà = {res}";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            double n = hScrollBar1.Value;
            nOut.Text = n.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
