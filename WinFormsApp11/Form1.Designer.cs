namespace WinFormsApp11
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            num2 = new NumericUpDown();
            num1 = new NumericUpDown();
            symbLine = new TextBox();
            button4 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            nameToCount = new TextBox();
            path = new TextBox();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(36, 40);
            button1.Name = "button1";
            button1.Size = new Size(106, 41);
            button1.TabIndex = 0;
            button1.Text = "Ex 1 and 2;";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1Click;
            // 
            // button2
            // 
            button2.Location = new Point(226, 46);
            button2.Name = "button2";
            button2.Size = new Size(101, 35);
            button2.TabIndex = 1;
            button2.Text = "Ex 3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2Click;
            // 
            // button3
            // 
            button3.Location = new Point(447, 46);
            button3.Name = "button3";
            button3.Size = new Size(101, 35);
            button3.TabIndex = 2;
            button3.Text = "Ex 4";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(num2);
            panel1.Controls.Add(num1);
            panel1.Controls.Add(symbLine);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(191, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 85);
            panel1.TabIndex = 3;
            panel1.Visible = false;
            // 
            // num2
            // 
            num2.Location = new Point(134, 20);
            num2.Name = "num2";
            num2.Size = new Size(35, 23);
            num2.TabIndex = 3;
            // 
            // num1
            // 
            num1.Location = new Point(13, 20);
            num1.Name = "num1";
            num1.Size = new Size(35, 23);
            num1.TabIndex = 2;
            // 
            // symbLine
            // 
            symbLine.Location = new Point(73, 20);
            symbLine.Name = "symbLine";
            symbLine.Size = new Size(39, 23);
            symbLine.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(56, 49);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            button4.Text = "Submit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(nameToCount);
            panel2.Controls.Add(path);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(396, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 167);
            panel2.TabIndex = 4;
            panel2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 52);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter name of file:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 3);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter dirr(full path):";
            // 
            // nameToCount
            // 
            nameToCount.Location = new Point(14, 75);
            nameToCount.Name = "nameToCount";
            nameToCount.Size = new Size(88, 23);
            nameToCount.TabIndex = 1;
            // 
            // path
            // 
            path.Location = new Point(14, 26);
            path.Name = "path";
            path.Size = new Size(153, 23);
            path.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(51, 130);
            button5.Name = "button5";
            button5.Size = new Size(101, 24);
            button5.TabIndex = 0;
            button5.Text = "Submit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5Click;
            // 
            // button6
            // 
            button6.Location = new Point(60, 292);
            button6.Name = "button6";
            button6.Size = new Size(488, 49);
            button6.TabIndex = 5;
            button6.Text = "Close";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 384);
            Controls.Add(button6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num2).EndInit();
            ((System.ComponentModel.ISupportInitialize)num1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private NumericUpDown num2;
        private NumericUpDown num1;
        private TextBox symbLine;
        private Button button4;
        private Panel panel2;
        private Button button5;
        private TextBox nameToCount;
        private TextBox path;
        private Label label2;
        private Label label1;
        private Button button6;
    }
}