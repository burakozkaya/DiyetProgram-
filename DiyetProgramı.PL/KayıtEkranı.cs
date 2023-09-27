using DiyetProgramı.BLL.Concrete;
using DiyetProgramı.DAL.Concrete;
using DiyetProgramı.Entities.Concrete;
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
    public partial class KayıtEkranı : Form
    {
        public KayıtEkranı()
        {
            InitializeComponent();
        }

        private void KayıtEkranı_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kullaniciMail = kullaniciMailTextBox.Text;
            KullaniciManager kullanici = new KullaniciManager(new KullaniciRepo(1));

            var termpString=string.Empty;
            if (!kullanici.ValidUser(kullaniciMail)|| !kullanici.ValidMail(kullaniciMail))
            {
                termpString += "Kullanıcı mail hatalı";
            }
        






            string kullaniciSifre = kullaniciSifreTextBox.Text;
            string kullaniciSifreTekrari = kullaniciSifreTekrariTextBox.Text;
            string isim = isimTextBox.Text;
            string soyisim = soyisimTextBox.Text;
            int yas = Convert.ToInt32(yasTextBox.Text);
            double boy = Convert.ToInt32(boyTextBox.Text);
            decimal kilo = Convert.ToDecimal(kiloTextBox.Text);

           

        }
    }
}
