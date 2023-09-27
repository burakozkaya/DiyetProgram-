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
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel1.Location = new Point(157, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 438);
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
            groupBox1.Location = new Point(41, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(1009, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 438);
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
            // GirişEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 866);
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
    }
}