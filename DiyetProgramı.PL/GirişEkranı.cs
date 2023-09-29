using DiyetProgramı.BLL.Concrete;
using DiyetProgramı.DAL.Concrete;
using DiyetProgramı.Entities.Abstract;
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
            OgunEkleDateTimePicker.MaxDate = DateTime.Now;
            RaporlarDateTimePicker.MaxDate = DateTime.Now;

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

        private void GirişYapClick(object sender, EventArgs e)
        {
            string kullaniciAdi = KullaniciAdiTextBox.Text;
            string sifre = SifreTextBox.Text;
            string termpSitring = string.Empty;
            var tempInt = kullaniciManager.UserLogin(kullaniciAdi, sifre);
            if (tempInt != -1)
            {
                UserId = tempInt;
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
            else
            {
                if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
                {
                    termpSitring += "Lütfen tüm alanları doldurun.";
                    return;
                }
                if (termpSitring == string.Empty)
                {
                    termpSitring += "kullanici adi veya sifre hatasi";
                }
                MessageBox.Show(termpSitring);
            }



        }



        private void KayitOlClick(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Visible = false;
            panel2.Visible = true;
            //this.Visible = false;
            //KayıtEkranı kayıtEkran = new KayıtEkranı();
            //kayıtEkran.ShowDialog();
            //this.Show();
        }

        private void KayitOlEkraniClick(object sender, EventArgs e)
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
            if (kullaniciSifre != kullaniciSifreTekrari)
            {
                termpString += "sifre tekrarı tanımlama hatasi.\r\n";
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
        private void YemekEkleBtnClick(object sender, EventArgs e)
        {
            panel5.BringToFront();
            panel3.Visible = false;
            panel5.Visible = true;

            //katagorilistcomboBox2.Items.Clear();


        }

        private void YemekEkleClick(object sender, EventArgs e)
        {
            string yemekAdi = YemekAdiEktextBox2.Text;
            int kalori;
            if (yemekListesi.Any(x => x.YemekAdi == yemekAdi))
            {
                MessageBox.Show("Aynı yemek girilemez");
                return;
            }
            if (int.TryParse(KalorimikektextBox3.Text, out kalori))
            {
                var yemek = new Yemek()
                {
                    YemekAdi = yemekAdi,
                    Kalori = kalori,
                    Kategorileri = (YemekKategorileri)Enum.Parse(typeof(YemekKategorileri), katagorilistcomboBox2.SelectedItem.ToString())
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

        private void OgunGuncelleSilClick(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel6.Visible = true;
            OgunListBoxUpdate();
        }

        private void OgunListBoxUpdate()
        {
            ogunListesi.Clear();
            OgunUpdateDeleteListBox.Items.Clear();
            OgunUpdateDeleteOgunCombobox.Items.Clear();
            OgunUpdateDeleteYemekCombobox.Items.Clear();
            porsiyonYazTextBox.Clear();
            ogunListesi = ogunManager.GetAllDaily(DateTime.Now);
            foreach (var ogun in ogunListesi)
            {
                OgunIsmi ogunIsmi = (OgunIsmi)Enum.ToObject(typeof(OgunIsmi), ogun.OgunIsmi);
                OgunUpdateDeleteListBox.Items.Add(Enum.GetName(typeof(OgunIsmi), ogunIsmi) + " - " + ogun.Yemek.YemekAdi + " - " +
                                   ogun.YenilenKalori);
            }

            foreach (var yemek in yemekListesi)
            {
                OgunUpdateDeleteYemekCombobox.Items.Add(yemek.YemekAdi);
            }

            foreach (var ogunIsmi in Enum.GetValues<OgunIsmi>())
            {
                OgunUpdateDeleteOgunCombobox.Items.Add(ogunIsmi);
            }
        }

        private void OgunEkleBtnClick(object sender, EventArgs e)
        {
            Ogun ogun = new Ogun();

            ogun.YemekPorsiyon = Convert.ToDecimal(porsiyonyaztextBox1.Text);
            string ogunIsmiStr = OgunConboBox.SelectedItem.ToString();
            var ogunIsmiObj = Enum.Parse(typeof(OgunIsmi), ogunIsmiStr);
            OgunIsmi ogunIsmi = (OgunIsmi)ogunIsmiObj;
            ogun.OgunIsmi = ogunIsmi;

            ogun.OgunVakti = OgunEkleDateTimePicker.Value.Date;
            ogun.KullaniciId = UserId;

            var selectedYemek = yemekListesi.SingleOrDefault(x => x.YemekAdi == YemekComboBox.SelectedItem);

            if (selectedYemek != null)
            {
                ogun.YemekId = selectedYemek.Id;
                ogun.YenilenKalori = selectedYemek.Kalori * ogun.YemekPorsiyon;
                ogunManager.InsertManager(ogun);
                OgunListBoxUpdate();
            }
            else
            {
                MessageBox.Show("Lütfen bir yemek seçin.");
            }

            OgunConboBox.SelectedIndex = -1;
            YemekComboBox.SelectedIndex = -1;
            porsiyonyaztextBox1.Clear();
        }

        private void Geri_panel6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel3.Visible = true;
        }

        private void OgunUpdateDeleteListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = OgunUpdateDeleteListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < ogunListesi.Count)
            {
                var tempOgun = ogunListesi[selectedIndex];
                OgunTextBoxUpdate(tempOgun);
            }
            else
            {
                MessageBox.Show("Lütfen bir öğün seçin.");
            }
        }

        private void OgunTextBoxUpdate(Ogun tempOgun)
        {
            OgunUpdateClear();
            porsiyonYazTextBox.Text = tempOgun.YemekPorsiyon.ToString();
            OgunUpdateDeleteOgunCombobox.SelectedItem = tempOgun.OgunIsmi;
            OgunUpdateDeleteYemekCombobox.SelectedItem = yemekListesi.FirstOrDefault(x => x.Id == tempOgun.YemekId)?.YemekAdi;
        }


        private void Öğün_Sil_Click(object sender, EventArgs e)
        {
            int selectedIndex = OgunUpdateDeleteListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < ogunListesi.Count)
            {
                var tempOgun = ogunListesi[selectedIndex];
                ogunManager.DeleteManager(tempOgun);
                OgunListBoxUpdate();
                OgunUpdateClear();
            }
            else
            {
                MessageBox.Show("Lütfen bir öğün seçin.");
            }
        }

        private void Öğün_Getir_Click(object sender, EventArgs e)
        {
            var tempOgun = ogunListesi[OgunUpdateDeleteListBox.SelectedIndex];
            OgunTextBoxUpdate(tempOgun);

        }

        private void OgunUpdateClear()
        {
            OgunUpdateDeleteOgunCombobox.SelectedIndex = -1;
            porsiyonYazTextBox.Clear();
            OgunUpdateDeleteYemekCombobox.SelectedIndex = -1;
        }

        private void Ögün_Güncelle_Click(object sender, EventArgs e)
        {
            var tempOgun = ogunListesi[OgunUpdateDeleteListBox.SelectedIndex];
            tempOgun = ogunManager.GetByIdManager(tempOgun.Id);
            ogunManager.UpdateManager(tempOgun);
            OgunTextBoxUpdate(tempOgun);
            OgunListBoxUpdate();
        }

        private void RaporlarBtnClick(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
            HaftalikRadioBtn.Checked = true;

        }

        private void GunSonuRaporuClick(object sender, EventArgs e)
        {

            DateTime secilenTarih = RaporlarDateTimePicker.Value.Date;
            var tempInt = yemekManager.GünSonuToplamKalori(RaporlarDateTimePicker.Value.Date);
            if (tempInt == 0)
                return;
            var gunSonuRaporlar = yemekManager.GünSonuRapor(secilenTarih);

            GunSonuKiyasRaporListBox.Items.Clear();

            foreach (var yemek in gunSonuRaporlar)
            {
                GunSonuKiyasRaporListBox.Items.Add($"Yemek Adı: {yemek.YemekAdi}, Yenilen Kalori: {yemek.Ogunler.Sum(o => o.YenilenKalori)}");
            }

            GunSonuKiyasRaporListBox.Items.Add("Gün Sonu Toplam Kalori : " + tempInt);

        }

        private void KiyasRaporuClick(object sender, EventArgs e)
        {
            int days;
            GunSonuKiyasRaporListBox.Items.Clear();
            kiyasRaporOgunListBox.Items.Clear();
            if (HaftalikRadioBtn.Checked)
            {
                days = 7;
            }
            else
            {
                days = 30;
            }

            int aralik = 1; // Her iki öğe arasındaki satır aralığı

            foreach (var value in Enum.GetValues(typeof(OgunIsmi)))
            {
                var temp = $"{Enum.GetName(typeof(OgunIsmi), value)} :";
                temp += $" Max: {ogunManager.HaftalikAylikRaporMax(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (OgunIsmi)value).ToString("0.0")} Kcal";
                temp += $" Avg: {ogunManager.HaftalikAylikRaporAvg(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (OgunIsmi)value).ToString("0.0")} Kcal";
                temp += $" Min: {ogunManager.HaftalikAylikRaporMin(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (OgunIsmi)value).ToString("0.0")} Kcal";
                temp += $" UserAvg: {ogunManager.HaftalikAylikRaporKullaniciAvg(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (OgunIsmi)value).ToString("0.0")} Kcal";

                GunSonuKiyasRaporListBox.Items.Add(temp);

                // Her iki öğe arasına belirli bir aralık eklemek için
                if (value.GetHashCode() < Enum.GetValues(typeof(OgunIsmi)).Length - 1)
                {
                    for (int j = 0; j < aralik; j++)
                    {
                        GunSonuKiyasRaporListBox.Items.Add(""); // Boş satır eklemek için
                    }
                }
            }

            for (int i = 0; i < Enum.GetValues(typeof(YemekKategorileri)).Length; i++)
            {
                var value = Enum.GetValues(typeof(YemekKategorileri)).GetValue(i);
                var maxKcal = yemekManager.HaftalikAylikRaporKategoriMax(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (YemekKategorileri)value);
                var avgKcal = yemekManager.HaftalikAylikRaporKategoriAvg(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (YemekKategorileri)value);
                var minKcal = yemekManager.HaftalikAylikRaporKategoriMin(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (YemekKategorileri)value);
                var userAvgKcal = yemekManager.HaftalikAylikRaporKullanici(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (YemekKategorileri)value);

                string temp = $"{Enum.GetName(typeof(YemekKategorileri), value)} :";
                temp += $" Max: {maxKcal.ToString("0.0")} Kcal";
                temp += $" Avg: {avgKcal.ToString("0.0")} Kcal";
                temp += $" Min: {minKcal.ToString("0.0")} Kcal";
                temp += $" UserAvg: {userAvgKcal.ToString("0.0")} Kcal";

                kiyasRaporOgunListBox.Items.Add(temp);

                // Her iki öğe arasına belirli bir aralık eklemek için
                if (i < Enum.GetValues(typeof(YemekKategorileri)).Length - 1)
                {
                    for (int j = 0; j < aralik; j++)
                    {
                        kiyasRaporOgunListBox.Items.Add(""); // Boş satır eklemek için
                    }
                }
            }


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunSonuKiyasRaporListBoxSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void YemekCesidiRaporClick(object sender, EventArgs e)
        {
            kiyasRaporOgunListBox.Items.Clear();
            foreach (var yemek in yemekManager.EnCokYenenYemek())
            {
                kiyasRaporOgunListBox.Items.Add(yemek.YemekAdi + " " + yemek.Kalori);
            }
            GunSonuKiyasRaporListBox.Items.Clear();
            foreach (var yemekRaporu in yemekManager.YemekRaporu())
            {
                GunSonuKiyasRaporListBox.Items.Add(yemekRaporu);
            }
        }

        private void Geri_Panel4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
        }

        private void Geri_Panel5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel3.Visible = true;
        }

        private void Geri_Panel3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel1.Visible = true;
        }

        private void Geri_panel1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }
    }
}
