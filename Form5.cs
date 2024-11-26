using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_app
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public string LowerLimit;
        public string UpperLimit;
        public string GuessingNumber;
        public int lL;
        public int uL;
        public int gN;
        public int answer;

        private void button1_Click(object sender, EventArgs e)
        {
            LowerLimit = textBox1.Text;
            UpperLimit = textBox2.Text;
         
            if (LowerLimit == string.Empty && UpperLimit == string.Empty)
            {
                label5.Text = "OPPS!\n You Have to put Value.";
            }

            else
            {

                 lL = int.Parse(LowerLimit);
                 uL = int.Parse(UpperLimit);
                Random rand1 = new Random();
                answer = rand1.Next(lL, uL);
            }
            
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            GuessingNumber = textBox3.Text;
            if (GuessingNumber == string.Empty)
            {
                label5.Text = "OOPS! You Fucked.";
            }
                int gN= int.Parse(GuessingNumber);
            if (answer == gN)
            {
                label5.Text = "Congratulation!\n Your guess is Correct";
            }
            else if (answer < gN)
            {
                label5.Text = "OPPS!\n Too High Value.";
            }
            else if (answer > gN)
            {
                label5.Text = "OPPS!\n Too Low Value.";
            }
        }
    }
}
