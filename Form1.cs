using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinPon
{
    public class Form1 : Form
    {
        private Form2 parentForm;

        public Form1(Form2 form2)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            parentForm = form2;
        }
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void InitializeComponent()
        {
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 46);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 0;
            label2.Text = "Click The Button!";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(88, 123);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(282, 253);
            Controls.Add(button2);
            Controls.Add(label2);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Form2 form2 = new Form2();
                form2.Show();

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private Label label1;
        private Label label2;
        private Button button2;
        private Button button1;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
