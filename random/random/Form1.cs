namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void maketea()
        {
            textBox1.Text += "1.����N�}\r\n";
            textBox1.Text += "2.�m���˶i����\r\n";
            textBox1.Text += "3.���˶i�M�l\r\n";
            textBox1.Text += "4.�[�f�c\r\n";
        }
        private void makecoffee(string v, string suger)
        {
            textBox1.Text += "1.����N�}\r\n";
            textBox1.Text += "2.�Ϊm���R"+v+"�@��\r\n";
            textBox1.Text += "3.�@�ح˶i�M�l\r\n";
            textBox1.Text += "4.�["+suger+"�}�M����\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maketea();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string suger="�L";
            if (radioButton1.Checked== true) 
            { 
                suger="3��";
            }
            else if (radioButton2.Checked == true)
            {
                suger = "5��";
            }
            else if (radioButton3.Checked == true)
            {
                suger = "7��";
            }
            else 
            {
                suger = "�L";
            }
            makecoffee("coffee",suger);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            dumpling();
        }

        private void dumpling()
        {
            textBox1.Text += "1.�ˤJ�����ѯ�\r\n";
            textBox1.Text += "2.�ˤJ�C���ѯ�\r\n";
            textBox1.Text += "3.�[�J�Q��\r\n";
            textBox1.Text += "4.�[�J����\r\n";
            textBox1.Text += "5.�|�ѹΦܪ�����\r\n";
            textBox1.Text += "6.�\�O�A��\r\n";
            textBox1.Text += "7.�����{\r\n";
            textBox1.Text += "8.���R����B\r\n";
            textBox1.Text += "9.���R��[�Q��\r\n";
            textBox1.Text += "10.�ަר�H\r\n";
            textBox1.Text += "11.�ަץ[�Q��\r\n";
            textBox1.Text += "12.�ަץ[�J����\r\n";
            textBox1.Text += "13.�ѹδ|����\r\n";
            textBox1.Text += "14.�ܦ���l��\r\n";
            textBox1.Text += "15.��l�֩٤�\r\n";
            textBox1.Text += "16.��J���`\r\n";
            textBox1.Text += "17.����\r\n";
            textBox1.Text += "18.�N��\r\n";
        }
    }

}