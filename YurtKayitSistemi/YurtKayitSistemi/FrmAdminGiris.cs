using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TxtKullaniciAd.Text=="admin" && TxtSifre.Text == "admin")
            {


                FrmAnaForm frm= new FrmAnaForm();
                frm.Show();
            }
            else
            {
                MessageBox.Show("ŞİFRE VEYA KULLANICI ADI HATALI");
            }
        }
    }
}
