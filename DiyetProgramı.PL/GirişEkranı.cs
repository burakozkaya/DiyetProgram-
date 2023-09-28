﻿using DiyetProgramı.BLL.Concrete;
using DiyetProgramı.DAL.Concrete;
using DiyetProgramı.Entities.Concrete;
using DiyetProgramı.Entities.Enum;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DiyetProgramı.PL
{
    public partial class GirişEkranı : Form
    {

        private int UserId;
        private KullaniciManager kullaniciManager;
        private OgunManager ogunManager;
        private YemekManager yemekManager;
        public GirişEkranı()
        {
            InitializeComponent();
            kullaniciManager = new KullaniciManager(new KullaniciRepo());

        }

        private void GirişEkranı_Load(object sender, EventArgs e)
        {

            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;


            MessageBox.Show("Sağlıklı bir yaşam için ön koşul doğru ve dengeli beslenmektir.\r\n Beslenme konusuna detaylı bakacak olursak tükettiğimiz  yiyeceklerin kalorisini bilmek ve aşırı kalori içeren işlenmiş gıdalardan kaçınmak bu \r\ndengeyi sağlamanın en kolay yollarından biridir.\r\n Araştırmalar gösteriyor ki kalori takibini yapabilen insanlar daha az kalorili \r\nyiyecekler tüketerek kilolarını dengede tutmayı başarıyorlar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = KullaniciAdiTextBox.Text;
            string sifre = SifreTextBox.Text;
            string termpSitring = string.Empty;
            if (!kullaniciManager.UserLogin(kullaniciAdi, sifre))
            {
                termpSitring += "kullanici adi veya sifre hatasi";
            }

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                termpSitring += "Lütfen tüm alanları doldurun.";
                return;
            }

            if (termpSitring == string.Empty)
            {
                UserId = kullaniciManager.UserId(kullaniciAdi);
                MessageBox.Show("giriş başarılı");
                panel1.Visible = false;
                panel3.Visible = true;
            }
            else
            {
                MessageBox.Show(termpSitring);
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Visible = false;
            panel2.Visible = true;
            //this.Visible = false;
            //KayıtEkranı kayıtEkran = new KayıtEkranı();
            //kayıtEkran.ShowDialog();
            //this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();



            string kullaniciMail = kullaniciMailTextBox.Text;
            string kullaniciSifre = kullaniciSifreTextBox.Text;
            string kullaniciSifreTekrari = kullaniciSifreTekrariTextBox.Text;
            string isim = isimTextBox.Text;
            string soyisim = soyisimTextBox.Text;
            bool resultYas = int.TryParse(yasTextBox.Text, out var yas);
            bool resutBoy = int.TryParse(boyTextBox.Text, out var boy);
            bool resultKilo = decimal.TryParse(kiloTextBox.Text, out var kilo);

            //KullaniciManager kullanici = new KullaniciManager(new KullaniciRepo(1));

            var termpString = string.Empty;
            if (!kullaniciManager.ValidUser(kullaniciMail) || !kullaniciManager.ValidMail(kullaniciMail))
            {
                termpString += "Kullanıcı mail hatalı\r\n";
            }
            if (string.IsNullOrWhiteSpace(kullaniciSifre) || string.IsNullOrWhiteSpace(kullaniciMail) || string.IsNullOrWhiteSpace(kullaniciSifreTekrari) || string.IsNullOrWhiteSpace(isim) || string.IsNullOrWhiteSpace(soyisim))
            {
                termpString += "Lütfen tüm alanları doldurun.\r\n";
            }
            if (!resultYas || !resutBoy || !resultKilo)
            {
                termpString += "yaş,boy veya kilo değişken tanımlama hatası.\r\n";
            }
            if (!kullaniciManager.ValidPassword(kullaniciSifre))
            {
                termpString += "sifre tanımlama hatasi.\r\n";
            }
            if (termpString == string.Empty)
            {
                MessageBox.Show("kayıt olusturuldu");
                kullaniciManager.InsertManager(new Entities.Concrete.Kullanici()
                {
                    KullaniciAdi = isim,
                    KullaniciBoy = boy,
                    KullaniciKilo = kilo,
                    KullaniciMail = kullaniciMail,
                    KullaniciSifre = kullaniciSifre,
                    KullaniciSoyadi = soyisim,
                    KullaniciYasi = yas,
                });
                panel2.Visible = false;
                panel1.Visible = true;

            }
            else
            {
                MessageBox.Show(termpString);
            }


            //panel2.Visible = false;
            //panel1.Visible = true;
            panel1.BringToFront();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            var kullanici2 = kullaniciManager.GetByIdManager(UserId);

            if (kullanici2 != null)
            {
                IsimLbl.Text = kullanici2.KullaniciAdi;
                SoyadLbl.Text = kullanici2.KullaniciSoyadi;
                BoyLbl.Text = kullanici2.KullaniciBoy.ToString();
                KilooLbl.Text = kullanici2.KullaniciKilo.ToString();
            }

            OgunConboBox.Items.Clear();
            var ogunIsimleri = Enum.GetNames(typeof(OgunIsmi));//.ToList();
            // OgunComboBox.DataSource = ogunIsimleri;
            foreach (var item in ogunIsimleri)
            {
                OgunConboBox.Items.Add(item);
            }

        }
        private void kullaniciMailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
            panel3.Visible = false;
            panel5.Visible = true;

            katagorilistcomboBox2.Items.Clear();
            var kategoriler = Enum.GetNames(typeof(YemekKategorileri));
            foreach (var item in kategoriler)
            {
                katagorilistcomboBox2.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği YemekAdi ve Kalori bilgilerini al
            string yemekAdi = YemekAdiEktextBox2.Text;
            int kalori;

            if (int.TryParse(KalorimikektextBox3.Text, out kalori))
            {
                yemekManager.InsertManager(new Entities.Concrete.Yemek()
                {
                    YemekAdi=yemekAdi,
                    Kalori=kalori
                });

            }
            else
            {
                MessageBox.Show("Kalori bilgisini sayı olarak giriniz.");
            }
        }
    }
}
