using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            KayıtEkranı kayıtEkran= new KayıtEkranı();
            kayıtEkran.Show();
            this.Show();
        }
    }
}
