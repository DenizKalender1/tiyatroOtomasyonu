namespace Tiyatro_Otomasyonu
{
    partial class XtraFrm_GosterimEkleme
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox_Seans = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.simpleBtn_GstrmEkle = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox_Oyun = new System.Windows.Forms.ComboBox();
            this.comboBox_Salon = new System.Windows.Forms.ComboBox();
            this.groupBox_Seans.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(65, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Oyun:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(65, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Salon:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(41, 201);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Gösterim:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(68, 152);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 18);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 21);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox_Seans
            // 
            this.groupBox_Seans.BackColor = System.Drawing.Color.Silver;
            this.groupBox_Seans.Controls.Add(this.radioButton3);
            this.groupBox_Seans.Controls.Add(this.radioButton2);
            this.groupBox_Seans.Controls.Add(this.radioButton1);
            this.groupBox_Seans.Location = new System.Drawing.Point(136, 201);
            this.groupBox_Seans.Name = "groupBox_Seans";
            this.groupBox_Seans.Size = new System.Drawing.Size(203, 116);
            this.groupBox_Seans.TabIndex = 7;
            this.groupBox_Seans.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.Location = new System.Drawing.Point(105, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(78, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "15:00:00";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(6, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "18:30:00";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(6, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "12:00:00";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // simpleBtn_GstrmEkle
            // 
            this.simpleBtn_GstrmEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleBtn_GstrmEkle.Appearance.Options.UseFont = true;
            this.simpleBtn_GstrmEkle.Location = new System.Drawing.Point(136, 342);
            this.simpleBtn_GstrmEkle.Name = "simpleBtn_GstrmEkle";
            this.simpleBtn_GstrmEkle.Size = new System.Drawing.Size(203, 35);
            this.simpleBtn_GstrmEkle.TabIndex = 8;
            this.simpleBtn_GstrmEkle.Text = "Ekle";
            this.simpleBtn_GstrmEkle.Click += new System.EventHandler(this.simpleBtn_GstrmEkle_Click);
            // 
            // comboBox_Oyun
            // 
            this.comboBox_Oyun.FormattingEnabled = true;
            this.comboBox_Oyun.Location = new System.Drawing.Point(136, 58);
            this.comboBox_Oyun.Name = "comboBox_Oyun";
            this.comboBox_Oyun.Size = new System.Drawing.Size(203, 21);
            this.comboBox_Oyun.TabIndex = 9;
            // 
            // comboBox_Salon
            // 
            this.comboBox_Salon.FormattingEnabled = true;
            this.comboBox_Salon.Location = new System.Drawing.Point(136, 103);
            this.comboBox_Salon.Name = "comboBox_Salon";
            this.comboBox_Salon.Size = new System.Drawing.Size(203, 21);
            this.comboBox_Salon.TabIndex = 10;
            this.comboBox_Salon.SelectedIndexChanged += new System.EventHandler(this.comboBox_Salon_SelectedIndexChanged);
            // 
            // XtraFrm_GosterimEkleme
            // 
            this.Appearance.BackColor = System.Drawing.Color.RosyBrown;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 449);
            this.Controls.Add(this.comboBox_Salon);
            this.Controls.Add(this.comboBox_Oyun);
            this.Controls.Add(this.simpleBtn_GstrmEkle);
            this.Controls.Add(this.groupBox_Seans);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "XtraFrm_GosterimEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GÖSTERİM EKLEME";
            this.Load += new System.EventHandler(this.XtraFrm_GosterimEkleme_Load);
            this.groupBox_Seans.ResumeLayout(false);
            this.groupBox_Seans.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox_Seans;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevExpress.XtraEditors.SimpleButton simpleBtn_GstrmEkle;
        private System.Windows.Forms.ComboBox comboBox_Oyun;
        private System.Windows.Forms.ComboBox comboBox_Salon;
    }
}