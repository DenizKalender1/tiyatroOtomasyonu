using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Tiyatro_Otomasyonu
{
    public partial class Form1_Giris : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-FID83MCL; Initial Catalog=model; Integrated Security=TRUE");
        SqlConnection connection2 = new SqlConnection("Data Source=LAPTOP-FID83MCL; Initial Catalog=master; Integrated Security=TRUE");
        public Form1_Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kullanıcıadı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Kullanıcıadı";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Şifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }
        char? none = null;
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Şifre";
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar = Convert.ToChar(none);
            }
        }
        bool isThere;
        private void simpleButton1_Musteri_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string sifre = textBox2.Text;


            connection.Open();
            SqlCommand command = new SqlCommand("Select * from MusteriTablo", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (ad == reader["kullanıcıadı"].ToString().TrimEnd() && sifre == reader["sifre"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }
            }

            connection.Close();

            if (isThere)
            {
                MessageBox.Show("Sayın Tiyatrosever, Başarıyla Giriş Yaptınız!");
                XtraFrm_Musterii musteri = new XtraFrm_Musterii();
                musteri.Show();
            }

            else
            {
                MessageBox.Show("Sayın Tiyatrosever, Girişiniz Başarısız!");
            }
        }

        private void simpleButton2_Personel_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string sifre = textBox2.Text;


            connection2.Open();
            SqlCommand command2 = new SqlCommand("Select * from Personel", connection2);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                if (ad == reader2["kullanıciadi"].ToString().TrimEnd() && sifre == reader2["pass"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }
            }
            connection2.Close();

            if (isThere)
            {
                MessageBox.Show("Sayın Personelimiz, Başarıyla Giriş Yaptınız!");
                RibbonFrm_Personel prsnl = new RibbonFrm_Personel();
                prsnl.Show();
            }
            else
            {
                MessageBox.Show("Sayın Personelimiz, Girişiniz Başarısız!");
                    
            }
        }
    }
}

                
            