namespace Tiyatro_Otomasyonu
{
    partial class XtraFrm_FİlmEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFrm_FİlmEkle));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdit_oyunEkle = new DevExpress.XtraEditors.TextEdit();
            this.simpleBtn_OyunEk = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleBtn_AfisEk = new DevExpress.XtraEditors.SimpleButton();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_oyunEkle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 112);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Oyun Adı:";
            // 
            // txtEdit_oyunEkle
            // 
            this.txtEdit_oyunEkle.Location = new System.Drawing.Point(103, 106);
            this.txtEdit_oyunEkle.Name = "txtEdit_oyunEkle";
            this.txtEdit_oyunEkle.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdit_oyunEkle.Properties.Appearance.Options.UseFont = true;
            this.txtEdit_oyunEkle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtEdit_oyunEkle.Size = new System.Drawing.Size(228, 24);
            this.txtEdit_oyunEkle.TabIndex = 2;
            // 
            // simpleBtn_OyunEk
            // 
            this.simpleBtn_OyunEk.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleBtn_OyunEk.Appearance.Options.UseFont = true;
            this.simpleBtn_OyunEk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleBtn_OyunEk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleBtn_OyunEk.ImageOptions.Image")));
            this.simpleBtn_OyunEk.Location = new System.Drawing.Point(150, 240);
            this.simpleBtn_OyunEk.Name = "simpleBtn_OyunEk";
            this.simpleBtn_OyunEk.Size = new System.Drawing.Size(149, 43);
            this.simpleBtn_OyunEk.TabIndex = 3;
            this.simpleBtn_OyunEk.Text = "Oyun Ekle";
            this.simpleBtn_OyunEk.Click += new System.EventHandler(this.simpleBtn_OyunEk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(405, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 143);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // simpleBtn_AfisEk
            // 
            this.simpleBtn_AfisEk.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleBtn_AfisEk.Appearance.Options.UseFont = true;
            this.simpleBtn_AfisEk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleBtn_AfisEk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleBtn_AfisEk.ImageOptions.Image")));
            this.simpleBtn_AfisEk.Location = new System.Drawing.Point(394, 240);
            this.simpleBtn_AfisEk.Name = "simpleBtn_AfisEk";
            this.simpleBtn_AfisEk.Size = new System.Drawing.Size(166, 43);
            this.simpleBtn_AfisEk.TabIndex = 5;
            this.simpleBtn_AfisEk.Text = "Afiş Seç";
            this.simpleBtn_AfisEk.Click += new System.EventHandler(this.simpleBtnAfisEk_Click);
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(40, 156);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 18);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 21);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // XtraFrm_FİlmEkle
            // 
            this.Appearance.BackColor = System.Drawing.Color.RosyBrown;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 363);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleBtn_AfisEk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleBtn_OyunEk);
            this.Controls.Add(this.txtEdit_oyunEkle);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "XtraFrm_FİlmEkle";
            this.Text = "Film Ekleme Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_oyunEkle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEdit_oyunEkle;
        private DevExpress.XtraEditors.SimpleButton simpleBtn_OyunEk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton simpleBtn_AfisEk;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}