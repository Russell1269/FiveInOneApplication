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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string inFeet = "";
        private string inInch = "";
        private void button1_Click(object sender, EventArgs e)
        {
            inFeet = heightInFeetOfUser.Text;
            inInch = heightInInchOfUser.Text;
            double feet = double.Parse(inFeet);
            double inch = double.Parse(inInch);
            double rOfMeter = (((feet * 12) + inch) / 12) * 0.3048;
            meter.Text = $"Your Height In Meter is : {rOfMeter}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
