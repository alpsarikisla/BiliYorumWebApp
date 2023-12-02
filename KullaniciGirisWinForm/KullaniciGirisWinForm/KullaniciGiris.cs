using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisWinForm
{
    public partial class KullaniciGiris : Form
    {
        bool girisVar = false;
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_kullaniciAdi.Text) && !string.IsNullOrEmpty(tb_sifre.Text))
            {
                if (tb_kullaniciAdi.Text == "admin" && tb_sifre.Text == "1234")
                {
                    #region Hatalı Yaklaşım

                    //this.Close();
                    //this.Hide();
                    //Form1 frm = new Form1();
                    //frm.ShowDialog();

                    #endregion
                    girisVar = true;
                    this.Close();
                    LoggedUser.User = "Admin abc";
                }
                else
                {
                    MessageBox.Show("Lütfen giriş bilgilerinizi kontrol ediniz", "Kullanıcı Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şİfre boş bırakılamaz", "Boş Veri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (girisVar == false)
            {
                Application.Exit();
            }
        }
    }
}
