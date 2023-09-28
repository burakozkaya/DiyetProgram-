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
            button1 = new Button();
            KullaniciAdiTextBox = new TextBox();
            SifreTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            button3 = new Button();
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
            button10 = new Button();
            button9 = new Button();
            panel4 = new Panel();
            RaporLbl = new Label();
            button8 = new Button();
            button12 = new Button();
            button7 = new Button();
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
            label21 = new Label();
            label20 = new Label();
            comboBox1 = new ComboBox();
            button4 = new Button();
            panel5 = new Panel();
            katagorilistcomboBox2 = new ComboBox();
            button5 = new Button();
            YemekAdiEktextBox2 = new TextBox();
            KalorimikektextBox3 = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // button1
            // 
            button1.Location = new Point(327, 118);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // KullaniciAdiTextBox
            // 
            KullaniciAdiTextBox.Location = new Point(146, 52);
            KullaniciAdiTextBox.Name = "KullaniciAdiTextBox";
            KullaniciAdiTextBox.Size = new Size(275, 27);
            KullaniciAdiTextBox.TabIndex = 1;
            // 
            // SifreTextBox
            // 
            SifreTextBox.Location = new Point(146, 85);
            SifreTextBox.Name = "SifreTextBox";
            SifreTextBox.Size = new Size(274, 27);
            SifreTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 55);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 88);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Şifre";
            // 
            // button2
            // 
            button2.Location = new Point(227, 118);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Kayıt Ol";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 304);
            panel1.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SifreTextBox);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(KullaniciAdiTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(542, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 338);
            panel2.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
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
            groupBox2.Location = new Point(53, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(532, 342);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(385, 263);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 51;
            button3.Text = "Kayıt Ol";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 66);
            label8.Name = "label8";
            label8.Size = new Size(143, 20);
            label8.TabIndex = 50;
            label8.Text = "Kullanıcı Şifre Tekrar";
            // 
            // kullaniciSifreTekrariTextBox
            // 
            kullaniciSifreTekrariTextBox.Location = new Point(203, 63);
            kullaniciSifreTekrariTextBox.Name = "kullaniciSifreTekrariTextBox";
            kullaniciSifreTekrariTextBox.Size = new Size(274, 27);
            kullaniciSifreTekrariTextBox.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(100, 237);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 48;
            label7.Text = "Kilo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 204);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 47;
            label6.Text = "Boy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 171);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 46;
            label5.Text = "Yaş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 138);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 45;
            label4.Text = "Soyisim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 105);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 44;
            label3.Text = "İsim";
            // 
            // isimTextBox
            // 
            isimTextBox.Location = new Point(203, 98);
            isimTextBox.Name = "isimTextBox";
            isimTextBox.Size = new Size(274, 27);
            isimTextBox.TabIndex = 43;
            // 
            // soyisimTextBox
            // 
            soyisimTextBox.Location = new Point(204, 131);
            soyisimTextBox.Name = "soyisimTextBox";
            soyisimTextBox.Size = new Size(274, 27);
            soyisimTextBox.TabIndex = 42;
            // 
            // kiloTextBox
            // 
            kiloTextBox.Location = new Point(205, 230);
            kiloTextBox.Name = "kiloTextBox";
            kiloTextBox.Size = new Size(274, 27);
            kiloTextBox.TabIndex = 41;
            // 
            // yasTextBox
            // 
            yasTextBox.Location = new Point(205, 164);
            yasTextBox.Name = "yasTextBox";
            yasTextBox.Size = new Size(274, 27);
            yasTextBox.TabIndex = 40;
            // 
            // boyTextBox
            // 
            boyTextBox.Location = new Point(204, 197);
            boyTextBox.Name = "boyTextBox";
            boyTextBox.Size = new Size(274, 27);
            boyTextBox.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(99, 33);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 38;
            label9.Text = "Kullanıcı Şifre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(100, 0);
            label10.Name = "label10";
            label10.Size = new Size(98, 20);
            label10.TabIndex = 37;
            label10.Text = "Kullanıcı Mail";
            // 
            // kullaniciSifreTextBox
            // 
            kullaniciSifreTextBox.Location = new Point(204, 30);
            kullaniciSifreTextBox.Name = "kullaniciSifreTextBox";
            kullaniciSifreTextBox.Size = new Size(274, 27);
            kullaniciSifreTextBox.TabIndex = 36;
            // 
            // kullaniciMailTextBox
            // 
            kullaniciMailTextBox.Location = new Point(204, -3);
            kullaniciMailTextBox.Name = "kullaniciMailTextBox";
            kullaniciMailTextBox.Size = new Size(275, 27);
            kullaniciMailTextBox.TabIndex = 35;
            kullaniciMailTextBox.TextChanged += kullaniciMailTextBox_TextChanged;
            // 
            // button11
            // 
            button11.Location = new Point(23, 82);
            button11.Name = "button11";
            button11.Size = new Size(159, 29);
            button11.TabIndex = 29;
            button11.Text = "Yemek Çeşidi Raporu";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(23, 47);
            button10.Name = "button10";
            button10.Size = new Size(159, 29);
            button10.TabIndex = 28;
            button10.Text = "Kıyas Raporları";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(23, 12);
            button9.Name = "button9";
            button9.Size = new Size(159, 29);
            button9.TabIndex = 27;
            button9.Text = "Gün Sonu Raporu";
            button9.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(RaporLbl);
            panel4.Controls.Add(button11);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(button9);
            panel4.Location = new Point(74, 375);
            panel4.Name = "panel4";
            panel4.Size = new Size(681, 125);
            panel4.TabIndex = 19;
            // 
            // RaporLbl
            // 
            RaporLbl.AutoSize = true;
            RaporLbl.Location = new Point(290, 47);
            RaporLbl.Name = "RaporLbl";
            RaporLbl.Size = new Size(58, 20);
            RaporLbl.TabIndex = 20;
            RaporLbl.Text = "label11";
            // 
            // button8
            // 
            button8.Location = new Point(387, 19);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 20;
            button8.Text = "Yemek Ekle";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button12
            // 
            button12.Location = new Point(3, 152);
            button12.Name = "button12";
            button12.Size = new Size(94, 29);
            button12.TabIndex = 21;
            button12.Text = "Öğün Ekle";
            button12.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(301, 322);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 24;
            button7.Text = "Raporlar";
            button7.UseVisualStyleBackColor = true;
            // 
            // YemekComboBox
            // 
            YemekComboBox.FormattingEnabled = true;
            YemekComboBox.Location = new Point(341, 118);
            YemekComboBox.Name = "YemekComboBox";
            YemekComboBox.Size = new Size(140, 28);
            YemekComboBox.TabIndex = 25;
            // 
            // OgunConboBox
            // 
            OgunConboBox.FormattingEnabled = true;
            OgunConboBox.Location = new Point(141, 118);
            OgunConboBox.Name = "OgunConboBox";
            OgunConboBox.Size = new Size(177, 28);
            OgunConboBox.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 293);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 28;
            label11.Text = "Isim:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 328);
            label12.Name = "label12";
            label12.Size = new Size(53, 20);
            label12.TabIndex = 29;
            label12.Text = "Soyad:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 363);
            label13.Name = "label13";
            label13.Size = new Size(37, 20);
            label13.TabIndex = 30;
            label13.Text = "Boy:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 398);
            label14.Name = "label14";
            label14.Size = new Size(38, 20);
            label14.TabIndex = 31;
            label14.Text = "Kilo:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(86, 251);
            label15.Name = "label15";
            label15.Size = new Size(99, 20);
            label15.TabIndex = 20;
            label15.Text = "Profil Bilgileri";
            // 
            // IsimLbl
            // 
            IsimLbl.AutoSize = true;
            IsimLbl.Location = new Point(86, 293);
            IsimLbl.Name = "IsimLbl";
            IsimLbl.Size = new Size(99, 20);
            IsimLbl.TabIndex = 36;
            IsimLbl.Text = "Profil Bilgileri";
            // 
            // SoyadLbl
            // 
            SoyadLbl.AutoSize = true;
            SoyadLbl.Location = new Point(86, 331);
            SoyadLbl.Name = "SoyadLbl";
            SoyadLbl.Size = new Size(99, 20);
            SoyadLbl.TabIndex = 37;
            SoyadLbl.Text = "Profil Bilgileri";
            // 
            // BoyLbl
            // 
            BoyLbl.AutoSize = true;
            BoyLbl.Location = new Point(86, 363);
            BoyLbl.Name = "BoyLbl";
            BoyLbl.Size = new Size(99, 20);
            BoyLbl.TabIndex = 38;
            BoyLbl.Text = "Profil Bilgileri";
            // 
            // KilooLbl
            // 
            KilooLbl.AutoSize = true;
            KilooLbl.Location = new Point(86, 398);
            KilooLbl.Name = "KilooLbl";
            KilooLbl.Size = new Size(99, 20);
            KilooLbl.TabIndex = 39;
            KilooLbl.Text = "Profil Bilgileri";
            // 
            // panel3
            // 
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(button4);
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
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button12);
            panel3.Controls.Add(button8);
            panel3.Location = new Point(1170, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(513, 455);
            panel3.TabIndex = 18;
            panel3.Paint += panel3_Paint;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(375, 161);
            label21.Name = "label21";
            label21.Size = new Size(79, 20);
            label21.TabIndex = 42;
            label21.Text = "Yemek Seç";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(189, 161);
            label20.Name = "label20";
            label20.Size = new Size(72, 20);
            label20.TabIndex = 21;
            label20.Text = "Öğün Seç";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(-5, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 28);
            comboBox1.TabIndex = 41;
            // 
            // button4
            // 
            button4.Location = new Point(3, 181);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 40;
            button4.Text = "Öğün Sil";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(katagorilistcomboBox2);
            panel5.Controls.Add(button5);
            panel5.Controls.Add(YemekAdiEktextBox2);
            panel5.Controls.Add(KalorimikektextBox3);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label16);
            panel5.Location = new Point(57, 516);
            panel5.Name = "panel5";
            panel5.Size = new Size(698, 139);
            panel5.TabIndex = 20;
            // 
            // katagorilistcomboBox2
            // 
            katagorilistcomboBox2.FormattingEnabled = true;
            katagorilistcomboBox2.Location = new Point(114, 68);
            katagorilistcomboBox2.Name = "katagorilistcomboBox2";
            katagorilistcomboBox2.Size = new Size(125, 28);
            katagorilistcomboBox2.TabIndex = 21;
            // 
            // button5
            // 
            button5.Location = new Point(317, 19);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 21;
            button5.Text = "Ekle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // YemekAdiEktextBox2
            // 
            YemekAdiEktextBox2.Location = new Point(114, 6);
            YemekAdiEktextBox2.Name = "YemekAdiEktextBox2";
            YemekAdiEktextBox2.Size = new Size(125, 27);
            YemekAdiEktextBox2.TabIndex = 22;
            // 
            // KalorimikektextBox3
            // 
            KalorimikektextBox3.Location = new Point(124, 39);
            KalorimikektextBox3.Name = "KalorimikektextBox3";
            KalorimikektextBox3.Size = new Size(125, 27);
            KalorimikektextBox3.TabIndex = 23;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(17, 88);
            label19.Name = "label19";
            label19.Size = new Size(52, 20);
            label19.TabIndex = 32;
            label19.Text = "Resim:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(17, 68);
            label18.Name = "label18";
            label18.Size = new Size(69, 20);
            label18.TabIndex = 31;
            label18.Text = "Kategori:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(17, 39);
            label17.Name = "label17";
            label17.Size = new Size(51, 20);
            label17.TabIndex = 30;
            label17.Text = "Kalori:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 19);
            label16.Name = "label16";
            label16.Size = new Size(82, 20);
            label16.TabIndex = 29;
            label16.Text = "Yemek Adı:";
            // 
            // GirişEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 866);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button1;
        private TextBox KullaniciAdiTextBox;
        private TextBox SifreTextBox;
        private Label label1;
        private Label label2;
        private Button button2;
        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private GroupBox groupBox2;
        private Button button3;
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
        private Button button10;
        private Button button9;
        private Panel panel4;
        private Label RaporLbl;
        private Button button8;
        private Button button12;
        private Button button7;
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
        private ComboBox comboBox1;
        private Button button4;
        private Label label20;
        private Label label21;
        private Button button5;
        private ComboBox katagorilistcomboBox2;
    }
}