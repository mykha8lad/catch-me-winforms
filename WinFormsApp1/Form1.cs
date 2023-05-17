namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random random;

        public Form1()
        {
            InitializeComponent();
            random = new();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            int newX = random.Next(ClientSize.Width - button1.Width);
            int newY = random.Next(ClientSize.Height - button1.Height);
            
            button1.Location = new Point(newX, newY);
        }
    }
}