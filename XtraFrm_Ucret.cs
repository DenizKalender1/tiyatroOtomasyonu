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
    public partial class XtraFrm_Ucret : DevExpress.XtraEditors.XtraForm
    {
        public XtraFrm_Ucret()
        {
            InitializeComponent();
        }
        //tiyatroTableAdapters.Satis_BilgileriTableAdapter satislistesi = new tiyatroTableAdapters.Satis_BilgileriTableAdapter();


        private void XtraFrm_Ucret_Load(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = satislistesi.TariheGoreListele2(dateTimePicker1.Text);
            ToplamUcretHsp();
        }

        private void ToplamUcretHsp()
        {
            
            int toplam=0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells["Ucret"].Value);
            }
            label1.Text = "Toplam Ücret=" + toplam + "TL";
        }

        private void simpleBtn_Listele_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = satislistesi.SatısListesi2();
            ToplamUcretHsp();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = satislistesi.TariheGoreListele2(dateTimePicker1.Text);
            ToplamUcretHsp();
        }
    }
}