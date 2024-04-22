namespace pain11._2
{
    public partial class Form1 : Form
    {
        Order OrderGen()
        {
            Order Gen = new Order();
            Random SenderGen = new Random();
            Random RecipientGen = new Random();
            Random SumGen = new Random();
            Gen.sender = SenderGen.Next(100000, 999999);
            Gen.recipient = RecipientGen.Next(100000, 999999);
            Gen.sum = SumGen.Next(5000000);
            return Gen;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) { listBox1.Items.Add(OrderGen()); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
            listBox1.Sorted = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 manual = new Form2();
            Order order = new Order();
            manual.ShowDialog();
            manual.TopMost = true;
            order.sender = manual.Sender;
            order.recipient = manual.Recipient;
            order.sum = manual.Sum;
            listBox1.Items.Add(order);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\Yadernt\\source\\repos\\pain11.2\\list.txt");
            for (int i = 0; i < listBox1.Items.Count; i++) { sw.WriteLine(listBox1.Items[i]); }
            sw.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            StreamReader sw = new StreamReader("C:\\Users\\Yadernt\\source\\repos\\pain11.2\\list.txt");
            int c = 0;
            while (sw.ReadLine() != null)
            {
                c++;
            }
            sw.Close();
            StreamReader sw2 = new StreamReader("C:\\Users\\Yadernt\\source\\repos\\pain11.2\\list.txt");
            for (int i = 0; i < c; i++) { listBox1.Items.Add(sw2.ReadLine()); }
            sw2.Close();
        }
    }
    struct Order
    {
        public int sender;
        public int recipient;
        public int sum;
        public override string ToString()
        {
            return $"¹{sender}                    ¹{recipient}               {sum} ð.";
        }
    }
}
