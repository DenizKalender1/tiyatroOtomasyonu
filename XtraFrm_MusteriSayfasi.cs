using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Tiyatro_Otomasyonu
{
    public partial class XtraFrm_MusteriSayfasi : DevExpress.XtraEditors.XtraForm
    {
        public XtraFrm_MusteriSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-FID83MCL;Initial Catalog=Tiyatro_Bileti;Integrated Security=True");
        int sayac = 0;
        private void OyunveSalonGoster(System.Windows.Forms.ComboBox combo,string sql1,string sql2)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand(sql1,connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());
            }
            connection.Close();
        }
        
        private void Combo_Dolu_Goster()
        {
            combo_KoltukIpt.Items.Clear();
            combo_KoltukIpt.Text = "";
            foreach (Control item in panel_Koltuk.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor == Color.Red)
                    {
                        combo_KoltukIpt.Items.Add(item.Text);
                    }
                }
            }
        }
        private void Renklendir()
        {
            foreach (Control item in panel_Koltuk.Controls)
            {
                if(item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }

        private void Database_Dolu_Koltuk()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("select *from satis_bilgileri where oyunadi='"+comboBox_OyunAdi.SelectedItem+"' and salonadi='"+comboBox_SalonAdi.Text+"' and tarih='"+comboBox_OyunTarihi.SelectedItem+"' and saat='"+comboBox_Saat.SelectedItem+"'",connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in panel_Koltuk.Controls)
                {
                    if(item is Button)
                    {
                        if (read["koltukno"].ToString() == item.Text)
                        {
                         item.BackColor = Color.Red;
                        }
                        
                    }
                }
            }
            connection.Close();
        }

        private void XtraFrm_MusteriSayfasi_Load(object sender, EventArgs e)
        {
            koltuklar();
            OyunveSalonGoster(comboBox_OyunAdi, "select *from oyun_bilgileri", "oyunadi");
            OyunveSalonGoster(comboBox_SalonAdi, "select *from salon_bilgi", "salonadi");
        }

        private void koltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button buton = new Button();
                    buton.Size = new Size(40, 40);
                    buton.BackColor = Color.White;
                    buton.Location = new Point(j * 40 + 30, i * 40 + 40);
                    buton.Name = sayac.ToString();
                    buton.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel_Koltuk.Controls.Add(buton);
                    buton.Click += Buton_Click;
                }
            }
        }

        private void Buton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.White)
                {
                textEdit_KoltukNo.Text = b.Text;
                }
        }

        tiyatroTableAdapters.Satis_BilgileriTableAdapter satis = new tiyatroTableAdapters.Satis_BilgileriTableAdapter();

        private void simpleBtn_Satis_Click(object sender, EventArgs e)
        {
            if (textEdit_KoltukNo.Text != "")
            
            {
                try
                {
                    satis.Satis_Yap(textEdit_KoltukNo.Text, comboBox_SalonAdi.Text, comboBox_OyunAdi.Text, comboBox_OyunTarihi.Text, comboBox_Saat.Text, textEdit_Isim.Text, textEdit_SoyAd.Text, comboBox_Fiyat.Text, DateTime.Now.ToString());
                }
                catch (Exception hata)
                {

                    MessageBox.Show("Hata Oluştu!" + hata.Message, "Uyarı");
                } 
            }
            else
            {
               MessageBox.Show("Lütfen Koltuk Seçimi Yapınız!", "Uyarı");
            }
        }

        private void comboBox_OyunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Renklendir();
            Combo_Dolu_Goster();
        }

        private void Oyun_Tarihi_Getir()
        {
            comboBox_OyunTarihi.Text = "";
            comboBox_Saat.Text = "";
            comboBox_OyunTarihi.Items.Clear();
            comboBox_Saat.Items.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("select *from seans_bilgileri where oyunadi='" + comboBox_OyunAdi.SelectedItem + "'and salonadi='" + comboBox_SalonAdi.SelectedItem + "'", connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString())>= DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!comboBox_OyunTarihi.Items.Contains(read["tarih"].ToString()))
                    {
                    comboBox_Saat.Items.Add(read["tarih"].ToString());
                    }
                   
                    
                }
                
            }
            connection.Close();
        }
        private void comboBox_SalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Oyun_Tarihi_Getir();
            connection.Open();
            SqlCommand komut = new SqlCommand("select *from seans_bilgileri where oyunadi='" + comboBox_OyunAdi.SelectedItem + "'and salonadi='" + comboBox_SalonAdi.SelectedItem + "'", connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox_Saat.Items.Add(read["tarih"].ToString());
            }
            connection.Close();
        }
    }
}