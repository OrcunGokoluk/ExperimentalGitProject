namespace FirstGitProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Git!");
            MessageBox.Show("Hello Git1!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test3");
        }
    }
}
