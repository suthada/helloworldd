namespace suthadaProject01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBoxF.Text;
            double f = Convert.ToDouble(input);
            double c = (f - 32) * 5 / 9;
            textboxC.Text = c.ToString();
        }

        private void F_Click(object sender, EventArgs e)
        {

        }

        private void textboxC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textboxC.Text;
            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;

            textBoxF.Text = f.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textboxC.ResetText();
            textBoxF.ResetText();
        }
    }
}