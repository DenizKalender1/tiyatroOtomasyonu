using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;

namespace Tiyatro_Otomasyonu
{
    public partial class RibbonFrm_Personel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonFrm_Personel()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-FID83MCL;Initial Catalog=Tiyatro_Bileti;Integrated Security=True");



        private void BarButtonItem_SalonEK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_SalonEkle ekle = new Frm_SalonEkle();
            ekle.Show();
           
            
        }

        private void barButtonItem_OyunEk_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFrm_FİlmEkle ekleme = new XtraFrm_FİlmEkle();
            ekleme.Show();
            
        }

        private void barButtonItem_SeansEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFrm_GosterimEkleme gstrmEkle = new XtraFrm_GosterimEkleme();
            gstrmEkle.Show();
           
        }

        private void barButtonItem_SeansG_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFrm_GosterimList listele = new XtraFrm_GosterimList();
            listele.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFrm_UcretListele ucret = new XtraFrm_UcretListele();
            ucret.Show();
        }
    }
}