namespace Lab1Ver2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.AntiqueWhite;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                Console.WriteLine("pass");
                MessageBox.Show("������ �� �������", "�������!");
            }
            else
                button1.Text = textBox2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                Console.WriteLine("pass");
                MessageBox.Show("������ �� �������", "�������!");
            }
            else
                button2.Text = textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                Console.WriteLine("pass");
                MessageBox.Show("������ �� �������", "�������!");
            }
            else
            {

                button3.Text = textBox2.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                Console.WriteLine("pass");
                MessageBox.Show("������ �� �������","�������!");
            }
            else
                button4.Text = textBox2.Text;
        }
    }
}