namespace Sim70
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void rtbAbout_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm.OpenBrowser("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.OpenBrowser("https://github.com/LKD70/SIM70");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.OpenBrowser("https://paypal.me/LKDVPS");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm.OpenBrowser("https://github.com/sponsors/lkd70");
        }
    }
}
