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
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Button btn_tikla = new Button();
            //btn_tikla.Text = "Tıkla";
            //btn_tikla.Location = new Point(10, 10);
            //this.Controls.Add(btn_tikla);
            KullaniciGiris frm = new KullaniciGiris();
            frm.ShowDialog();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Kullanıcı = " + LoggedUser.User;
        }

        private void TSMI_BirinciFormAc_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;
            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(BirinciForm))
                {
                    acikmi = true;
                    item.Activate();
                }
            }
            if (acikmi == false)
            {
                BirinciForm frm = new BirinciForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_IkınciFormAc_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;
            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(IkıncıForm))
                {
                    acikmi = true;
                    item.Activate();
                }
            }
            if (acikmi == false)
            {
                IkıncıForm frm = new IkıncıForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_BagimsizFormAc_Click(object sender, EventArgs e)
        {
            BagimsizForm frm = new BagimsizForm();
            frm.Show();
        }

        private void TSMI_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
