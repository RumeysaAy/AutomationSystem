namespace Otomasyon_Sistemi
{
    partial class FrmBankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankalar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.CmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtHesapTuru = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtYetkili = new System.Windows.Forms.MaskedTextBox();
            this.TxtHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSube = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBankaAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtIBAN = new System.Windows.Forms.MaskedTextBox();
            this.Txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHesapTuru.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBankaAd.Properties)).BeginInit();
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
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(618, 508);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // CmbIlce
            // 
            this.CmbIlce.Location = new System.Drawing.Point(83, 108);
            this.CmbIlce.Name = "CmbIlce";
            this.CmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbIlce.Size = new System.Drawing.Size(146, 20);
            this.CmbIlce.TabIndex = 3;
            // 
            // Cmbil
            // 
            this.Cmbil.Location = new System.Drawing.Point(83, 82);
            this.Cmbil.Name = "Cmbil";
            this.Cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmbil.Size = new System.Drawing.Size(146, 20);
            this.Cmbil.TabIndex = 2;
            this.Cmbil.SelectedIndexChanged += new System.EventHandler(this.Cmbil_SelectedIndexChanged);
            // 
            // MskTarih
            // 
            this.MskTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MskTarih.Location = new System.Drawing.Point(83, 268);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(146, 21);
            this.MskTarih.TabIndex = 9;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // MskTel
            // 
            this.MskTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MskTel.Location = new System.Drawing.Point(83, 239);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(146, 21);
            this.MskTel.TabIndex = 8;
            // 
            // TxtHesapTuru
            // 
            this.TxtHesapTuru.Location = new System.Drawing.Point(83, 294);
            this.TxtHesapTuru.Name = "TxtHesapTuru";
            this.TxtHesapTuru.Size = new System.Drawing.Size(146, 20);
            this.TxtHesapTuru.TabIndex = 10;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(48, 327);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(30, 13);
            this.labelControl11.TabIndex = 44;
            this.labelControl11.Text = "Firma:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(21, 301);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(59, 13);
            this.labelControl10.TabIndex = 43;
            this.labelControl10.Text = "Hesap Türü:";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(83, 413);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(144, 23);
            this.BtnGuncelle.TabIndex = 41;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(83, 384);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(144, 23);
            this.BtnSil.TabIndex = 40;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(83, 355);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(144, 23);
            this.BtnKaydet.TabIndex = 39;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lookUpEdit1);
            this.xtraTabPage1.Controls.Add(this.BtnTemizle);
            this.xtraTabPage1.Controls.Add(this.TxtYetkili);
            this.xtraTabPage1.Controls.Add(this.TxtHesapNo);
            this.xtraTabPage1.Controls.Add(this.labelControl12);
            this.xtraTabPage1.Controls.Add(this.TxtSube);
            this.xtraTabPage1.Controls.Add(this.CmbIlce);
            this.xtraTabPage1.Controls.Add(this.Cmbil);
            this.xtraTabPage1.Controls.Add(this.MskTarih);
            this.xtraTabPage1.Controls.Add(this.MskTel);
            this.xtraTabPage1.Controls.Add(this.TxtHesapTuru);
            this.xtraTabPage1.Controls.Add(this.labelControl11);
            this.xtraTabPage1.Controls.Add(this.labelControl10);
            this.xtraTabPage1.Controls.Add(this.BtnGuncelle);
            this.xtraTabPage1.Controls.Add(this.BtnSil);
            this.xtraTabPage1.Controls.Add(this.BtnKaydet);
            this.xtraTabPage1.Controls.Add(this.labelControl9);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.TxtBankaAd);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.TxtIBAN);
            this.xtraTabPage1.Controls.Add(this.Txtid);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(239, 483);
            this.xtraTabPage1.Text = "Bankalar";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(83, 320);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "Bir Firma Seçin";
            this.lookUpEdit1.Size = new System.Drawing.Size(146, 20);
            this.lookUpEdit1.TabIndex = 11;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(83, 442);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(144, 23);
            this.BtnTemizle.TabIndex = 55;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtYetkili.Location = new System.Drawing.Point(83, 213);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Size = new System.Drawing.Size(146, 21);
            this.TxtYetkili.TabIndex = 7;
            // 
            // TxtHesapNo
            // 
            this.TxtHesapNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtHesapNo.Location = new System.Drawing.Point(83, 186);
            this.TxtHesapNo.Name = "TxtHesapNo";
            this.TxtHesapNo.Size = new System.Drawing.Size(146, 21);
            this.TxtHesapNo.TabIndex = 6;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(39, 247);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(40, 13);
            this.labelControl12.TabIndex = 52;
            this.labelControl12.Text = "Telefon:";
            // 
            // TxtSube
            // 
            this.TxtSube.Location = new System.Drawing.Point(83, 134);
            this.TxtSube.Name = "TxtSube";
            this.TxtSube.Size = new System.Drawing.Size(146, 20);
            this.TxtSube.TabIndex = 4;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(52, 275);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 13);
            this.labelControl9.TabIndex = 37;
            this.labelControl9.Text = "Tarih:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(48, 220);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(31, 13);
            this.labelControl8.TabIndex = 35;
            this.labelControl8.Text = "Yetkili:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(29, 194);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "Hesap No:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(51, 169);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "IBAN:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(57, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(21, 13);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "İlçe:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(68, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(10, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "İl:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(50, 143);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Şube:";
            // 
            // TxtBankaAd
            // 
            this.TxtBankaAd.Location = new System.Drawing.Point(83, 55);
            this.TxtBankaAd.Name = "TxtBankaAd";
            this.TxtBankaAd.Size = new System.Drawing.Size(146, 20);
            this.TxtBankaAd.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Banka Adı:";
            // 
            // TxtIBAN
            // 
            this.TxtIBAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtIBAN.Location = new System.Drawing.Point(83, 160);
            this.TxtIBAN.Name = "TxtIBAN";
            this.TxtIBAN.Size = new System.Drawing.Size(146, 21);
            this.TxtIBAN.TabIndex = 5;
            // 
            // Txtid
            // 
            this.Txtid.EditValue = "";
            this.Txtid.Location = new System.Drawing.Point(83, 29);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(146, 20);
            this.Txtid.TabIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(63, 36);
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
            this.splitContainer1.Size = new System.Drawing.Size(863, 508);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(241, 508);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // FrmBankalar
            // 
            this.AcceptButton = this.BtnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(863, 508);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmBankalar";
            this.Text = "BANKALAR";
            this.Load += new System.EventHandler(this.FrmBankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHesapTuru.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBankaAd.Properties)).EndInit();
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
        private DevExpress.XtraEditors.ComboBoxEdit CmbIlce;
        private DevExpress.XtraEditors.ComboBoxEdit Cmbil;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private DevExpress.XtraEditors.TextEdit TxtHesapTuru;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtBankaAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox TxtIBAN;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit TxtSube;
        private System.Windows.Forms.MaskedTextBox TxtHesapNo;
        private System.Windows.Forms.MaskedTextBox TxtYetkili;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}