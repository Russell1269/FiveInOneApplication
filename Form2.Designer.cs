namespace test_app
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            meter = new Label();
            btn = new Button();
            heightInInchOfUser = new TextBox();
            label3 = new Label();
            heightInFeetOfUser = new TextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(426, 36);
            label1.TabIndex = 0;
            label1.Text = "Feet to Meter Converter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(155, 81);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 1;
            label2.Text = "Enter Feet Value";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(meter);
            panel1.Controls.Add(btn);
            panel1.Controls.Add(heightInInchOfUser);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(heightInFeetOfUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(221, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 478);
            panel1.TabIndex = 2;
            // 
            // meter
            // 
            meter.AutoSize = true;
            meter.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            meter.Location = new Point(0, 367);
            meter.Name = "meter";
            meter.Size = new Size(0, 28);
            meter.TabIndex = 6;
            // 
            // btn
            // 
            btn.BackColor = Color.Purple;
            btn.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn.ForeColor = Color.Black;
            btn.Location = new Point(109, 293);
            btn.Name = "btn";
            btn.Size = new Size(209, 52);
            btn.TabIndex = 5;
            btn.Text = "Convert";
            btn.UseVisualStyleBackColor = false;
            btn.Click += button1_Click;
            // 
            // heightInInchOfUser
            // 
            heightInInchOfUser.BorderStyle = BorderStyle.FixedSingle;
            heightInInchOfUser.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heightInInchOfUser.ForeColor = Color.Purple;
            heightInInchOfUser.Location = new Point(142, 225);
            heightInInchOfUser.Name = "heightInInchOfUser";
            heightInInchOfUser.Size = new Size(163, 32);
            heightInInchOfUser.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(155, 186);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 3;
            label3.Text = "Enter Inch Value";
            // 
            // heightInFeetOfUser
            // 
            heightInFeetOfUser.BorderStyle = BorderStyle.FixedSingle;
            heightInFeetOfUser.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heightInFeetOfUser.Location = new Point(142, 128);
            heightInFeetOfUser.Name = "heightInFeetOfUser";
            heightInFeetOfUser.Size = new Size(163, 32);
            heightInFeetOfUser.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Purple;
            button2.Location = new Point(756, 568);
            button2.Name = "button2";
            button2.Size = new Size(150, 29);
            button2.TabIndex = 3;
            button2.Text = "BMI Calculator";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(918, 609);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button btn;
        private TextBox heightInInchOfUser;
        private Label label3;
        private TextBox heightInFeetOfUser;
        private Label meter;
        private Button button2;
    }
}