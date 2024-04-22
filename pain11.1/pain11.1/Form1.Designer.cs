namespace pain11._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            hScrollBar1 = new HScrollBar();
            nOut = new Label();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 0;
            label1.Text = "Выбирите n:";
            // 
            // hScrollBar1
            // 
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Location = new Point(167, 19);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(664, 25);
            hScrollBar1.TabIndex = 1;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // nOut
            // 
            nOut.AutoSize = true;
            nOut.Font = new Font("Segoe UI", 14F);
            nOut.Location = new Point(850, 12);
            nOut.Name = "nOut";
            nOut.Size = new Size(0, 32);
            nOut.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(14, 84);
            label2.Name = "label2";
            label2.Size = new Size(234, 32);
            label2.TabIndex = 3;
            label2.Text = "Выбирите формулу:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 14F);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "1^(2)-3^(2)+5^(2)-...+(-1)^(n)(2n+1)^(2)", "(-1)^(n)2(n+1)^(2)-(1+(-1^(n)))/2" });
            checkedListBox1.Location = new Point(14, 121);
            checkedListBox1.Margin = new Padding(3, 4, 3, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(463, 72);
            checkedListBox1.TabIndex = 4;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(377, 261);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(171, 51);
            button1.TabIndex = 5;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 14F);
            result.Location = new Point(14, 343);
            result.Name = "result";
            result.Size = new Size(0, 32);
            result.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(result);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(label2);
            Controls.Add(nOut);
            Controls.Add(hScrollBar1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private HScrollBar hScrollBar1;
        private Label nOut;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private Label result;
    }
}
