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

namespace Tiyatro_Otomasyonu
{
    public partial class Frm_SalonEkle : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SalonEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_SalonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            RibbonFrm_Personel anaSayfa = new RibbonFrm_Personel();
            anaSayfa.ShowDialog();
        }

        tiyatroTableAdapters.Salon_BilgiTableAdapter salon = new tiyatroTableAdapters.Salon_BilgiTableAdapter();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                salon.SalonEkleme(textSalonAdi.Text);
                MessageBox.Show("Salon Eklendi", "Kayıt");
            }
            catch (Exception)
            {

                MessageBox.Show("Aynı salon daha önce eklenmiş!", "Uyarı");
            }
            textSalonAdi.Text = "";
        }

        
    }
}