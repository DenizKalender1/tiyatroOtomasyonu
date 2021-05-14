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
    public partial class XtraFrm_FİlmEkle : DevExpress.XtraEditors.XtraForm
    {
        public XtraFrm_FİlmEkle()
        {
            InitializeComponent();
        }
        tiyatroTableAdapters.Oyun_BİlgileriTableAdapter oyun = new tiyatroTableAdapters.Oyun_BİlgileriTableAdapter();

        private void simpleBtnAfisEk_Click(object sender, EventArgs e)
        {
            xtraOpenFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = xtraOpenFileDialog1.FileName;
        }

        private void simpleBtn_OyunEk_Click(object sender, EventArgs e)
        {
            try
            {
oyun.OyunEkleme(txtEdit_oyunEkle.Text, dateTimePicker1.Text, pictureBox1.ImageLocation);
                MessageBox.Show("Oyun Eklendi!", "Kayıt");
            }
            catch (Exception)
            {
                MessageBox.Show("Bu oyun daha önce eklenmiş!", "Uyarı");
            }
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            txtEdit_oyunEkle.Text = "";
        }

       
       
    }
}