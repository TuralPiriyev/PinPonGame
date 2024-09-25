namespace PinPon
{
    partial class Form2
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
            panel1 = new Panel();
            panel2 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            boundaryTop = new Panel();
            boundaryUp = new Panel();
            boundaryLeft = new Panel();
            boundaryRight = new Panel();
            Top = new Panel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(35, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(18, 176);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Location = new Point(425, 251);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 176);
            panel2.TabIndex = 1;
            // 
            // boundaryTop
            // 
            boundaryTop.BackColor = SystemColors.ActiveCaption;
            boundaryTop.Location = new Point(2, 61);
            boundaryTop.Name = "boundaryTop";
            boundaryTop.Size = new Size(476, 10);
            boundaryTop.TabIndex = 2;
            // 
            // boundaryUp
            // 
            boundaryUp.BackColor = SystemColors.ActiveCaption;
            boundaryUp.Location = new Point(2, 475);
            boundaryUp.Name = "boundaryUp";
            boundaryUp.Size = new Size(476, 10);
            boundaryUp.TabIndex = 3;
            // 
            // boundaryLeft
            // 
            boundaryLeft.BackColor = SystemColors.ActiveCaption;
            boundaryLeft.Location = new Point(2, 70);
            boundaryLeft.Name = "boundaryLeft";
            boundaryLeft.Size = new Size(10, 412);
            boundaryLeft.TabIndex = 4;
            // 
            // boundaryRight
            // 
            boundaryRight.BackColor = SystemColors.ActiveCaption;
            boundaryRight.Location = new Point(468, 61);
            boundaryRight.Name = "boundaryRight";
            boundaryRight.Size = new Size(10, 417);
            boundaryRight.TabIndex = 5;
            // 
            // Top
            // 
            Top.BackColor = Color.Red;
            Top.Location = new Point(211, 101);
            Top.Name = "Top";
            Top.Size = new Size(27, 31);
            Top.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 7;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 23);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 479);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Top);
            Controls.Add(boundaryRight);
            Controls.Add(boundaryLeft);
            Controls.Add(boundaryUp);
            Controls.Add(boundaryTop);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimizeBox = false;
            Name = "Form2";
            Text = "PinPon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel boundaryTop;
        private Panel boundaryUp;
        private Panel boundaryLeft;
        private Panel boundaryRight;
        private Panel Top;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}