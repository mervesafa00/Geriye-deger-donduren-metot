namespace Geriye_değer_döndüren_metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Toplama(int sayi1, int sayi2)
        {
            int sayi3 = sayi1 + sayi2;
            return sayi3;
        }
        int Cikarma(int sayi1, int sayi2)
        {
            int sayi3 = sayi1 - sayi2;
            return sayi3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Toplama(50, 10).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = Cikarma(50, 10).ToString();
        }
    }
}
