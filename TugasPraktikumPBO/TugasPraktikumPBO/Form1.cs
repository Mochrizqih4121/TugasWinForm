namespace TugasPraktikumPBO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ari" && textBox2.Text == "Ari123")
            {
                new Beranda().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah!!!");
            }
        }
    }
}