namespace Sinema_Satis_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,toplam;
            misir = Convert.ToInt16(textBox1.Text);
            bilet = Convert.ToInt16(textBox2.Text);
            su = Convert.ToInt16(textBox3.Text);  
            cay = Convert.ToInt16(textBox4.Text);

            toplam = misir * 4 + su * 1 + cay * 2 + bilet * 8;
            label11.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            label12.Text = kasatutar.ToString()+ "TL";



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();

        }
    }
}