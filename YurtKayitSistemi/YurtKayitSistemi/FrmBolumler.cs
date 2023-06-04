using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M560FVM\\SQLEXPRESS;Initial Catalog=YurtKayit;Integrated Security=True");
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try { 
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", baglanti);
            komut1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
                MessageBox.Show("Bölüm eklendi.");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            }
        catch{
                MessageBox.Show("HATA!");
        
        }
        }

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);

        }

        private void PcbBolumSil_Click(object sender, EventArgs e)
        { try
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", TxtBolumid.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Tamamlandı.");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
