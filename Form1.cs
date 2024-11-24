namespace WinFormsPictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WinFormsPictureBox.Properties.Resources.primavera;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WinFormsPictureBox.Properties.Resources.verano;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WinFormsPictureBox.Properties.Resources.otoño;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WinFormsPictureBox.Properties.Resources.invierno;
        }


    }
}
