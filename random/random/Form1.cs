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
            textBox1.Text += "1.把水煮開\r\n";
            textBox1.Text += "2.沸水倒進茶葉\r\n";
            textBox1.Text += "3.茶倒進杯子\r\n";
            textBox1.Text += "4.加檸檬\r\n";
        }
        private void makecoffee(string v, string suger)
        {
            textBox1.Text += "1.把水煮開\r\n";
            textBox1.Text += "2.用沸水沖"+v+"咖啡\r\n";
            textBox1.Text += "3.咖啡倒進杯子\r\n";
            textBox1.Text += "4.加"+suger+"糖和牛奶\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maketea();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string suger="無";
            if (radioButton1.Checked== true) 
            { 
                suger="3分";
            }
            else if (radioButton2.Checked == true)
            {
                suger = "5分";
            }
            else if (radioButton3.Checked == true)
            {
                suger = "7分";
            }
            else 
            {
                suger = "無";
            }
            makecoffee("coffee",suger);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            dumpling();
        }

        private void dumpling()
        {
            textBox1.Text += "1.倒入高筋麵粉\r\n";
            textBox1.Text += "2.倒入低筋麵粉\r\n";
            textBox1.Text += "3.加入鹽巴\r\n";
            textBox1.Text += "4.加入熱水\r\n";
            textBox1.Text += "5.揉麵團至表面光滑\r\n";
            textBox1.Text += "6.蓋保鮮膜\r\n";
            textBox1.Text += "7.醒麵糰\r\n";
            textBox1.Text += "8.高麗菜切丁\r\n";
            textBox1.Text += "9.高麗菜加鹽巴\r\n";
            textBox1.Text += "10.豬肉剁碎\r\n";
            textBox1.Text += "11.豬肉加鹽巴\r\n";
            textBox1.Text += "12.豬肉加入薑末\r\n";
            textBox1.Text += "13.麵團揉均勻\r\n";
            textBox1.Text += "14.變成餃子皮\r\n";
            textBox1.Text += "15.餃子皮抹水\r\n";
            textBox1.Text += "16.放入內餡\r\n";
            textBox1.Text += "17.捏緊\r\n";
            textBox1.Text += "18.煮熟\r\n";
        }
    }

}