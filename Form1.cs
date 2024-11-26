using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private String height = "";
        private String weight = "";
        private string inFeet = "";
        private string inInch = "";
        private void button5_Click(object sender, EventArgs e)
        {
            height = textBox5.Text;
            weight = textBox3.Text;
            if (height == string.Empty || weight == string.Empty)
            {
                MessageBox.Show("please Enter Proper Value");
            }
            else
            {
                double h = double.Parse(height);
                double w = double.Parse(weight);
                double result = (w) / (h * h);
                if (result < 0)
                {
                    MessageBox.Show("Something went Wrong");
                }
                else if (result < 18.5)
                {
                    MessageBox.Show($"Under Weight! \nBMI Score : {result}");
                    output.Text = $"Possibly malnourished!\nBMI Score : {result}";
                    advice.Text = "1) Eating more frequently \n" +
                   "2) Choosing food with lots of nutrients.\n" +
                   "3) Add extras to your dishes for more calories.\n" +
                   "4) Exercise.";

                }

                else if (18.5 < result && result < 24.9)
                {
                    MessageBox.Show($"Normal weight! \nBMI Score : {result}");
                    output.Text = $"Least risk of developing health problems.\nBMI Score : {result}";
                    advice.Text = "1) Ensure you get 7-9 hours of quality sleep each night.\n" +
                        "2) Balanced Diet.\n" +
                        "3) Regular Exercise.\n" +
                        "4) Drink plenty of water throughout the day.\n" +
                        "5) Pay attention to what you eat and savor each bite.";
                }
                else if (24.9 < result && result < 29.9)
                {
                    MessageBox.Show($"Overweight!\nBMI Score : {result}");
                    output.Text = $"Increased risk of developing health problems.\nBMI Score : {result}";
                    advice.Text = "1) Balanced Diet.\n" +
                       "2) Be mindful of serving sizes and avoid overeating.\n" +
                       "3) Aim for at least 150 minutes of moderate aerobic activity or 75 minutes of vigorous activity each week.\n" +
                       "4) Stay Hydrated.\n" +
                       "5) Stress Management.";
                }
                else if (30 < result)
                {
                    MessageBox.Show($"Very Much Overweight!\nBMI Score : {result}");
                    advice.Text = $"Go To Hell.\nBMI Score : {result}";
                }

            }

            height = "";
            weight = "";
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form3());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form5());
        }
    }
}

