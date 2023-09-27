using DiyetProgramı.BLL.Concrete;
using DiyetProgramı.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetProgramı.PL
{
    public partial class GirişEkranı : Form
    {
        public GirişEkranı()
        {
            InitializeComponent();
        }

        private void GirişEkranı_Load(object sender, EventArgs e)
        {

            panel2.Visible = false;
            MessageBox.Show("Sağlıklı bir yaşam için ön koşul doğru ve dengeli beslenmektir.\r\n Beslenme konusuna detaylı bakacak olursak tükettiğimiz  yiyeceklerin kalorisini bilmek ve aşırı kalori içeren işlenmiş gıdalardan kaçınmak bu \r\ndengeyi sağlamanın en kolay yollarından biridir.\r\n Araştırmalar gösteriyor ki kalori takibini yapabilen insanlar daha az kalorili \r\nyiyecekler tüketerek kilolarını dengede tutmayı başarıyorlar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = KullaniciAdiTextBox.Text;
            string sifre = SifreTextBox.Text;
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            //this.Visible = false;
            //KayıtEkranı kayıtEkran = new KayıtEkranı();
            //kayıtEkran.ShowDialog();
            //this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {




            string kullaniciMail = kullaniciMailTextBox.Text;
            string kullaniciSifre = kullaniciSifreTextBox.Text;
            string kullaniciSifreTekrari = kullaniciSifreTekrariTextBox.Text;
            string isim = isimTextBox.Text;
            string soyisim = soyisimTextBox.Text;
            int yas = Convert.ToInt32(yasTextBox.Text);
            double boy = Convert.ToInt32(boyTextBox.Text);
            decimal kilo = Convert.ToDecimal(kiloTextBox.Text);

            KullaniciManager kullanici = new KullaniciManager(new KullaniciRepo(1));



            var termpString = string.Empty;
            if (!kullanici.ValidUser(kullaniciMail) || !kullanici.ValidMail(kullaniciMail))
            {
                termpString += "Kullanıcı mail hatalı";
            }
            if (string.IsNullOrWhiteSpace(kullaniciSifre) || string.IsNullOrWhiteSpace(kullaniciMail) || string.IsNullOrWhiteSpace(kullaniciSifreTekrari) || string.IsNullOrWhiteSpace(isim) || string.IsNullOrWhiteSpace(soyisim))
            {
               
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            



            panel2.Visible = false;
            panel1.Visible = true;


        }

        private void kullaniciMailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
