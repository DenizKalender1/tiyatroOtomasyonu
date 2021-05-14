namespace Tiyatro_Otomasyonu
{
    partial class RibbonFrm_Personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonFrm_Personel));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem_OyunEk = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_OyunSil = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_SeansEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_SeansG = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_SalonEK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_SeansIslemleri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_SalonIslemleri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_SalonEKle = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.Gray;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem_OyunEk,
            this.barButtonItem_OyunSil,
            this.barButtonItem_SeansEkle,
            this.barButtonItem_SeansG,
            this.barButtonItem_SalonEK,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage_SeansIslemleri,
            this.ribbonPage_SalonIslemleri,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(760, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem_OyunEk
            // 
            this.barButtonItem_OyunEk.Caption = "Oyun Ekleme";
            this.barButtonItem_OyunEk.Id = 2;
            this.barButtonItem_OyunEk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_OyunEk.ImageOptions.Image")));
            this.barButtonItem_OyunEk.Name = "barButtonItem_OyunEk";
            this.barButtonItem_OyunEk.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem_OyunEk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_OyunEk_ItemClick);
            // 
            // barButtonItem_OyunSil
            // 
            this.barButtonItem_OyunSil.Caption = "Oyun Silme";
            this.barButtonItem_OyunSil.Id = 3;
            this.barButtonItem_OyunSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_OyunSil.ImageOptions.Image")));
            this.barButtonItem_OyunSil.Name = "barButtonItem_OyunSil";
            this.barButtonItem_OyunSil.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem_SeansEkle
            // 
            this.barButtonItem_SeansEkle.Caption = "Gösterim Ekle";
            this.barButtonItem_SeansEkle.Id = 4;
            this.barButtonItem_SeansEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_SeansEkle.ImageOptions.Image")));
            this.barButtonItem_SeansEkle.Name = "barButtonItem_SeansEkle";
            this.barButtonItem_SeansEkle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem_SeansEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_SeansEkle_ItemClick);
            // 
            // barButtonItem_SeansG
            // 
            this.barButtonItem_SeansG.Caption = "Gösterimleri Görüntüle";
            this.barButtonItem_SeansG.Id = 5;
            this.barButtonItem_SeansG.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_SeansG.ImageOptions.Image")));
            this.barButtonItem_SeansG.Name = "barButtonItem_SeansG";
            this.barButtonItem_SeansG.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem_SeansG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_SeansG_ItemClick);
            // 
            // barButtonItem_SalonEK
            // 
            this.barButtonItem_SalonEK.Caption = "Salon Ekle";
            this.barButtonItem_SalonEK.Id = 6;
            this.barButtonItem_SalonEK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem_SalonEK.ImageOptions.Image")));
            this.barButtonItem_SalonEK.Name = "barButtonItem_SalonEK";
            this.barButtonItem_SalonEK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem_SalonEK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem_SalonEK_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Ücretler";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Oyun İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem_OyunEk);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage_SeansIslemleri
            // 
            this.ribbonPage_SeansIslemleri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage_SeansIslemleri.Name = "ribbonPage_SeansIslemleri";
            this.ribbonPage_SeansIslemleri.Text = "Gösterim İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem_SeansEkle);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem_SeansG);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage_SalonIslemleri
            // 
            this.ribbonPage_SalonIslemleri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_SalonEKle});
            this.ribbonPage_SalonIslemleri.Name = "ribbonPage_SalonIslemleri";
            this.ribbonPage_SalonIslemleri.Text = "Salon Ekleme";
            // 
            // ribbonPageGroup_SalonEKle
            // 
            this.ribbonPageGroup_SalonEKle.ItemLinks.Add(this.barButtonItem_SalonEK);
            this.ribbonPageGroup_SalonEKle.Name = "ribbonPageGroup_SalonEKle";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Ücret İşlemleri";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(760, 31);
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.Location = new System.Drawing.Point(0, 149);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(760, 513);
            this.panelControl1.TabIndex = 3;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // RibbonFrm_Personel
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 699);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "RibbonFrm_Personel";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "            Personel İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_OyunEk;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_OyunSil;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_SeansIslemleri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SeansEkle;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SeansG;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SalonEK;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_SalonIslemleri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_SalonEKle;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}