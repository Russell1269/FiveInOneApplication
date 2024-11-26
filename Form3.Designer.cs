namespace test_app
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button2 = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            textTextBox = new TextBox();
            label1 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(236, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 523);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Purple;
            button2.Location = new Point(268, 480);
            button2.Name = "button2";
            button2.Size = new Size(108, 27);
            button2.TabIndex = 4;
            button2.Text = "Remove Task";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.Purple;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(42, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(298, 365);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Purple;
            button1.Location = new Point(190, 478);
            button1.Name = "button1";
            button1.Size = new Size(72, 31);
            button1.TabIndex = 2;
            button1.Text = "Add Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textTextBox
            // 
            textTextBox.BorderStyle = BorderStyle.FixedSingle;
            textTextBox.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTextBox.ForeColor = Color.Purple;
            textTextBox.Location = new Point(19, 480);
            textTextBox.Name = "textTextBox";
            textTextBox.Size = new Size(165, 27);
            textTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 20);
            label1.Name = "label1";
            label1.Size = new Size(165, 36);
            label1.TabIndex = 0;
            label1.Text = "To Do App";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Purple;
            button3.Location = new Point(726, 27);
            button3.Name = "button3";
            button3.Size = new Size(155, 38);
            button3.TabIndex = 5;
            button3.Text = "BMI Calculator";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(902, 570);
            Controls.Add(button3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox textTextBox;
        private Label label1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
    }
}