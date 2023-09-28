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
        private List<Yemek> yemekListesi;
        private List<Ogun> ogunListesi;
        public GirişEkranı()
        {
            InitializeComponent();
            kullaniciManager = new KullaniciManager(new KullaniciRepo());
            ogunListesi = new List<Ogun>();
            yemekListesi = new List<Yemek>();

        }

        private void GirişEkranı_Load(object sender, EventArgs e)
        {

            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

            var kategoriler = Enum.GetNames(typeof(YemekKategorileri));
            foreach (var item in kategoriler)
            {
                katagorilistcomboBox2.Items.Add(item);
            }

            var ogunIsimleri = Enum.GetNames(typeof(OgunIsmi));
            // OgunComboBox.DataSource = ogunIsimleri;
            foreach (var item in ogunIsimleri)
            {
                OgunConboBox.Items.Add(item);

            }
            MessageBox.Show("Sağlıklı bir yaşam için ön koşul doğru ve dengeli beslenmektir.\r\n Beslenme konusuna detaylı bakacak olursak tükettiğimiz  yiyeceklerin kalorisini bilmek ve aşırı kalori içeren işlenmiş gıdalardan kaçınmak bu \r\ndengeyi sağlamanın en kolay yollarından biridir.\r\n Araştırmalar gösteriyor ki kalori takibini yapabilen insanlar daha az kalorili \r\nyiyecekler tüketerek kilolarını dengede tutmayı başarıyorlar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = KullaniciAdiTextBox.Text;
            string sifre = SifreTextBox.Text;
            string termpSitring = string.Empty;
            if (kullaniciManager.UserLogin(kullaniciAdi, sifre))
            {
                UserId = kullaniciManager.UserId(kullaniciAdi);

                MessageBox.Show("giriş başarılı");
                panel1.Visible = false;
                panel3.Visible = true;
                yemekManager = new YemekManager(new YemekRepo(UserId));
                ogunManager = new OgunManager(new OgunRepo(UserId));
                yemekListesi = yemekManager.GetAll();
                foreach (var yemek in yemekListesi)
                {
                    YemekComboBox.Items.Add(yemek.YemekAdi);
                }

            }
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                termpSitring += "Lütfen tüm alanları doldurun.";
                return;
            }
            if (termpSitring == string.Empty)
            {
                termpSitring += "kullanici adi veya sifre hatasi";
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

            // OgunConboBox.Items.Clear();


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

            //katagorilistcomboBox2.Items.Clear();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği YemekAdi ve Kalori bilgilerini al
            string yemekAdi = YemekAdiEktextBox2.Text;
            int kalori;
            //if (!yemekListesi.Any(x => x.YemekAdi == yemekAdi))
            //{
            //    MessageBox.Show("Bu yemek daha önce eklendi.");
            //    return;
            //}
            if (int.TryParse(KalorimikektextBox3.Text, out kalori))
            {
                var yemek = new Yemek()
                {
                    YemekAdi = yemekAdi,
                    Kalori = kalori
                };
                yemekManager.InsertManager(yemek);
                yemekListesi.Add(yemek);
                YemekComboBox.Items.Clear();
                foreach (var item in yemekListesi)
                {
                    YemekComboBox.Items.Add(item.YemekAdi);
                }
                panel3.Visible = true;
                panel5.Visible = false;
                panel5.SendToBack();
                panel3.BringToFront();
            }
            else
            {
                MessageBox.Show("Kalori bilgisini sayı olarak giriniz.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel6.Visible = true;
            OgunListBoxUpdate();

            foreach (var ogunIsmi in Enum.GetValues<OgunIsmi>())
            {
                comboBox1.Items.Add(ogunIsmi);
            }
        }

        private void OgunListBoxUpdate()
        {
            ogunListesi.Clear();
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            ogunListesi = ogunManager.GetAllDaily(DateTime.Now);
            foreach (var ogun in ogunListesi)
            {
                OgunIsmi ogunIsmi = (OgunIsmi)Enum.ToObject(typeof(OgunIsmi), ogun.OgunIsmi);
                listBox1.Items.Add(Enum.GetName(typeof(OgunIsmi), ogunIsmi) + " - " + ogun.Yemek.YemekAdi + " - " +
                                   ogun.YenilenKalori);
            }

            foreach (var yemek in yemekListesi)
            {
                comboBox2.Items.Add(yemek.YemekAdi);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Ogun ogun = new Ogun();

            ogun.YemekPorsiyon = Convert.ToDecimal(porsiyonyaztextBox1.Text);
            ogun.OgunIsmi = (OgunIsmi)OgunConboBox.SelectedIndex;
            ogun.OgunVakti = DateTime.Now;
            ogun.KullaniciId = UserId;
            var yemek = yemekListesi.Find(x => x.YemekAdi == YemekComboBox.SelectedItem);
            ogun.YemekId = yemek.Id;
            ogun.YenilenKalori = yemek.Kalori * ogun.YemekPorsiyon;
            ogunManager.InsertManager(ogun);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Geri_panel6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel3.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OgunTextBoxUpdate(Ogun tempOgun)
        {
            OgunUpdateClear();
            textBox1.Text = tempOgun.YemekPorsiyon.ToString();
            comboBox1.SelectedText = (Enum.GetName(typeof(OgunIsmi), tempOgun.OgunIsmi));
            comboBox2.SelectedText = yemekListesi.SingleOrDefault(x => x.Id == tempOgun.YemekId).YemekAdi.ToString();


        }

        private void Öğün_Sil_Click(object sender, EventArgs e)
        {
            var tempOgun = ogunListesi[listBox1.SelectedIndex];
            ogunManager.DeleteManager(tempOgun);
            OgunUpdateClear();
        }
        private void Öğün_Getir_Click(object sender, EventArgs e)
        {
            var tempOgun = ogunListesi[listBox1.SelectedIndex];
            OgunTextBoxUpdate(tempOgun);

        }

        private void OgunUpdateClear()
        {
            comboBox1.SelectedText = null;
            comboBox2.SelectedText = null;
            textBox1.Clear();
        }

        private void Ögün_Güncelle_Click(object sender, EventArgs e)
        {
            var tempOgun = ogunListesi[listBox1.SelectedIndex];
            tempOgun = ogunManager.GetByIdManager(tempOgun.Id);
            //tempOgun.YemekPorsiyon = tempOgun.YemekPorsiyon.ToString();
            //tempOgun.OgunIsmi = comboBox2.SelectedIndex;
            //tempOgun.YemekId = yemekListesi.SingleOrDefault(x => x.Id == tempOgun.YemekId).YemekAdi.ToString();
            ogunManager.UpdateManager(tempOgun);
            OgunTextBoxUpdate(tempOgun);
            OgunListBoxUpdate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {

            DateTime tarih = DateTime.Now.Date; // Bugünün tarihi
            var gunSonuRaporlar = yemekManager.GünSonuRapor(tarih);



            raporlarlistBox2.Items.Clear();
            foreach (var yemek in gunSonuRaporlar)
            {
                raporlarlistBox2.Items.Add($"Yemek Adı: {yemek.YemekAdi}, Yenilen Kalori: {yemek.Ogunler.Sum(o => o.YenilenKalori)}");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
