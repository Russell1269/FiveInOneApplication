using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_app
{
    public partial class Form4 : Form
    {
        private DateTime startTime;

        public Form4()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            formTimer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formTimer.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formTimer.Stop();
            label1.Text = "00:00:00";
        }

        private void formTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - startTime;
            label1.Text = ts.ToString(@"mm\:ss\.ff");
        }
    }
}
