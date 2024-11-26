using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_app
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            string task = this.textTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                this.listBox1.Items.Add(task);
                this.textTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            { this.listBox1.Items.Remove(this.listBox1.SelectedItem); }
            else
            { MessageBox.Show("Please select a task to remove."); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}