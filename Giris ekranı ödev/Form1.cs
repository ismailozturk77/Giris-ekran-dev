namespace Giris_ekranı_ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kullaniciAdi = "ismailOzturk";
            String sifre = "12345";

            if(textBox1.Text == kullaniciAdi && textBox2.Text == sifre)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }else
            {
                MessageBox.Show("kullanıcı adı veya şifre hatalı");
            }
        }
    }
}