using System.Diagnostics.Tracing;

namespace pain10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { }
            else
            {
                int n = int.Parse(textBox1.Text);
                double res = 0;
                if (checkedListBox1.GetItemChecked(0))
                {
                    for (int i = 0; i < n + 1; i++) { res = res + Math.Pow(i, 4); }
                }
                if (checkedListBox1.GetItemChecked(1))
                {
                    res = n * (n + 1) * (2 * n + 1) * (3 * Math.Pow(n, 2) + 3 * n - 1) / 30;
                }
                label3.Text = $"Ñóììà = {res}";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
