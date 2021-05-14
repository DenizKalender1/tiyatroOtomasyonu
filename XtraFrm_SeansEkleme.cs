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
    public partial class XtraFrm_GosterimEkleme : DevExpress.XtraEditors.XtraForm
    {
        public XtraFrm_GosterimEkleme()
        {
            InitializeComponent();
        }

        tiyatroTableAdapters.Seans_BilgileriTableAdapter oyungstr = new tiyatroTableAdapters.Seans_BilgileriTableAdapter();
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-FID83MCL;Initial Catalog=Tiyatro_Bileti;Integrated Security=True");
        private void XtraFrm_GosterimEkleme_Load(object sender, EventArgs e)
        {

            OyunSlnGoster(comboBox_Oyun, "select *from oyun_bilgileri", "oyunadi");
            OyunSlnGoster(comboBox_Salon, "select *from salon_bilgi", "salonadi");

        }
        
           
        private void OyunSlnGoster(System.Windows.Forms.ComboBox combo,string sql,string sql2)
        { 
            connection.Open();
            SqlCommand komut = new SqlCommand(sql, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                combo.Items.Add(read[sql2].ToString());
            }
            connection.Close();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach(Control item3 in groupBox_Seans.Controls)
            {
                item3.Enabled = true;
            }
            DateTime today = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePicker1.Text);
            if (yeni == today)
            {
                foreach (Control item in groupBox_Seans.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
                Date_Karsılastir();
            }
            else if (yeni > today)
            {
                Date_Karsılastir();
            }
            else if (yeni < today)
            {
                MessageBox.Show("İşleminiz Geçersiz!", "Uyarı");
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            }

        }

        private void Date_Karsılastir()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("select *from seans_bilgileri where salonadi='"+comboBox_Salon.Text+"' and tarih='"+dateTimePicker1.Text+"'", connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                foreach (Control item2 in groupBox_Seans.Controls)
                {
                    if (read["gstrm"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
                }

            }
            connection.Close();
        }

        string gstrm = "";
        private void RadioButonSec()
        {
            if (radioButton1.Checked == true) gstrm = radioButton1.Text;
           else if (radioButton2.Checked == true) gstrm = radioButton2.Text;
            else if (radioButton3.Checked == true) gstrm = radioButton3.Text;

        }
        private void simpleBtn_GstrmEkle_Click(object sender, EventArgs e)
        {
            RadioButonSec();

            if (gstrm !="")
            {
                
                oyungstr.SeansEkleme(comboBox_Oyun.Text, comboBox_Salon.Text, dateTimePicker1.Text, gstrm);
                MessageBox.Show("Gösterim Saati Ekleme İşi Başarılı!", "Kayıt");
            }
            else if (gstrm =="")
            {
                MessageBox.Show("Lütfen Bir İşlem Yapınız!", "Uyarı");
            }
            comboBox_Oyun.Text = "";
            comboBox_Salon.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        private void comboBox_Salon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }
        
    }
}