using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pain11._2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int Sender
        {
            get { return Convert.ToInt32(textBox1.Text); }
        }
        public int Recipient
        {
            get { return Convert.ToInt32(textBox2.Text); }
        }
        public int Sum
        {
            get { return Convert.ToInt32(textBox3.Text); }
        }
    }
}
