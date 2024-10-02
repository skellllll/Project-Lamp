namespace Project_Lamp
{
    public partial class Form1 : Form
    {
        private bool ButtonPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private async void Intensita(int Direction)
        {
            ButtonPressed = true;
            while (ButtonPressed)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + Direction);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + Direction);
                await Task.Delay(100);
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            Intensita(-1);
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            Intensita(1);
        }
        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonPressed = false;
        }
    }
}