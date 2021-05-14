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
    public partial class XtraFrm_GosterimList : DevExpress.XtraEditors.XtraForm
    {
        public XtraFrm_GosterimList()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-FID83MCL;Initial Catalog=Tiyatro_Bileti;Integrated Security=True");
        DataTable table = new DataTable();
        private void List(string sql)
        {
            connection.Open();
            SqlDataAdapter adp = new SqlDataAdapter(sql,connection);
            adp.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
        private void XtraFrm_GosterimList_Load(object sender, EventArgs e)
        {
            table.Clear();
            List("select *from seans_bilgileri where tarih like '" + dateTimePicker_List.Text + "'");
        }

        private void dateTimePicker_List_ValueChanged(object sender, EventArgs e)
        {
            table.Clear();
            List("select *from seans_bilgileri where tarih like '" + dateTimePicker_List.Text + "'");
        }

        private void simpleButn_TumGstr_Click(object sender, EventArgs e)
        {
            table.Clear();
            List("select *from seans_bilgileri");
        }
    }
}