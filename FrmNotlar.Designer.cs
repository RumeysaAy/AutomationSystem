namespace Otomasyon_Sistemi
{
    partial class FrmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RchDetay = new System.Windows.Forms.RichTextBox();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtHitap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBaslik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtOlusturan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.Txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOlusturan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(562, 458);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // MskTarih
            // 
            this.MskTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MskTarih.Location = new System.Drawing.Point(80, 51);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(144, 21);
            this.MskTarih.TabIndex = 46;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(80, 368);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(144, 23);
            this.BtnGuncelle.TabIndex = 41;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(80, 339);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(144, 23);
            this.BtnSil.TabIndex = 40;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(80, 310);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(144, 23);
            this.BtnKaydet.TabIndex = 39;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RchDetay
            // 
            this.RchDetay.Location = new System.Drawing.Point(81, 183);
            this.RchDetay.Name = "RchDetay";
            this.RchDetay.Size = new System.Drawing.Size(144, 103);
            this.RchDetay.TabIndex = 38;
            this.RchDetay.Text = "";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.BtnTemizle);
            this.xtraTabPage1.Controls.Add(this.MskTarih);
            this.xtraTabPage1.Controls.Add(this.BtnGuncelle);
            this.xtraTabPage1.Controls.Add(this.BtnSil);
            this.xtraTabPage1.Controls.Add(this.BtnKaydet);
            this.xtraTabPage1.Controls.Add(this.RchDetay);
            this.xtraTabPage1.Controls.Add(this.TxtHitap);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.TxtBaslik);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.TxtOlusturan);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.MskSaat);
            this.xtraTabPage1.Controls.Add(this.Txtid);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(279, 433);
            this.xtraTabPage1.Text = "Notlar";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(80, 397);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(144, 23);
            this.BtnTemizle.TabIndex = 51;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // TxtHitap
            // 
            this.TxtHitap.Location = new System.Drawing.Point(80, 157);
            this.TxtHitap.Name = "TxtHitap";
            this.TxtHitap.Size = new System.Drawing.Size(144, 20);
            this.TxtHitap.TabIndex = 34;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(46, 164);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "Hitap:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 138);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "Oluşturan:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(42, 183);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Detay:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(45, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Başlık:";
            // 
            // TxtBaslik
            // 
            this.TxtBaslik.Location = new System.Drawing.Point(80, 104);
            this.TxtBaslik.Name = "TxtBaslik";
            this.TxtBaslik.Size = new System.Drawing.Size(144, 20);
            this.TxtBaslik.TabIndex = 27;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(49, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Saat:";
            // 
            // TxtOlusturan
            // 
            this.TxtOlusturan.Location = new System.Drawing.Point(80, 131);
            this.TxtOlusturan.Name = "TxtOlusturan";
            this.TxtOlusturan.Size = new System.Drawing.Size(144, 20);
            this.TxtOlusturan.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(47, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Tarih:";
            // 
            // MskSaat
            // 
            this.MskSaat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MskSaat.Location = new System.Drawing.Point(80, 77);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(144, 21);
            this.MskSaat.TabIndex = 23;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // Txtid
            // 
            this.Txtid.EditValue = "";
            this.Txtid.Location = new System.Drawing.Point(80, 26);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(144, 20);
            this.Txtid.TabIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(60, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "ID:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.xtraTabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(847, 458);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(281, 458);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(847, 458);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmNotlar";
            this.Text = "NOTLAR";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOlusturan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RchDetay;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit TxtHitap;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtOlusturan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
    }
}