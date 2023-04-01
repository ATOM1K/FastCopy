namespace FastCopy
{
    public partial class FastCopy : Form
    {
        public FastCopy()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clipboard.Clear();
            try
            {
                Clipboard.SetText(richTextBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Cant copy - empty");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            try
            {
                Clipboard.SetText(richTextBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Cant copy - empty");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            try
            {
                Clipboard.SetText(richTextBox3.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Cant copy - empty");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            try
            {
                Clipboard.SetText(richTextBox4.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Cant copy - empty");
            }
        }
    }
}