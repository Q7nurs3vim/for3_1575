namespace for3_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayilar.Text);

            for (int i = 0; i < sayi; i++)
            {
                lbsayi.Items.Add(i);
            }
        }
    }
}