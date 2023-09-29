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
            GirisPanel = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            KayitOlPanel = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            KayitEkraniBtn = new Button();
            Geri_panel1 = new Button();
            label8 = new Label();
            kullaniciSifreTekrariTextBox = new TextBox();
            label7 = new Label();
            kullaniciMailTextBox = new TextBox();
            label6 = new Label();
            kullaniciSifreTextBox = new TextBox();
            label5 = new Label();
            label10 = new Label();
            label4 = new Label();
            label9 = new Label();
            label3 = new Label();
            boyTextBox = new TextBox();
            isimTextBox = new TextBox();
            yasTextBox = new TextBox();
            soyisimTextBox = new TextBox();
            kiloTextBox = new TextBox();
            button11 = new Button();
            KiyasRaporBtn = new Button();
            GunSonuRaporuBtn = new Button();
            RaporPanel = new Panel();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox18 = new PictureBox();
            Geri_Panel4 = new Button();
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
            OgunEklePanel = new Panel();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            pictureBox8 = new PictureBox();
            Geri_Panel3 = new Button();
            OgunEkleDateTimePicker = new DateTimePicker();
            OgunGuncelleSilBtn = new Button();
            porsiyonyaztextBox1 = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            YemekGuncellePanel = new Panel();
            OpenFileDialog = new Button();
            MevcutYemekListBox = new ListBox();
            dateTimePicker2 = new DateTimePicker();
            YemekSilBtn = new Button();
            YemekGuncelleBtn = new Button();
            pictureBox10 = new PictureBox();
            Geri_Panel5 = new Button();
            katagorilistcomboBox2 = new ComboBox();
            NewYemekEkleBtn = new Button();
            YemekAdiEktextBox2 = new TextBox();
            KalorimikektextBox3 = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            OgunGuncellePanel = new Panel();
            pictureBox14 = new PictureBox();
            OgunGuncelleDateTimePicker = new DateTimePicker();
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
            openFileDialog1 = new OpenFileDialog();
            GirisPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            KayitOlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            RaporPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            OgunEklePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            YemekGuncellePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            OgunGuncellePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // GirisYapBtn
            // 
            GirisYapBtn.Location = new Point(413, 656);
            GirisYapBtn.Name = "GirisYapBtn";
            GirisYapBtn.Size = new Size(94, 29);
            GirisYapBtn.TabIndex = 0;
            GirisYapBtn.Text = "Giriş Yap";
            GirisYapBtn.UseVisualStyleBackColor = true;
            GirisYapBtn.Click += GirişYapClick;
            // 
            // KullaniciAdiTextBox
            // 
            KullaniciAdiTextBox.Location = new Point(232, 591);
            KullaniciAdiTextBox.Name = "KullaniciAdiTextBox";
            KullaniciAdiTextBox.Size = new Size(275, 27);
            KullaniciAdiTextBox.TabIndex = 1;
            // 
            // SifreTextBox
            // 
            SifreTextBox.Location = new Point(232, 624);
            SifreTextBox.Name = "SifreTextBox";
            SifreTextBox.Size = new Size(274, 27);
            SifreTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 595);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 627);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Şifre";
            // 
            // GirisEkraniKayitOlBtn
            // 
            GirisEkraniKayitOlBtn.Location = new Point(313, 656);
            GirisEkraniKayitOlBtn.Name = "GirisEkraniKayitOlBtn";
            GirisEkraniKayitOlBtn.Size = new Size(94, 29);
            GirisEkraniKayitOlBtn.TabIndex = 15;
            GirisEkraniKayitOlBtn.Text = "Kayıt Ol";
            GirisEkraniKayitOlBtn.UseVisualStyleBackColor = true;
            GirisEkraniKayitOlBtn.Click += KayitOlClick;
            // 
            // GirisPanel
            // 
            GirisPanel.Controls.Add(pictureBox3);
            GirisPanel.Controls.Add(pictureBox2);
            GirisPanel.Controls.Add(pictureBox1);
            GirisPanel.Controls.Add(label1);
            GirisPanel.Controls.Add(SifreTextBox);
            GirisPanel.Controls.Add(GirisYapBtn);
            GirisPanel.Controls.Add(GirisEkraniKayitOlBtn);
            GirisPanel.Controls.Add(label2);
            GirisPanel.Controls.Add(KullaniciAdiTextBox);
            GirisPanel.Dock = DockStyle.Fill;
            GirisPanel.Location = new Point(0, 0);
            GirisPanel.Name = "GirisPanel";
            GirisPanel.Size = new Size(982, 753);
            GirisPanel.TabIndex = 16;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.istockphoto_835271096_612x612;
            pictureBox3.Location = new Point(678, 452);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(614, 411);
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.istockphoto_1141120666_612x612;
            pictureBox2.Location = new Point(678, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(614, 405);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_525343659_612x612;
            pictureBox1.Location = new Point(27, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(614, 405);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // KayitOlPanel
            // 
            KayitOlPanel.Controls.Add(pictureBox4);
            KayitOlPanel.Controls.Add(pictureBox5);
            KayitOlPanel.Controls.Add(pictureBox6);
            KayitOlPanel.Controls.Add(KayitEkraniBtn);
            KayitOlPanel.Controls.Add(Geri_panel1);
            KayitOlPanel.Controls.Add(label8);
            KayitOlPanel.Controls.Add(kullaniciSifreTekrariTextBox);
            KayitOlPanel.Controls.Add(label7);
            KayitOlPanel.Controls.Add(kullaniciMailTextBox);
            KayitOlPanel.Controls.Add(label6);
            KayitOlPanel.Controls.Add(kullaniciSifreTextBox);
            KayitOlPanel.Controls.Add(label5);
            KayitOlPanel.Controls.Add(label10);
            KayitOlPanel.Controls.Add(label4);
            KayitOlPanel.Controls.Add(label9);
            KayitOlPanel.Controls.Add(label3);
            KayitOlPanel.Controls.Add(boyTextBox);
            KayitOlPanel.Controls.Add(isimTextBox);
            KayitOlPanel.Controls.Add(yasTextBox);
            KayitOlPanel.Controls.Add(soyisimTextBox);
            KayitOlPanel.Controls.Add(kiloTextBox);
            KayitOlPanel.Dock = DockStyle.Fill;
            KayitOlPanel.Location = new Point(0, 0);
            KayitOlPanel.Name = "KayitOlPanel";
            KayitOlPanel.Size = new Size(982, 753);
            KayitOlPanel.TabIndex = 17;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.istockphoto_835271096_612x612;
            pictureBox4.Location = new Point(901, 471);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(614, 411);
            pictureBox4.TabIndex = 54;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.istockphoto_1141120666_612x612;
            pictureBox5.Location = new Point(901, 28);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(614, 405);
            pictureBox5.TabIndex = 53;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.istockphoto_525343659_612x612;
            pictureBox6.Location = new Point(110, 476);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(614, 405);
            pictureBox6.TabIndex = 52;
            pictureBox6.TabStop = false;
            // 
            // KayitEkraniBtn
            // 
            KayitEkraniBtn.Location = new Point(517, 377);
            KayitEkraniBtn.Name = "KayitEkraniBtn";
            KayitEkraniBtn.Size = new Size(94, 29);
            KayitEkraniBtn.TabIndex = 51;
            KayitEkraniBtn.Text = "Kayıt Ol";
            KayitEkraniBtn.UseVisualStyleBackColor = true;
            KayitEkraniBtn.Click += KayitOlEkraniClick;
            // 
            // Geri_panel1
            // 
            Geri_panel1.Location = new Point(648, 115);
            Geri_panel1.Name = "Geri_panel1";
            Geri_panel1.Size = new Size(94, 29);
            Geri_panel1.TabIndex = 50;
            Geri_panel1.Text = "Geri";
            Geri_panel1.UseVisualStyleBackColor = true;
            Geri_panel1.Click += Geri_panel1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(185, 181);
            label8.Name = "label8";
            label8.Size = new Size(143, 20);
            label8.TabIndex = 50;
            label8.Text = "Kullanıcı Şifre Tekrar";
            // 
            // kullaniciSifreTekrariTextBox
            // 
            kullaniciSifreTekrariTextBox.Location = new Point(334, 177);
            kullaniciSifreTekrariTextBox.Name = "kullaniciSifreTekrariTextBox";
            kullaniciSifreTekrariTextBox.Size = new Size(274, 27);
            kullaniciSifreTekrariTextBox.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(185, 347);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 48;
            label7.Text = "Kilo";
            // 
            // kullaniciMailTextBox
            // 
            kullaniciMailTextBox.Location = new Point(334, 111);
            kullaniciMailTextBox.Name = "kullaniciMailTextBox";
            kullaniciMailTextBox.Size = new Size(275, 27);
            kullaniciMailTextBox.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(185, 317);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 47;
            label6.Text = "Boy";
            // 
            // kullaniciSifreTextBox
            // 
            kullaniciSifreTextBox.Location = new Point(334, 143);
            kullaniciSifreTextBox.Name = "kullaniciSifreTextBox";
            kullaniciSifreTextBox.Size = new Size(274, 27);
            kullaniciSifreTextBox.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(185, 283);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 46;
            label5.Text = "Yaş";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(185, 117);
            label10.Name = "label10";
            label10.Size = new Size(98, 20);
            label10.TabIndex = 37;
            label10.Text = "Kullanıcı Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 245);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 45;
            label4.Text = "Soyisim";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(185, 149);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 38;
            label9.Text = "Kullanıcı Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 216);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 44;
            label3.Text = "İsim";
            // 
            // boyTextBox
            // 
            boyTextBox.Location = new Point(334, 311);
            boyTextBox.Name = "boyTextBox";
            boyTextBox.Size = new Size(274, 27);
            boyTextBox.TabIndex = 39;
            // 
            // isimTextBox
            // 
            isimTextBox.Location = new Point(334, 213);
            isimTextBox.Name = "isimTextBox";
            isimTextBox.Size = new Size(274, 27);
            isimTextBox.TabIndex = 43;
            // 
            // yasTextBox
            // 
            yasTextBox.Location = new Point(336, 277);
            yasTextBox.Name = "yasTextBox";
            yasTextBox.Size = new Size(274, 27);
            yasTextBox.TabIndex = 40;
            // 
            // soyisimTextBox
            // 
            soyisimTextBox.Location = new Point(334, 245);
            soyisimTextBox.Name = "soyisimTextBox";
            soyisimTextBox.Size = new Size(274, 27);
            soyisimTextBox.TabIndex = 42;
            // 
            // kiloTextBox
            // 
            kiloTextBox.Location = new Point(336, 343);
            kiloTextBox.Name = "kiloTextBox";
            kiloTextBox.Size = new Size(274, 27);
            kiloTextBox.TabIndex = 41;
            // 
            // button11
            // 
            button11.Location = new Point(3, 81);
            button11.Name = "button11";
            button11.Size = new Size(159, 29);
            button11.TabIndex = 29;
            button11.Text = "Yemek Çeşidi Raporu";
            button11.UseVisualStyleBackColor = true;
            button11.Click += YemekCesidiRaporClick;
            // 
            // KiyasRaporBtn
            // 
            KiyasRaporBtn.Location = new Point(3, 45);
            KiyasRaporBtn.Name = "KiyasRaporBtn";
            KiyasRaporBtn.Size = new Size(159, 29);
            KiyasRaporBtn.TabIndex = 28;
            KiyasRaporBtn.Text = "Kıyas Raporları";
            KiyasRaporBtn.UseVisualStyleBackColor = true;
            KiyasRaporBtn.Click += KiyasRaporuClick;
            // 
            // GunSonuRaporuBtn
            // 
            GunSonuRaporuBtn.Location = new Point(3, 11);
            GunSonuRaporuBtn.Name = "GunSonuRaporuBtn";
            GunSonuRaporuBtn.Size = new Size(159, 29);
            GunSonuRaporuBtn.TabIndex = 27;
            GunSonuRaporuBtn.Text = "Gün Sonu Raporu";
            GunSonuRaporuBtn.UseVisualStyleBackColor = true;
            GunSonuRaporuBtn.Click += GunSonuRaporuClick;
            // 
            // RaporPanel
            // 
            RaporPanel.Controls.Add(pictureBox16);
            RaporPanel.Controls.Add(pictureBox17);
            RaporPanel.Controls.Add(pictureBox18);
            RaporPanel.Controls.Add(Geri_Panel4);
            RaporPanel.Controls.Add(AylikRadioBtn);
            RaporPanel.Controls.Add(HaftalikRadioBtn);
            RaporPanel.Controls.Add(RaporlarDateTimePicker);
            RaporPanel.Controls.Add(kiyasRaporOgunListBox);
            RaporPanel.Controls.Add(GunSonuKiyasRaporListBox);
            RaporPanel.Controls.Add(button11);
            RaporPanel.Controls.Add(KiyasRaporBtn);
            RaporPanel.Controls.Add(GunSonuRaporuBtn);
            RaporPanel.Dock = DockStyle.Fill;
            RaporPanel.Location = new Point(0, 0);
            RaporPanel.Name = "RaporPanel";
            RaporPanel.Size = new Size(982, 753);
            RaporPanel.TabIndex = 19;
            RaporPanel.Paint += panel4_Paint;
            // 
            // pictureBox16
            // 
            pictureBox16.Image = Properties.Resources.istockphoto_835271096_612x612;
            pictureBox16.Location = new Point(648, 421);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(614, 411);
            pictureBox16.TabIndex = 62;
            pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.Image = Properties.Resources.istockphoto_1141120666_612x612;
            pictureBox17.Location = new Point(1285, 11);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(614, 405);
            pictureBox17.TabIndex = 61;
            pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.Image = Properties.Resources.istockphoto_525343659_612x612;
            pictureBox18.Location = new Point(648, 11);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(614, 405);
            pictureBox18.TabIndex = 60;
            pictureBox18.TabStop = false;
            // 
            // Geri_Panel4
            // 
            Geri_Panel4.Location = new Point(513, 3);
            Geri_Panel4.Name = "Geri_Panel4";
            Geri_Panel4.Size = new Size(94, 29);
            Geri_Panel4.TabIndex = 49;
            Geri_Panel4.Text = "Geri";
            Geri_Panel4.UseVisualStyleBackColor = true;
            Geri_Panel4.Click += Geri_Panel4_Click;
            // 
            // AylikRadioBtn
            // 
            AylikRadioBtn.AutoSize = true;
            AylikRadioBtn.Location = new Point(266, 51);
            AylikRadioBtn.Margin = new Padding(3, 4, 3, 4);
            AylikRadioBtn.Name = "AylikRadioBtn";
            AylikRadioBtn.Size = new Size(62, 24);
            AylikRadioBtn.TabIndex = 48;
            AylikRadioBtn.TabStop = true;
            AylikRadioBtn.Text = "Aylık";
            AylikRadioBtn.UseVisualStyleBackColor = true;
            // 
            // HaftalikRadioBtn
            // 
            HaftalikRadioBtn.AutoSize = true;
            HaftalikRadioBtn.Location = new Point(178, 51);
            HaftalikRadioBtn.Margin = new Padding(3, 4, 3, 4);
            HaftalikRadioBtn.Name = "HaftalikRadioBtn";
            HaftalikRadioBtn.Size = new Size(82, 24);
            HaftalikRadioBtn.TabIndex = 48;
            HaftalikRadioBtn.TabStop = true;
            HaftalikRadioBtn.Text = "Haftalık";
            HaftalikRadioBtn.UseVisualStyleBackColor = true;
            // 
            // RaporlarDateTimePicker
            // 
            RaporlarDateTimePicker.Location = new Point(178, 13);
            RaporlarDateTimePicker.Name = "RaporlarDateTimePicker";
            RaporlarDateTimePicker.Size = new Size(150, 27);
            RaporlarDateTimePicker.TabIndex = 47;
            // 
            // kiyasRaporOgunListBox
            // 
            kiyasRaporOgunListBox.FormattingEnabled = true;
            kiyasRaporOgunListBox.ItemHeight = 20;
            kiyasRaporOgunListBox.Location = new Point(3, 388);
            kiyasRaporOgunListBox.Name = "kiyasRaporOgunListBox";
            kiyasRaporOgunListBox.Size = new Size(604, 204);
            kiyasRaporOgunListBox.TabIndex = 33;
            // 
            // GunSonuKiyasRaporListBox
            // 
            GunSonuKiyasRaporListBox.FormattingEnabled = true;
            GunSonuKiyasRaporListBox.ItemHeight = 20;
            GunSonuKiyasRaporListBox.Location = new Point(7, 167);
            GunSonuKiyasRaporListBox.Name = "GunSonuKiyasRaporListBox";
            GunSonuKiyasRaporListBox.Size = new Size(601, 204);
            GunSonuKiyasRaporListBox.TabIndex = 33;
            GunSonuKiyasRaporListBox.SelectedIndexChanged += GunSonuKiyasRaporListBoxSelectedIndexChanged;
            // 
            // YemekEkleBtn
            // 
            YemekEkleBtn.Location = new Point(238, 388);
            YemekEkleBtn.Name = "YemekEkleBtn";
            YemekEkleBtn.Size = new Size(94, 29);
            YemekEkleBtn.TabIndex = 20;
            YemekEkleBtn.Text = "Yemek Ekle";
            YemekEkleBtn.UseVisualStyleBackColor = true;
            YemekEkleBtn.Click += YemekEkleBtnClick;
            // 
            // OgunEkleBtn
            // 
            OgunEkleBtn.Location = new Point(26, 465);
            OgunEkleBtn.Name = "OgunEkleBtn";
            OgunEkleBtn.Size = new Size(94, 29);
            OgunEkleBtn.TabIndex = 21;
            OgunEkleBtn.Text = "Öğün Ekle";
            OgunEkleBtn.UseVisualStyleBackColor = true;
            OgunEkleBtn.Click += OgunEkleBtnClick;
            // 
            // RaporlarBtn
            // 
            RaporlarBtn.Location = new Point(18, 619);
            RaporlarBtn.Name = "RaporlarBtn";
            RaporlarBtn.Size = new Size(94, 29);
            RaporlarBtn.TabIndex = 24;
            RaporlarBtn.Text = "Raporlar";
            RaporlarBtn.UseVisualStyleBackColor = true;
            RaporlarBtn.Click += RaporlarBtnClick;
            // 
            // YemekComboBox
            // 
            YemekComboBox.FormattingEnabled = true;
            YemekComboBox.Location = new Point(211, 359);
            YemekComboBox.Name = "YemekComboBox";
            YemekComboBox.Size = new Size(140, 28);
            YemekComboBox.TabIndex = 25;
            YemekComboBox.SelectedIndexChanged += YemekComboBox_SelectedIndexChanged;
            // 
            // OgunConboBox
            // 
            OgunConboBox.FormattingEnabled = true;
            OgunConboBox.Location = new Point(18, 359);
            OgunConboBox.Name = "OgunConboBox";
            OgunConboBox.Size = new Size(177, 28);
            OgunConboBox.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 157);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 28;
            label11.Text = "Isim:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(35, 192);
            label12.Name = "label12";
            label12.Size = new Size(53, 20);
            label12.TabIndex = 29;
            label12.Text = "Soyad:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(38, 227);
            label13.Name = "label13";
            label13.Size = new Size(37, 20);
            label13.TabIndex = 30;
            label13.Text = "Boy:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(38, 261);
            label14.Name = "label14";
            label14.Size = new Size(38, 20);
            label14.TabIndex = 31;
            label14.Text = "Kilo:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(110, 115);
            label15.Name = "label15";
            label15.Size = new Size(99, 20);
            label15.TabIndex = 20;
            label15.Text = "Profil Bilgileri";
            // 
            // IsimLbl
            // 
            IsimLbl.AutoSize = true;
            IsimLbl.Location = new Point(110, 157);
            IsimLbl.Name = "IsimLbl";
            IsimLbl.Size = new Size(99, 20);
            IsimLbl.TabIndex = 36;
            IsimLbl.Text = "Profil Bilgileri";
            // 
            // SoyadLbl
            // 
            SoyadLbl.AutoSize = true;
            SoyadLbl.Location = new Point(110, 195);
            SoyadLbl.Name = "SoyadLbl";
            SoyadLbl.Size = new Size(99, 20);
            SoyadLbl.TabIndex = 37;
            SoyadLbl.Text = "Profil Bilgileri";
            // 
            // BoyLbl
            // 
            BoyLbl.AutoSize = true;
            BoyLbl.Location = new Point(110, 227);
            BoyLbl.Name = "BoyLbl";
            BoyLbl.Size = new Size(99, 20);
            BoyLbl.TabIndex = 38;
            BoyLbl.Text = "Profil Bilgileri";
            // 
            // KilooLbl
            // 
            KilooLbl.AutoSize = true;
            KilooLbl.Location = new Point(110, 261);
            KilooLbl.Name = "KilooLbl";
            KilooLbl.Size = new Size(99, 20);
            KilooLbl.TabIndex = 39;
            KilooLbl.Text = "Profil Bilgileri";
            // 
            // OgunEklePanel
            // 
            OgunEklePanel.Controls.Add(label28);
            OgunEklePanel.Controls.Add(label27);
            OgunEklePanel.Controls.Add(label26);
            OgunEklePanel.Controls.Add(pictureBox8);
            OgunEklePanel.Controls.Add(Geri_Panel3);
            OgunEklePanel.Controls.Add(OgunEkleDateTimePicker);
            OgunEklePanel.Controls.Add(OgunGuncelleSilBtn);
            OgunEklePanel.Controls.Add(porsiyonyaztextBox1);
            OgunEklePanel.Controls.Add(label22);
            OgunEklePanel.Controls.Add(label21);
            OgunEklePanel.Controls.Add(label20);
            OgunEklePanel.Controls.Add(KilooLbl);
            OgunEklePanel.Controls.Add(BoyLbl);
            OgunEklePanel.Controls.Add(SoyadLbl);
            OgunEklePanel.Controls.Add(IsimLbl);
            OgunEklePanel.Controls.Add(label15);
            OgunEklePanel.Controls.Add(label14);
            OgunEklePanel.Controls.Add(label13);
            OgunEklePanel.Controls.Add(label12);
            OgunEklePanel.Controls.Add(label11);
            OgunEklePanel.Controls.Add(OgunConboBox);
            OgunEklePanel.Controls.Add(YemekComboBox);
            OgunEklePanel.Controls.Add(RaporlarBtn);
            OgunEklePanel.Controls.Add(OgunEkleBtn);
            OgunEklePanel.Controls.Add(YemekEkleBtn);
            OgunEklePanel.Dock = DockStyle.Fill;
            OgunEklePanel.Location = new Point(0, 0);
            OgunEklePanel.Name = "OgunEklePanel";
            OgunEklePanel.Size = new Size(982, 753);
            OgunEklePanel.TabIndex = 18;
            OgunEklePanel.Paint += panel3_Paint;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(18, 651);
            label28.Name = "label28";
            label28.Size = new Size(226, 20);
            label28.TabIndex = 56;
            label28.Text = "Öğün ve Yemek Güncelle veya Sil";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(18, 596);
            label27.Name = "label27";
            label27.Size = new Size(139, 20);
            label27.TabIndex = 55;
            label27.Text = "Raporları Görüntüle";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(18, 521);
            label26.Name = "label26";
            label26.Size = new Size(175, 20);
            label26.TabIndex = 54;
            label26.Text = "Ekleme Yapacağınız Tarih";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Yemek;
            pictureBox8.Location = new Point(373, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(614, 405);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 52;
            pictureBox8.TabStop = false;
            // 
            // Geri_Panel3
            // 
            Geri_Panel3.Location = new Point(18, 11);
            Geri_Panel3.Name = "Geri_Panel3";
            Geri_Panel3.Size = new Size(94, 29);
            Geri_Panel3.TabIndex = 50;
            Geri_Panel3.Text = "Geri";
            Geri_Panel3.UseVisualStyleBackColor = true;
            Geri_Panel3.Click += Geri_Panel3_Click;
            // 
            // OgunEkleDateTimePicker
            // 
            OgunEkleDateTimePicker.Location = new Point(18, 544);
            OgunEkleDateTimePicker.Name = "OgunEkleDateTimePicker";
            OgunEkleDateTimePicker.Size = new Size(250, 27);
            OgunEkleDateTimePicker.TabIndex = 46;
            // 
            // OgunGuncelleSilBtn
            // 
            OgunGuncelleSilBtn.Location = new Point(18, 675);
            OgunGuncelleSilBtn.Name = "OgunGuncelleSilBtn";
            OgunGuncelleSilBtn.Size = new Size(153, 32);
            OgunGuncelleSilBtn.TabIndex = 45;
            OgunGuncelleSilBtn.Text = "Güncelle veya Sil";
            OgunGuncelleSilBtn.UseVisualStyleBackColor = true;
            OgunGuncelleSilBtn.Click += OgunGuncelleSilClick;
            // 
            // porsiyonyaztextBox1
            // 
            porsiyonyaztextBox1.Location = new Point(18, 423);
            porsiyonyaztextBox1.Name = "porsiyonyaztextBox1";
            porsiyonyaztextBox1.Size = new Size(125, 27);
            porsiyonyaztextBox1.TabIndex = 44;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(30, 399);
            label22.Name = "label22";
            label22.Size = new Size(90, 20);
            label22.TabIndex = 43;
            label22.Text = "Porsiyon Yaz";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(238, 333);
            label21.Name = "label21";
            label21.Size = new Size(79, 20);
            label21.TabIndex = 42;
            label21.Text = "Yemek Seç";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(30, 336);
            label20.Name = "label20";
            label20.Size = new Size(72, 20);
            label20.TabIndex = 21;
            label20.Text = "Öğün Seç";
            // 
            // YemekGuncellePanel
            // 
            YemekGuncellePanel.Controls.Add(OpenFileDialog);
            YemekGuncellePanel.Controls.Add(MevcutYemekListBox);
            YemekGuncellePanel.Controls.Add(dateTimePicker2);
            YemekGuncellePanel.Controls.Add(YemekSilBtn);
            YemekGuncellePanel.Controls.Add(YemekGuncelleBtn);
            YemekGuncellePanel.Controls.Add(pictureBox10);
            YemekGuncellePanel.Controls.Add(Geri_Panel5);
            YemekGuncellePanel.Controls.Add(katagorilistcomboBox2);
            YemekGuncellePanel.Controls.Add(NewYemekEkleBtn);
            YemekGuncellePanel.Controls.Add(YemekAdiEktextBox2);
            YemekGuncellePanel.Controls.Add(KalorimikektextBox3);
            YemekGuncellePanel.Controls.Add(label19);
            YemekGuncellePanel.Controls.Add(label18);
            YemekGuncellePanel.Controls.Add(label17);
            YemekGuncellePanel.Controls.Add(label16);
            YemekGuncellePanel.Dock = DockStyle.Fill;
            YemekGuncellePanel.Location = new Point(0, 0);
            YemekGuncellePanel.Name = "YemekGuncellePanel";
            YemekGuncellePanel.Size = new Size(982, 753);
            YemekGuncellePanel.TabIndex = 20;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.Location = new Point(114, 152);
            OpenFileDialog.Margin = new Padding(3, 4, 3, 4);
            OpenFileDialog.Name = "OpenFileDialog";
            OpenFileDialog.Size = new Size(126, 31);
            OpenFileDialog.TabIndex = 61;
            OpenFileDialog.Text = "Resim Ekle";
            OpenFileDialog.UseVisualStyleBackColor = true;
            OpenFileDialog.Click += OpenFileDialog_Click;
            // 
            // MevcutYemekListBox
            // 
            MevcutYemekListBox.FormattingEnabled = true;
            MevcutYemekListBox.ItemHeight = 20;
            MevcutYemekListBox.Location = new Point(11, 336);
            MevcutYemekListBox.Name = "MevcutYemekListBox";
            MevcutYemekListBox.Size = new Size(305, 404);
            MevcutYemekListBox.TabIndex = 60;
            MevcutYemekListBox.SelectedIndexChanged += MevcutYemekListBox_SelectedIndexChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(18, 275);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 59;
            // 
            // YemekSilBtn
            // 
            YemekSilBtn.Location = new Point(223, 223);
            YemekSilBtn.Name = "YemekSilBtn";
            YemekSilBtn.Size = new Size(94, 29);
            YemekSilBtn.TabIndex = 58;
            YemekSilBtn.Text = "Sil";
            YemekSilBtn.UseVisualStyleBackColor = true;
            YemekSilBtn.Click += YemekSilBtn_Click;
            // 
            // YemekGuncelleBtn
            // 
            YemekGuncelleBtn.Location = new Point(118, 223);
            YemekGuncelleBtn.Name = "YemekGuncelleBtn";
            YemekGuncelleBtn.Size = new Size(94, 29);
            YemekGuncelleBtn.TabIndex = 57;
            YemekGuncelleBtn.Text = "Güncelle";
            YemekGuncelleBtn.UseVisualStyleBackColor = true;
            YemekGuncelleBtn.Click += YemekGuncelleBtn_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Yemek;
            pictureBox10.Location = new Point(359, 81);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(614, 411);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 56;
            pictureBox10.TabStop = false;
            // 
            // Geri_Panel5
            // 
            Geri_Panel5.Location = new Point(294, 35);
            Geri_Panel5.Name = "Geri_Panel5";
            Geri_Panel5.Size = new Size(94, 29);
            Geri_Panel5.TabIndex = 33;
            Geri_Panel5.Text = "Geri";
            Geri_Panel5.UseVisualStyleBackColor = true;
            Geri_Panel5.Click += Geri_Panel5_Click;
            // 
            // katagorilistcomboBox2
            // 
            katagorilistcomboBox2.FormattingEnabled = true;
            katagorilistcomboBox2.Location = new Point(119, 107);
            katagorilistcomboBox2.Name = "katagorilistcomboBox2";
            katagorilistcomboBox2.Size = new Size(125, 28);
            katagorilistcomboBox2.TabIndex = 21;
            // 
            // NewYemekEkleBtn
            // 
            NewYemekEkleBtn.Location = new Point(18, 223);
            NewYemekEkleBtn.Name = "NewYemekEkleBtn";
            NewYemekEkleBtn.Size = new Size(94, 29);
            NewYemekEkleBtn.TabIndex = 21;
            NewYemekEkleBtn.Text = "Ekle";
            NewYemekEkleBtn.UseVisualStyleBackColor = true;
            NewYemekEkleBtn.Click += YemekEkleClick;
            // 
            // YemekAdiEktextBox2
            // 
            YemekAdiEktextBox2.Location = new Point(119, 32);
            YemekAdiEktextBox2.Name = "YemekAdiEktextBox2";
            YemekAdiEktextBox2.Size = new Size(125, 27);
            YemekAdiEktextBox2.TabIndex = 22;
            // 
            // KalorimikektextBox3
            // 
            KalorimikektextBox3.Location = new Point(119, 69);
            KalorimikektextBox3.Name = "KalorimikektextBox3";
            KalorimikektextBox3.Size = new Size(125, 27);
            KalorimikektextBox3.TabIndex = 23;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(38, 157);
            label19.Name = "label19";
            label19.Size = new Size(52, 20);
            label19.TabIndex = 32;
            label19.Text = "Resim:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(35, 109);
            label18.Name = "label18";
            label18.Size = new Size(69, 20);
            label18.TabIndex = 31;
            label18.Text = "Kategori:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(38, 73);
            label17.Name = "label17";
            label17.Size = new Size(51, 20);
            label17.TabIndex = 30;
            label17.Text = "Kalori:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(38, 35);
            label16.Name = "label16";
            label16.Size = new Size(82, 20);
            label16.TabIndex = 29;
            label16.Text = "Yemek Adı:";
            // 
            // OgunGuncellePanel
            // 
            OgunGuncellePanel.Controls.Add(pictureBox14);
            OgunGuncellePanel.Controls.Add(OgunGuncelleDateTimePicker);
            OgunGuncellePanel.Controls.Add(OgunUpdateDeleteYemekCombobox);
            OgunGuncellePanel.Controls.Add(label25);
            OgunGuncellePanel.Controls.Add(porsiyonYazTextBox);
            OgunGuncellePanel.Controls.Add(label23);
            OgunGuncellePanel.Controls.Add(label24);
            OgunGuncellePanel.Controls.Add(OgunUpdateDeleteOgunCombobox);
            OgunGuncellePanel.Controls.Add(Geri_panel6);
            OgunGuncellePanel.Controls.Add(Öğün_Sil);
            OgunGuncellePanel.Controls.Add(OgunUpdateDeleteListBox);
            OgunGuncellePanel.Controls.Add(Ögün_Güncelle);
            OgunGuncellePanel.Dock = DockStyle.Fill;
            OgunGuncellePanel.Location = new Point(0, 0);
            OgunGuncellePanel.Name = "OgunGuncellePanel";
            OgunGuncellePanel.Size = new Size(982, 753);
            OgunGuncellePanel.TabIndex = 21;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources.istockphoto_1141120666_612x612;
            pictureBox14.Location = new Point(313, 51);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(255, 225);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.TabIndex = 58;
            pictureBox14.TabStop = false;
            // 
            // OgunGuncelleDateTimePicker
            // 
            OgunGuncelleDateTimePicker.Location = new Point(266, 347);
            OgunGuncelleDateTimePicker.Name = "OgunGuncelleDateTimePicker";
            OgunGuncelleDateTimePicker.Size = new Size(250, 27);
            OgunGuncelleDateTimePicker.TabIndex = 53;
            OgunGuncelleDateTimePicker.ValueChanged += OgunGuncelleDateTimePicker_ValueChanged;
            // 
            // OgunUpdateDeleteYemekCombobox
            // 
            OgunUpdateDeleteYemekCombobox.FormattingEnabled = true;
            OgunUpdateDeleteYemekCombobox.Location = new Point(43, 171);
            OgunUpdateDeleteYemekCombobox.Name = "OgunUpdateDeleteYemekCombobox";
            OgunUpdateDeleteYemekCombobox.Size = new Size(140, 28);
            OgunUpdateDeleteYemekCombobox.TabIndex = 52;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(54, 147);
            label25.Name = "label25";
            label25.Size = new Size(78, 20);
            label25.TabIndex = 50;
            label25.Text = "Yemek Yaz";
            // 
            // porsiyonYazTextBox
            // 
            porsiyonYazTextBox.Location = new Point(43, 115);
            porsiyonYazTextBox.Name = "porsiyonYazTextBox";
            porsiyonYazTextBox.Size = new Size(125, 27);
            porsiyonYazTextBox.TabIndex = 49;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(57, 91);
            label23.Name = "label23";
            label23.Size = new Size(90, 20);
            label23.TabIndex = 48;
            label23.Text = "Porsiyon Yaz";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(57, 27);
            label24.Name = "label24";
            label24.Size = new Size(72, 20);
            label24.TabIndex = 45;
            label24.Text = "Öğün Seç";
            // 
            // OgunUpdateDeleteOgunCombobox
            // 
            OgunUpdateDeleteOgunCombobox.FormattingEnabled = true;
            OgunUpdateDeleteOgunCombobox.Location = new Point(43, 51);
            OgunUpdateDeleteOgunCombobox.Name = "OgunUpdateDeleteOgunCombobox";
            OgunUpdateDeleteOgunCombobox.Size = new Size(177, 28);
            OgunUpdateDeleteOgunCombobox.TabIndex = 47;
            // 
            // Geri_panel6
            // 
            Geri_panel6.Location = new Point(313, 12);
            Geri_panel6.Name = "Geri_panel6";
            Geri_panel6.Size = new Size(94, 29);
            Geri_panel6.TabIndex = 22;
            Geri_panel6.Text = "Geri";
            Geri_panel6.UseVisualStyleBackColor = true;
            Geri_panel6.Click += Geri_panel6_Click;
            // 
            // Öğün_Sil
            // 
            Öğün_Sil.Location = new Point(266, 380);
            Öğün_Sil.Name = "Öğün_Sil";
            Öğün_Sil.Size = new Size(127, 29);
            Öğün_Sil.TabIndex = 23;
            Öğün_Sil.Text = "Öğün Sil";
            Öğün_Sil.UseVisualStyleBackColor = true;
            Öğün_Sil.Click += Öğün_Sil_Click;
            // 
            // OgunUpdateDeleteListBox
            // 
            OgunUpdateDeleteListBox.FormattingEnabled = true;
            OgunUpdateDeleteListBox.ItemHeight = 20;
            OgunUpdateDeleteListBox.Location = new Point(35, 347);
            OgunUpdateDeleteListBox.Name = "OgunUpdateDeleteListBox";
            OgunUpdateDeleteListBox.Size = new Size(220, 344);
            OgunUpdateDeleteListBox.TabIndex = 0;
            OgunUpdateDeleteListBox.SelectedIndexChanged += OgunUpdateDeleteListBoxSelectedIndexChanged;
            // 
            // Ögün_Güncelle
            // 
            Ögün_Güncelle.Location = new Point(266, 415);
            Ögün_Güncelle.Name = "Ögün_Güncelle";
            Ögün_Güncelle.Size = new Size(127, 29);
            Ögün_Güncelle.TabIndex = 22;
            Ögün_Güncelle.Text = "Öğün Güncelle";
            Ögün_Güncelle.UseVisualStyleBackColor = true;
            Ögün_Güncelle.Click += Ögün_Güncelle_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // GirişEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(OgunEklePanel);
            Controls.Add(YemekGuncellePanel);
            Controls.Add(OgunGuncellePanel);
            Controls.Add(GirisPanel);
            Controls.Add(RaporPanel);
            Controls.Add(KayitOlPanel);
            Name = "GirişEkranı";
            Text = "GirişEkranı";
            Load += GirişEkranı_Load;
            GirisPanel.ResumeLayout(false);
            GirisPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            KayitOlPanel.ResumeLayout(false);
            KayitOlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            RaporPanel.ResumeLayout(false);
            RaporPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            OgunEklePanel.ResumeLayout(false);
            OgunEklePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            YemekGuncellePanel.ResumeLayout(false);
            YemekGuncellePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            OgunGuncellePanel.ResumeLayout(false);
            OgunGuncellePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
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
        private Panel GirisPanel;
        private Panel KayitOlPanel;
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
        private Panel RaporPanel;
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
        private Panel OgunEklePanel;
        private Panel YemekGuncellePanel;
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
        private Panel OgunGuncellePanel;
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
        private Button Geri_panel1;
        private Button Geri_Panel4;
        private Button Geri_Panel3;
        private Button Geri_Panel5;
        private DateTimePicker OgunGuncelleDateTimePicker;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label27;
        private Label label26;
        private PictureBox pictureBox8;
        private Label label28;
        private PictureBox pictureBox10;
        private ListBox MevcutYemekListBox;
        private DateTimePicker dateTimePicker2;
        private Button YemekSilBtn;
        private Button YemekGuncelleBtn;
        private PictureBox pictureBox14;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private Button OpenFileDialog;
        private OpenFileDialog openFileDialog1;
    }
}