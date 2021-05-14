namespace Tiyatro_Otomasyonu
{
    partial class XtraFrm_GosterimList
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
            this.dateTimePicker_List = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.simpleButn_TumGstr = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_List
            // 
            this.dateTimePicker_List.Location = new System.Drawing.Point(284, 58);
            this.dateTimePicker_List.Name = "dateTimePicker_List";
            this.dateTimePicker_List.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_List.TabIndex = 0;
            this.dateTimePicker_List.ValueChanged += new System.EventHandler(this.dateTimePicker_List_ValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(385, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tarihe Göre Sıralama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 218);
            this.dataGridView1.TabIndex = 2;
            // 
            // simpleButn_TumGstr
            // 
            this.simpleButn_TumGstr.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButn_TumGstr.Appearance.ForeColor = System.Drawing.Color.MediumBlue;
            this.simpleButn_TumGstr.Appearance.Options.UseFont = true;
            this.simpleButn_TumGstr.Appearance.Options.UseForeColor = true;
            this.simpleButn_TumGstr.Location = new System.Drawing.Point(319, 365);
            this.simpleButn_TumGstr.Name = "simpleButn_TumGstr";
            this.simpleButn_TumGstr.Size = new System.Drawing.Size(154, 27);
            this.simpleButn_TumGstr.TabIndex = 3;
            this.simpleButn_TumGstr.Text = "Tüm Gösterimler";
            this.simpleButn_TumGstr.Click += new System.EventHandler(this.simpleButn_TumGstr_Click);
            // 
            // XtraFrm_GosterimList
            // 
            this.Appearance.BackColor = System.Drawing.Color.RosyBrown;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 466);
            this.Controls.Add(this.simpleButn_TumGstr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dateTimePicker_List);
            this.Name = "XtraFrm_GosterimList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XtraFrm_GosterimList";
            this.Load += new System.EventHandler(this.XtraFrm_GosterimList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_List;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButn_TumGstr;
    }
}