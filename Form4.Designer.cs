namespace test_app
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            formTimer = new System.Windows.Forms.Timer(components);
            bindingSource1 = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(120, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 321);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.Font = new Font("Arial Rounded MT Bold", 15.75F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(261, 232);
            button3.Name = "button3";
            button3.Size = new Size(117, 42);
            button3.TabIndex = 4;
            button3.Text = "Stop";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Purple;
            button2.Font = new Font("Arial Rounded MT Bold", 15.75F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(408, 232);
            button2.Name = "button2";
            button2.Size = new Size(117, 42);
            button2.TabIndex = 3;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.Font = new Font("Arial Rounded MT Bold", 15.75F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(120, 232);
            button1.Name = "button1";
            button1.Size = new Size(117, 42);
            button1.TabIndex = 2;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(225, 19);
            label2.Name = "label2";
            label2.Size = new Size(203, 36);
            label2.TabIndex = 1;
            label2.Text = "Stop Watch";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 84);
            label1.Name = "label1";
            label1.Size = new Size(308, 81);
            label1.TabIndex = 0;
            label1.Text = "00:00:00";
            // 
            // formTimer
            // 
            formTimer.Interval = 10;
            formTimer.Tick += formTimer_Tick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(330, 479);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(902, 570);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer formTimer;
        private BindingSource bindingSource1;
        private DateTimePicker dateTimePicker1;
    }
}