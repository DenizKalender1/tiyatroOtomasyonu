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
    public partial class XtraFrm_Musterii : DevExpress.XtraEditors.XtraForm
    {
        public XtraFrm_Musterii()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-FID83MCL;Initial Catalog=Tiyatro_Bileti;Integrated Security=True");

        int sayac = 0;

        private void OyunveSalonGetir(System.Windows.Forms.ComboBox combo,string sql1,string sql2)
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

        private void Dolu_Koltuklar_Cb()
        {
            comboBox_KoltukIpt.Items.Clear();
            comboBox_KoltukIpt.Text = "";
            foreach (Control item in panel_KoltukAlani.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor == Color.Red)
                    {
                        comboBox_KoltukIpt.Items.Add(item.Text);

                    }
                }
            }
        }

        private void Renklendir()
        {
            foreach (Control item in panel_KoltukAlani.Controls)
            {
                if(item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }

        private void Dolu_Koltuk_Db()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("select *from satis_bilgileri where tarih like'"+comboBox_OyunSaati.Text +"'",connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach  (Control item in panel_KoltukAlani.Controls)
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

        SqlCommand komut = new SqlCommand();
        private void XtraFrm_Musterii_Load(object sender, EventArgs e)
        {
            Bos_Koltuk();
            OyunveSalonGetir(comboBox_OyunAdi, "select *from oyun_bilgileri", "oyunadi");
            OyunveSalonGetir(comboBox_SalonAdi, "select *from salon_bilgi", "salonadi");
            comboBox_GstrTarihi.Items.Clear();
            SqlDataReader oku;
            connection.Open();
            komut.Connection = connection;
            komut.CommandText = "select *from satis_bilgileri";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox_GstrTarihi.Items.Add(oku[4].ToString());
            }
            connection.Close();

        }

        private void Bos_Koltuk()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(40, 40);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 40 + 30, i * 40 + 40);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel_KoltukAlani.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.White)
            {
                textEdit_KoltukNo.Text = b.Text;

            }
        }
        tiyatroTableAdapters.Satis_BilgileriTableAdapter satis = new tiyatroTableAdapters.Satis_BilgileriTableAdapter();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit_KoltukNo.Text != "")
            {
                try
                {
                    satis.Satin_Al(textEdit_KoltukNo.Text, comboBox_SalonAdi.Text, comboBox_OyunAdi.Text, comboBox_GstrTarihi.Text, comboBox_OyunSaati.Text, textEdit_Isım.Text, textEdit_Soyisim.Text, comboBox_Ucret.Text, comboBox_GstrTarihi.Text);
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata!"+hata.Message, "uyarı");
                } 
            }
            else
            {
                MessageBox.Show("Lütfen koltuk seçimi yapınız!", "uyarı");
            }
        }

        private void comboBox_OyunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Renklendir();
            Dolu_Koltuklar_Cb();
        }

        private void simpleBtn_Doldur_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("select *from satis_bilgileri where Tarih like'"+comboBox_GstrTarihi.Text+"'", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox_OyunSaati.Text = oku["Saat"].ToString();
            }
            connection.Close();
        }
        
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Bos_Koltuk();
            Renklendir();
            Dolu_Koltuk_Db();
            Dolu_Koltuklar_Cb();
        }

        
    }
}