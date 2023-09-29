namespace DiyetProgramı.PL
{
    partial class GirişEkranı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            GirisYapBtn = new Button();
            KullaniciAdiTextBox = new TextBox();
            SifreTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            GirisEkraniKayitOlBtn = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            KayitEkraniBtn = new Button();
            label8 = new Label();
            kullaniciSifreTekrariTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            isimTextBox = new TextBox();
            soyisimTextBox = new TextBox();
            kiloTextBox = new TextBox();
            yasTextBox = new TextBox();
            boyTextBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            kullaniciSifreTextBox = new TextBox();
            kullaniciMailTextBox = new TextBox();
            button11 = new Button();
            KiyasRaporBtn = new Button();
            GunSonuRaporuBtn = new Button();
            panel4 = new Panel();
            AylikRadioBtn = new RadioButton();
            HaftalikRadioBtn = new RadioButton();
            RaporlarDateTimePicker = new DateTimePicker();
            kiyasRaporOgunListBox = new ListBox();
            GunSonuKiyasRaporListBox = new ListBox();
            YemekEkleBtn = new Button();
            OgunEkleBtn = new Button();
            RaporlarBtn = new Button();
            YemekComboBox = new ComboBox();
            OgunConboBox = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            IsimLbl = new Label();
            SoyadLbl = new Label();
            BoyLbl = new Label();
            KilooLbl = new Label();
            panel3 = new Panel();
            OgunEkleDateTimePicker = new DateTimePicker();
            OgunGuncelleSilBtn = new Button();
            porsiyonyaztextBox1 = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            panel5 = new Panel();
            katagorilistcomboBox2 = new ComboBox();
            NewYemekEkleBtn = new Button();
            YemekAdiEktextBox2 = new TextBox();
            KalorimikektextBox3 = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel6 = new Panel();
            OgunUpdateDeleteYemekCombobox = new ComboBox();
            label25 = new Label();
            porsiyonYazTextBox = new TextBox();
            label23 = new Label();
            label24 = new Label();
            OgunUpdateDeleteOgunCombobox = new ComboBox();
            Geri_panel6 = new Button();
            Öğün_Sil = new Button();
            OgunUpdateDeleteListBox = new ListBox();
            Ögün_Güncelle = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // GirisYapBtn
            // 
            GirisYapBtn.Location = new Point(286, 88);
            GirisYapBtn.Margin = new Padding(3, 2, 3, 2);
            GirisYapBtn.Name = "GirisYapBtn";
            GirisYapBtn.Size = new Size(82, 22);
            GirisYapBtn.TabIndex = 0;
            GirisYapBtn.Text = "Giriş Yap";
            GirisYapBtn.UseVisualStyleBackColor = true;
            GirisYapBtn.Click += GirişYapClick;
            // 
            // KullaniciAdiTextBox
            // 
            KullaniciAdiTextBox.Location = new Point(128, 39);
            KullaniciAdiTextBox.Margin = new Padding(3, 2, 3, 2);
            KullaniciAdiTextBox.Name = "KullaniciAdiTextBox";
            KullaniciAdiTextBox.Size = new Size(241, 23);
            KullaniciAdiTextBox.TabIndex = 1;
            // 
            // SifreTextBox
            // 
            SifreTextBox.Location = new Point(128, 64);
            SifreTextBox.Margin = new Padding(3, 2, 3, 2);
            SifreTextBox.Name = "SifreTextBox";
            SifreTextBox.Size = new Size(240, 23);
            SifreTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 41);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 66);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Şifre";
            // 
            // GirisEkraniKayitOlBtn
            // 
            GirisEkraniKayitOlBtn.Location = new Point(199, 88);
            GirisEkraniKayitOlBtn.Margin = new Padding(3, 2, 3, 2);
            GirisEkraniKayitOlBtn.Name = "GirisEkraniKayitOlBtn";
            GirisEkraniKayitOlBtn.Size = new Size(82, 22);
            GirisEkraniKayitOlBtn.TabIndex = 15;
            GirisEkraniKayitOlBtn.Text = "Kayıt Ol";
            GirisEkraniKayitOlBtn.UseVisualStyleBackColor = true;
            GirisEkraniKayitOlBtn.Click += KayitOlClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 287);
            panel1.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SifreTextBox);
            groupBox1.Controls.Add(GirisEkraniKayitOlBtn);
            groupBox1.Controls.Add(KullaniciAdiTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(GirisYapBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 21);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(429, 233);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(474, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 329);
            panel2.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(KayitEkraniBtn);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(kullaniciSifreTekrariTextBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(isimTextBox);
            groupBox2.Controls.Add(soyisimTextBox);
            groupBox2.Controls.Add(kiloTextBox);
            groupBox2.Controls.Add(yasTextBox);
            groupBox2.Controls.Add(boyTextBox);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(kullaniciSifreTextBox);
            groupBox2.Controls.Add(kullaniciMailTextBox);
            groupBox2.Location = new Point(46, 35);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(466, 256);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // KayitEkraniBtn
            // 
            KayitEkraniBtn.Location = new Point(337, 197);
            KayitEkraniBtn.Margin = new Padding(3, 2, 3, 2);
            KayitEkraniBtn.Name = "KayitEkraniBtn";
            KayitEkraniBtn.Size = new Size(82, 22);
            KayitEkraniBtn.TabIndex = 51;
            KayitEkraniBtn.Text = "Kayıt Ol";
            KayitEkraniBtn.UseVisualStyleBackColor = true;
            KayitEkraniBtn.Click += KayitOlEkraniClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 50);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 50;
            label8.Text = "Kullanıcı Şifre Tekrar";
            // 
            // kullaniciSifreTekrariTextBox
            // 
            kullaniciSifreTekrariTextBox.Location = new Point(178, 47);
            kullaniciSifreTekrariTextBox.Margin = new Padding(3, 2, 3, 2);
            kullaniciSifreTekrariTextBox.Name = "kullaniciSifreTekrariTextBox";
            kullaniciSifreTekrariTextBox.Size = new Size(240, 23);
            kullaniciSifreTekrariTextBox.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 178);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 48;
            label7.Text = "Kilo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 153);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 47;
            label6.Text = "Boy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 128);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 46;
            label5.Text = "Yaş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 104);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 45;
            label4.Text = "Soyisim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 79);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 44;
            label3.Text = "İsim";
            // 
            // isimTextBox
            // 
            isimTextBox.Location = new Point(178, 74);
            isimTextBox.Margin = new Padding(3, 2, 3, 2);
            isimTextBox.Name = "isimTextBox";
            isimTextBox.Size = new Size(240, 23);
            isimTextBox.TabIndex = 43;
            // 
            // soyisimTextBox
            // 
            soyisimTextBox.Location = new Point(178, 98);
            soyisimTextBox.Margin = new Padding(3, 2, 3, 2);
            soyisimTextBox.Name = "soyisimTextBox";
            soyisimTextBox.Size = new Size(240, 23);
            soyisimTextBox.TabIndex = 42;
            // 
            // kiloTextBox
            // 
            kiloTextBox.Location = new Point(179, 172);
            kiloTextBox.Margin = new Padding(3, 2, 3, 2);
            kiloTextBox.Name = "kiloTextBox";
            kiloTextBox.Size = new Size(240, 23);
            kiloTextBox.TabIndex = 41;
            // 
            // yasTextBox
            // 
            yasTextBox.Location = new Point(179, 123);
            yasTextBox.Margin = new Padding(3, 2, 3, 2);
            yasTextBox.Name = "yasTextBox";
            yasTextBox.Size = new Size(240, 23);
            yasTextBox.TabIndex = 40;
            // 
            // boyTextBox
            // 
            boyTextBox.Location = new Point(178, 148);
            boyTextBox.Margin = new Padding(3, 2, 3, 2);
            boyTextBox.Name = "boyTextBox";
            boyTextBox.Size = new Size(240, 23);
            boyTextBox.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(87, 25);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 38;
            label9.Text = "Kullanıcı Şifre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(88, 0);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 37;
            label10.Text = "Kullanıcı Mail";
            // 
            // kullaniciSifreTextBox
            // 
            kullaniciSifreTextBox.Location = new Point(178, 22);
            kullaniciSifreTextBox.Margin = new Padding(3, 2, 3, 2);
            kullaniciSifreTextBox.Name = "kullaniciSifreTextBox";
            kullaniciSifreTextBox.Size = new Size(240, 23);
            kullaniciSifreTextBox.TabIndex = 36;
            // 
            // kullaniciMailTextBox
            // 
            kullaniciMailTextBox.Location = new Point(178, -2);
            kullaniciMailTextBox.Margin = new Padding(3, 2, 3, 2);
            kullaniciMailTextBox.Name = "kullaniciMailTextBox";
            kullaniciMailTextBox.Size = new Size(241, 23);
            kullaniciMailTextBox.TabIndex = 35;
            // 
            // button11
            // 
            button11.Location = new Point(3, 61);
            button11.Margin = new Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Size = new Size(139, 22);
            button11.TabIndex = 29;
            button11.Text = "Yemek Çeşidi Raporu";
            button11.UseVisualStyleBackColor = true;
            button11.Click += YemekCesidiRaporClick;
            // 
            // KiyasRaporBtn
            // 
            KiyasRaporBtn.Location = new Point(3, 34);
            KiyasRaporBtn.Margin = new Padding(3, 2, 3, 2);
            KiyasRaporBtn.Name = "KiyasRaporBtn";
            KiyasRaporBtn.Size = new Size(139, 22);
            KiyasRaporBtn.TabIndex = 28;
            KiyasRaporBtn.Text = "Kıyas Raporları";
            KiyasRaporBtn.UseVisualStyleBackColor = true;
            KiyasRaporBtn.Click += KiyasRaporuClick;
            // 
            // GunSonuRaporuBtn
            // 
            GunSonuRaporuBtn.Location = new Point(3, 8);
            GunSonuRaporuBtn.Margin = new Padding(3, 2, 3, 2);
            GunSonuRaporuBtn.Name = "GunSonuRaporuBtn";
            GunSonuRaporuBtn.Size = new Size(139, 22);
            GunSonuRaporuBtn.TabIndex = 27;
            GunSonuRaporuBtn.Text = "Gün Sonu Raporu";
            GunSonuRaporuBtn.UseVisualStyleBackColor = true;
            GunSonuRaporuBtn.Click += GunSonuRaporuClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(AylikRadioBtn);
            panel4.Controls.Add(HaftalikRadioBtn);
            panel4.Controls.Add(RaporlarDateTimePicker);
            panel4.Controls.Add(kiyasRaporOgunListBox);
            panel4.Controls.Add(GunSonuKiyasRaporListBox);
            panel4.Controls.Add(button11);
            panel4.Controls.Add(KiyasRaporBtn);
            panel4.Controls.Add(GunSonuRaporuBtn);
            panel4.Location = new Point(71, 464);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1440, 202);
            panel4.TabIndex = 19;
            panel4.Paint += panel4_Paint;
            // 
            // AylikRadioBtn
            // 
            AylikRadioBtn.AutoSize = true;
            AylikRadioBtn.Location = new Point(233, 38);
            AylikRadioBtn.Name = "AylikRadioBtn";
            AylikRadioBtn.Size = new Size(51, 19);
            AylikRadioBtn.TabIndex = 48;
            AylikRadioBtn.TabStop = true;
            AylikRadioBtn.Text = "Aylık";
            AylikRadioBtn.UseVisualStyleBackColor = true;
            // 
            // HaftalikRadioBtn
            // 
            HaftalikRadioBtn.AutoSize = true;
            HaftalikRadioBtn.Location = new Point(156, 38);
            HaftalikRadioBtn.Name = "HaftalikRadioBtn";
            HaftalikRadioBtn.Size = new Size(66, 19);
            HaftalikRadioBtn.TabIndex = 48;
            HaftalikRadioBtn.TabStop = true;
            HaftalikRadioBtn.Text = "Haftalık";
            HaftalikRadioBtn.UseVisualStyleBackColor = true;
            // 
            // RaporlarDateTimePicker
            // 
            RaporlarDateTimePicker.Location = new Point(156, 10);
            RaporlarDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            RaporlarDateTimePicker.Name = "RaporlarDateTimePicker";
            RaporlarDateTimePicker.Size = new Size(132, 23);
            RaporlarDateTimePicker.TabIndex = 47;
            // 
            // kiyasRaporOgunListBox
            // 
            kiyasRaporOgunListBox.FormattingEnabled = true;
            kiyasRaporOgunListBox.ItemHeight = 15;
            kiyasRaporOgunListBox.Location = new Point(853, 10);
            kiyasRaporOgunListBox.Margin = new Padding(3, 2, 3, 2);
            kiyasRaporOgunListBox.Name = "kiyasRaporOgunListBox";
            kiyasRaporOgunListBox.Size = new Size(549, 154);
            kiyasRaporOgunListBox.TabIndex = 33;
            // 
            // GunSonuKiyasRaporListBox
            // 
            GunSonuKiyasRaporListBox.FormattingEnabled = true;
            GunSonuKiyasRaporListBox.ItemHeight = 15;
            GunSonuKiyasRaporListBox.Location = new Point(292, 10);
            GunSonuKiyasRaporListBox.Margin = new Padding(3, 2, 3, 2);
            GunSonuKiyasRaporListBox.Name = "GunSonuKiyasRaporListBox";
            GunSonuKiyasRaporListBox.Size = new Size(526, 154);
            GunSonuKiyasRaporListBox.TabIndex = 33;
            GunSonuKiyasRaporListBox.SelectedIndexChanged += GunSonuKiyasRaporListBoxSelectedIndexChanged;
            // 
            // YemekEkleBtn
            // 
            YemekEkleBtn.Location = new Point(328, 59);
            YemekEkleBtn.Margin = new Padding(3, 2, 3, 2);
            YemekEkleBtn.Name = "YemekEkleBtn";
            YemekEkleBtn.Size = new Size(82, 22);
            YemekEkleBtn.TabIndex = 20;
            YemekEkleBtn.Text = "Yemek Ekle";
            YemekEkleBtn.UseVisualStyleBackColor = true;
            YemekEkleBtn.Click += YemekEkleBtnClick;
            // 
            // OgunEkleBtn
            // 
            OgunEkleBtn.Location = new Point(143, 109);
            OgunEkleBtn.Margin = new Padding(3, 2, 3, 2);
            OgunEkleBtn.Name = "OgunEkleBtn";
            OgunEkleBtn.Size = new Size(82, 22);
            OgunEkleBtn.TabIndex = 21;
            OgunEkleBtn.Text = "Öğün Ekle";
            OgunEkleBtn.UseVisualStyleBackColor = true;
            OgunEkleBtn.Click += OgunEkleBtnClick;
            // 
            // RaporlarBtn
            // 
            RaporlarBtn.Location = new Point(355, 232);
            RaporlarBtn.Margin = new Padding(3, 2, 3, 2);
            RaporlarBtn.Name = "RaporlarBtn";
            RaporlarBtn.Size = new Size(82, 22);
            RaporlarBtn.TabIndex = 24;
            RaporlarBtn.Text = "Raporlar";
            RaporlarBtn.UseVisualStyleBackColor = true;
            RaporlarBtn.Click += RaporlarBtnClick;
            // 
            // YemekComboBox
            // 
            YemekComboBox.FormattingEnabled = true;
            YemekComboBox.Location = new Point(306, 33);
            YemekComboBox.Margin = new Padding(3, 2, 3, 2);
            YemekComboBox.Name = "YemekComboBox";
            YemekComboBox.Size = new Size(123, 23);
            YemekComboBox.TabIndex = 25;
            // 
            // OgunConboBox
            // 
            OgunConboBox.FormattingEnabled = true;
            OgunConboBox.Location = new Point(136, 29);
            OgunConboBox.Margin = new Padding(3, 2, 3, 2);
            OgunConboBox.Name = "OgunConboBox";
            OgunConboBox.Size = new Size(155, 23);
            OgunConboBox.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 220);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 28;
            label11.Text = "Isim:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 246);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 29;
            label12.Text = "Soyad:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 272);
            label13.Name = "label13";
            label13.Size = new Size(30, 15);
            label13.TabIndex = 30;
            label13.Text = "Boy:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 298);
            label14.Name = "label14";
            label14.Size = new Size(30, 15);
            label14.TabIndex = 31;
            label14.Text = "Kilo:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(75, 188);
            label15.Name = "label15";
            label15.Size = new Size(77, 15);
            label15.TabIndex = 20;
            label15.Text = "Profil Bilgileri";
            // 
            // IsimLbl
            // 
            IsimLbl.AutoSize = true;
            IsimLbl.Location = new Point(75, 220);
            IsimLbl.Name = "IsimLbl";
            IsimLbl.Size = new Size(77, 15);
            IsimLbl.TabIndex = 36;
            IsimLbl.Text = "Profil Bilgileri";
            // 
            // SoyadLbl
            // 
            SoyadLbl.AutoSize = true;
            SoyadLbl.Location = new Point(75, 248);
            SoyadLbl.Name = "SoyadLbl";
            SoyadLbl.Size = new Size(77, 15);
            SoyadLbl.TabIndex = 37;
            SoyadLbl.Text = "Profil Bilgileri";
            // 
            // BoyLbl
            // 
            BoyLbl.AutoSize = true;
            BoyLbl.Location = new Point(75, 272);
            BoyLbl.Name = "BoyLbl";
            BoyLbl.Size = new Size(77, 15);
            BoyLbl.TabIndex = 38;
            BoyLbl.Text = "Profil Bilgileri";
            // 
            // KilooLbl
            // 
            KilooLbl.AutoSize = true;
            KilooLbl.Location = new Point(75, 298);
            KilooLbl.Name = "KilooLbl";
            KilooLbl.Size = new Size(77, 15);
            KilooLbl.TabIndex = 39;
            KilooLbl.Text = "Profil Bilgileri";
            // 
            // panel3
            // 
            panel3.Controls.Add(OgunEkleDateTimePicker);
            panel3.Controls.Add(OgunGuncelleSilBtn);
            panel3.Controls.Add(porsiyonyaztextBox1);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(KilooLbl);
            panel3.Controls.Add(BoyLbl);
            panel3.Controls.Add(SoyadLbl);
            panel3.Controls.Add(IsimLbl);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(OgunConboBox);
            panel3.Controls.Add(YemekComboBox);
            panel3.Controls.Add(RaporlarBtn);
            panel3.Controls.Add(OgunEkleBtn);
            panel3.Controls.Add(YemekEkleBtn);
            panel3.Location = new Point(1024, 9);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(466, 341);
            panel3.TabIndex = 18;
            panel3.Paint += panel3_Paint;
            // 
            // OgunEkleDateTimePicker
            // 
            OgunEkleDateTimePicker.Location = new Point(219, 182);
            OgunEkleDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            OgunEkleDateTimePicker.Name = "OgunEkleDateTimePicker";
            OgunEkleDateTimePicker.Size = new Size(219, 23);
            OgunEkleDateTimePicker.TabIndex = 46;
            // 
            // OgunGuncelleSilBtn
            // 
            OgunGuncelleSilBtn.Location = new Point(10, 21);
            OgunGuncelleSilBtn.Margin = new Padding(3, 2, 3, 2);
            OgunGuncelleSilBtn.Name = "OgunGuncelleSilBtn";
            OgunGuncelleSilBtn.Size = new Size(108, 44);
            OgunGuncelleSilBtn.TabIndex = 45;
            OgunGuncelleSilBtn.Text = "Öğün Güncelle veya Sil";
            OgunGuncelleSilBtn.UseVisualStyleBackColor = true;
            OgunGuncelleSilBtn.Click += OgunGuncelleSilClick;
            // 
            // porsiyonyaztextBox1
            // 
            porsiyonyaztextBox1.Location = new Point(136, 77);
            porsiyonyaztextBox1.Margin = new Padding(3, 2, 3, 2);
            porsiyonyaztextBox1.Name = "porsiyonyaztextBox1";
            porsiyonyaztextBox1.Size = new Size(110, 23);
            porsiyonyaztextBox1.TabIndex = 44;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(146, 60);
            label22.Name = "label22";
            label22.Size = new Size(73, 15);
            label22.TabIndex = 43;
            label22.Text = "Porsiyon Yaz";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(328, 12);
            label21.Name = "label21";
            label21.Size = new Size(63, 15);
            label21.TabIndex = 42;
            label21.Text = "Yemek Seç";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(146, 12);
            label20.Name = "label20";
            label20.Size = new Size(58, 15);
            label20.TabIndex = 21;
            label20.Text = "Öğün Seç";
            // 
            // panel5
            // 
            panel5.Controls.Add(katagorilistcomboBox2);
            panel5.Controls.Add(NewYemekEkleBtn);
            panel5.Controls.Add(YemekAdiEktextBox2);
            panel5.Controls.Add(KalorimikektextBox3);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label16);
            panel5.Location = new Point(12, 880);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(611, 104);
            panel5.TabIndex = 20;
            // 
            // katagorilistcomboBox2
            // 
            katagorilistcomboBox2.FormattingEnabled = true;
            katagorilistcomboBox2.Location = new Point(100, 51);
            katagorilistcomboBox2.Margin = new Padding(3, 2, 3, 2);
            katagorilistcomboBox2.Name = "katagorilistcomboBox2";
            katagorilistcomboBox2.Size = new Size(110, 23);
            katagorilistcomboBox2.TabIndex = 21;
            // 
            // NewYemekEkleBtn
            // 
            NewYemekEkleBtn.Location = new Point(276, 11);
            NewYemekEkleBtn.Margin = new Padding(3, 2, 3, 2);
            NewYemekEkleBtn.Name = "NewYemekEkleBtn";
            NewYemekEkleBtn.Size = new Size(82, 22);
            NewYemekEkleBtn.TabIndex = 21;
            NewYemekEkleBtn.Text = "Ekle";
            NewYemekEkleBtn.UseVisualStyleBackColor = true;
            NewYemekEkleBtn.Click += YemekEkleClick;
            // 
            // YemekAdiEktextBox2
            // 
            YemekAdiEktextBox2.Location = new Point(100, 4);
            YemekAdiEktextBox2.Margin = new Padding(3, 2, 3, 2);
            YemekAdiEktextBox2.Name = "YemekAdiEktextBox2";
            YemekAdiEktextBox2.Size = new Size(110, 23);
            YemekAdiEktextBox2.TabIndex = 22;
            // 
            // KalorimikektextBox3
            // 
            KalorimikektextBox3.Location = new Point(108, 29);
            KalorimikektextBox3.Margin = new Padding(3, 2, 3, 2);
            KalorimikektextBox3.Name = "KalorimikektextBox3";
            KalorimikektextBox3.Size = new Size(110, 23);
            KalorimikektextBox3.TabIndex = 23;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(15, 78);
            label19.Name = "label19";
            label19.Size = new Size(42, 15);
            label19.TabIndex = 32;
            label19.Text = "Resim:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(15, 51);
            label18.Name = "label18";
            label18.Size = new Size(54, 15);
            label18.TabIndex = 31;
            label18.Text = "Kategori:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 29);
            label17.Name = "label17";
            label17.Size = new Size(40, 15);
            label17.TabIndex = 30;
            label17.Text = "Kalori:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 14);
            label16.Name = "label16";
            label16.Size = new Size(66, 15);
            label16.TabIndex = 29;
            label16.Text = "Yemek Adı:";
            // 
            // panel6
            // 
            panel6.Controls.Add(OgunUpdateDeleteYemekCombobox);
            panel6.Controls.Add(label25);
            panel6.Controls.Add(porsiyonYazTextBox);
            panel6.Controls.Add(label23);
            panel6.Controls.Add(label24);
            panel6.Controls.Add(OgunUpdateDeleteOgunCombobox);
            panel6.Controls.Add(Geri_panel6);
            panel6.Controls.Add(Öğün_Sil);
            panel6.Controls.Add(OgunUpdateDeleteListBox);
            panel6.Controls.Add(Ögün_Güncelle);
            panel6.Location = new Point(650, 695);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(583, 296);
            panel6.TabIndex = 21;
            // 
            // OgunUpdateDeleteYemekCombobox
            // 
            OgunUpdateDeleteYemekCombobox.FormattingEnabled = true;
            OgunUpdateDeleteYemekCombobox.Location = new Point(399, 146);
            OgunUpdateDeleteYemekCombobox.Margin = new Padding(3, 2, 3, 2);
            OgunUpdateDeleteYemekCombobox.Name = "OgunUpdateDeleteYemekCombobox";
            OgunUpdateDeleteYemekCombobox.Size = new Size(123, 23);
            OgunUpdateDeleteYemekCombobox.TabIndex = 52;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(408, 128);
            label25.Name = "label25";
            label25.Size = new Size(62, 15);
            label25.TabIndex = 50;
            label25.Text = "Yemek Yaz";
            // 
            // porsiyonYazTextBox
            // 
            porsiyonYazTextBox.Location = new Point(399, 104);
            porsiyonYazTextBox.Margin = new Padding(3, 2, 3, 2);
            porsiyonYazTextBox.Name = "porsiyonYazTextBox";
            porsiyonYazTextBox.Size = new Size(110, 23);
            porsiyonYazTextBox.TabIndex = 49;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(410, 86);
            label23.Name = "label23";
            label23.Size = new Size(73, 15);
            label23.TabIndex = 48;
            label23.Text = "Porsiyon Yaz";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(410, 38);
            label24.Name = "label24";
            label24.Size = new Size(58, 15);
            label24.TabIndex = 45;
            label24.Text = "Öğün Seç";
            // 
            // OgunUpdateDeleteOgunCombobox
            // 
            OgunUpdateDeleteOgunCombobox.FormattingEnabled = true;
            OgunUpdateDeleteOgunCombobox.Location = new Point(399, 56);
            OgunUpdateDeleteOgunCombobox.Margin = new Padding(3, 2, 3, 2);
            OgunUpdateDeleteOgunCombobox.Name = "OgunUpdateDeleteOgunCombobox";
            OgunUpdateDeleteOgunCombobox.Size = new Size(155, 23);
            OgunUpdateDeleteOgunCombobox.TabIndex = 47;
            // 
            // Geri_panel6
            // 
            Geri_panel6.Location = new Point(498, 0);
            Geri_panel6.Margin = new Padding(3, 2, 3, 2);
            Geri_panel6.Name = "Geri_panel6";
            Geri_panel6.Size = new Size(82, 22);
            Geri_panel6.TabIndex = 22;
            Geri_panel6.Text = "Geri";
            Geri_panel6.UseVisualStyleBackColor = true;
            Geri_panel6.Click += Geri_panel6_Click;
            // 
            // Öğün_Sil
            // 
            Öğün_Sil.Location = new Point(242, 55);
            Öğün_Sil.Margin = new Padding(3, 2, 3, 2);
            Öğün_Sil.Name = "Öğün_Sil";
            Öğün_Sil.Size = new Size(111, 22);
            Öğün_Sil.TabIndex = 23;
            Öğün_Sil.Text = "Öğün Sil";
            Öğün_Sil.UseVisualStyleBackColor = true;
            Öğün_Sil.Click += Öğün_Sil_Click;
            // 
            // OgunUpdateDeleteListBox
            // 
            OgunUpdateDeleteListBox.FormattingEnabled = true;
            OgunUpdateDeleteListBox.ItemHeight = 15;
            OgunUpdateDeleteListBox.Location = new Point(32, 26);
            OgunUpdateDeleteListBox.Margin = new Padding(3, 2, 3, 2);
            OgunUpdateDeleteListBox.Name = "OgunUpdateDeleteListBox";
            OgunUpdateDeleteListBox.Size = new Size(193, 259);
            OgunUpdateDeleteListBox.TabIndex = 0;
            OgunUpdateDeleteListBox.SelectedIndexChanged += OgunUpdateDeleteListBoxSelectedIndexChanged;
            // 
            // Ögün_Güncelle
            // 
            Ögün_Güncelle.Location = new Point(396, 181);
            Ögün_Güncelle.Margin = new Padding(3, 2, 3, 2);
            Ögün_Güncelle.Name = "Ögün_Güncelle";
            Ögün_Güncelle.Size = new Size(111, 22);
            Ögün_Güncelle.TabIndex = 22;
            Ögün_Güncelle.Text = "Öğün Güncelle";
            Ögün_Güncelle.UseVisualStyleBackColor = true;
            Ögün_Güncelle.Click += Ögün_Güncelle_Click;
            // 
            // GirişEkranı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1668, 1047);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GirişEkranı";
            Text = "GirişEkranı";
            Load += GirişEkranı_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button GirisYapBtn;
        private TextBox KullaniciAdiTextBox;
        private TextBox SifreTextBox;
        private Label label1;
        private Label label2;
        private Button GirisEkraniKayitOlBtn;
        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private GroupBox groupBox2;
        private Button KayitEkraniBtn;
        private Label label8;
        private TextBox kullaniciSifreTekrariTextBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox isimTextBox;
        private TextBox soyisimTextBox;
        private TextBox kiloTextBox;
        private TextBox yasTextBox;
        private TextBox boyTextBox;
        private Label label9;
        private Label label10;
        private TextBox kullaniciSifreTextBox;
        private TextBox kullaniciMailTextBox;
        private Button button11;
        private Button KiyasRaporBtn;
        private Button GunSonuRaporuBtn;
        private Panel panel4;
        private Button YemekEkleBtn;
        private Button OgunEkleBtn;
        private Button RaporlarBtn;
        private ComboBox YemekComboBox;
        private ComboBox OgunConboBox;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label IsimLbl;
        private Label SoyadLbl;
        private Label BoyLbl;
        private Label KilooLbl;
        private Panel panel3;
        private Panel panel5;
        private Label label16;
        private TextBox YemekAdiEktextBox2;
        private TextBox KalorimikektextBox3;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label20;
        private Label label21;
        private Button NewYemekEkleBtn;
        private ComboBox katagorilistcomboBox2;
        private Label label22;
        private TextBox porsiyonyaztextBox1;
        private Button OgunGuncelleSilBtn;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Panel panel6;
        private ListBox OgunUpdateDeleteListBox;
        private Button Öğün_Sil;
        private Button Ögün_Güncelle;
        private Button Geri_panel6;
        private ListBox GunSonuKiyasRaporListBox;
        private TextBox porsiyonYazTextBox;
        private Label label23;
        private Label label24;
        private ComboBox OgunUpdateDeleteOgunCombobox;
        private ComboBox OgunUpdateDeleteYemekCombobox;
        private Label label25;
        private DateTimePicker RaporlarDateTimePicker;
        private DateTimePicker OgunEkleDateTimePicker;
        private RadioButton AylikRadioBtn;
        private RadioButton HaftalikRadioBtn;
        private ListBox kiyasRaporOgunListBox;
    }
}