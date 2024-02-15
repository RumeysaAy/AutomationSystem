namespace Otomasyon_Sistemi
{
    partial class FrmFirmalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirmalar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.MskYTC = new System.Windows.Forms.MaskedTextBox();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.MskFax = new System.Windows.Forms.MaskedTextBox();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.MskTel3 = new System.Windows.Forms.MaskedTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.MskTel1 = new System.Windows.Forms.MaskedTextBox();
            this.TxtYGorev = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtYetkili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSektor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.MskTel2 = new System.Windows.Forms.MaskedTextBox();
            this.Txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.CmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtVergiD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYGorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSektor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiD.Properties)).BeginInit();
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
            this.gridControl1.Size = new System.Drawing.Size(580, 462);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // MskYTC
            // 
            this.MskYTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MskYTC.Location = new System.Drawing.Point(98, 193);
            this.MskYTC.Mask = "00000000000";
            this.MskYTC.Name = "MskYTC";
            this.MskYTC.Size = new System.Drawing.Size(144, 21);
            this.MskYTC.TabIndex = 5;
            this.MskYTC.ValidatingType = typeof(int);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.MskFax);
            this.xtraTabPage1.Controls.Add(this.labelControl13);
            this.xtraTabPage1.Controls.Add(this.labelControl10);
            this.xtraTabPage1.Controls.Add(this.MskTel3);
            this.xtraTabPage1.Controls.Add(this.labelControl9);
            this.xtraTabPage1.Controls.Add(this.MskTel1);
            this.xtraTabPage1.Controls.Add(this.TxtYGorev);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.TxtYetkili);
            this.xtraTabPage1.Controls.Add(this.labelControl12);
            this.xtraTabPage1.Controls.Add(this.MskYTC);
            this.xtraTabPage1.Controls.Add(this.TxtMail);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.TxtSektor);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.TxtAd);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.MskTel2);
            this.xtraTabPage1.Controls.Add(this.Txtid);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(289, 437);
            this.xtraTabPage1.Text = "Firma Bilgileri";
            // 
            // MskFax
            // 
            this.MskFax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MskFax.Location = new System.Drawing.Point(98, 334);
            this.MskFax.Mask = "(999) 000-0000";
            this.MskFax.Name = "MskFax";
            this.MskFax.Size = new System.Drawing.Size(144, 21);
            this.MskFax.TabIndex = 9;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(74, 342);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(22, 13);
            this.labelControl13.TabIndex = 58;
            this.labelControl13.Text = "Fax:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(47, 315);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 13);
            this.labelControl10.TabIndex = 57;
            this.labelControl10.Text = "Telefon 3:";
            // 
            // MskTel3
            // 
            this.MskTel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MskTel3.Location = new System.Drawing.Point(98, 307);
            this.MskTel3.Mask = "(999) 000-0000";
            this.MskTel3.Name = "MskTel3";
            this.MskTel3.Size = new System.Drawing.Size(144, 21);
            this.MskTel3.TabIndex = 8;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(47, 261);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 13);
            this.labelControl9.TabIndex = 55;
            this.labelControl9.Text = "Telefon 1:";
            // 
            // MskTel1
            // 
            this.MskTel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MskTel1.Location = new System.Drawing.Point(98, 253);
            this.MskTel1.Mask = "(999) 000-0000";
            this.MskTel1.Name = "MskTel1";
            this.MskTel1.Size = new System.Drawing.Size(144, 21);
            this.MskTel1.TabIndex = 6;
            // 
            // TxtYGorev
            // 
            this.TxtYGorev.EditValue = "";
            this.TxtYGorev.Location = new System.Drawing.Point(98, 167);
            this.TxtYGorev.Name = "TxtYGorev";
            this.TxtYGorev.Size = new System.Drawing.Size(144, 20);
            this.TxtYGorev.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 174);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 13);
            this.labelControl4.TabIndex = 52;
            this.labelControl4.Text = "Yetkilinin Görevi:";
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.EditValue = "";
            this.TxtYetkili.Location = new System.Drawing.Point(98, 141);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Size = new System.Drawing.Size(144, 20);
            this.TxtYetkili.TabIndex = 3;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(65, 148);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(31, 13);
            this.labelControl12.TabIndex = 50;
            this.labelControl12.Text = "Yetkili:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(98, 361);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(144, 20);
            this.TxtMail.TabIndex = 10;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(74, 368);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(22, 13);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "Mail:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(76, 201);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(17, 13);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "TC:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(47, 288);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Telefon 2:";
            // 
            // TxtSektor
            // 
            this.TxtSektor.Location = new System.Drawing.Point(98, 77);
            this.TxtSektor.Name = "TxtSektor";
            this.TxtSektor.Size = new System.Drawing.Size(144, 20);
            this.TxtSektor.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(61, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Sektör:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(98, 51);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(144, 20);
            this.TxtAd.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(76, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Ad:";
            // 
            // MskTel2
            // 
            this.MskTel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MskTel2.Location = new System.Drawing.Point(98, 280);
            this.MskTel2.Mask = "(999) 000-0000";
            this.MskTel2.Name = "MskTel2";
            this.MskTel2.Size = new System.Drawing.Size(144, 21);
            this.MskTel2.TabIndex = 7;
            // 
            // Txtid
            // 
            this.Txtid.EditValue = "";
            this.Txtid.Location = new System.Drawing.Point(98, 25);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(144, 20);
            this.Txtid.TabIndex = 30;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(78, 32);
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
            this.splitContainer1.Size = new System.Drawing.Size(875, 462);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(291, 462);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.BtnTemizle);
            this.xtraTabPage2.Controls.Add(this.CmbIlce);
            this.xtraTabPage2.Controls.Add(this.Cmbil);
            this.xtraTabPage2.Controls.Add(this.labelControl8);
            this.xtraTabPage2.Controls.Add(this.labelControl14);
            this.xtraTabPage2.Controls.Add(this.BtnGuncelle);
            this.xtraTabPage2.Controls.Add(this.BtnSil);
            this.xtraTabPage2.Controls.Add(this.BtnKaydet);
            this.xtraTabPage2.Controls.Add(this.TxtVergiD);
            this.xtraTabPage2.Controls.Add(this.labelControl15);
            this.xtraTabPage2.Controls.Add(this.labelControl11);
            this.xtraTabPage2.Controls.Add(this.RchAdres);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(289, 437);
            this.xtraTabPage2.Text = "Adres Bilgileri";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(88, 393);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(145, 23);
            this.BtnTemizle.TabIndex = 64;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // CmbIlce
            // 
            this.CmbIlce.Location = new System.Drawing.Point(90, 90);
            this.CmbIlce.Name = "CmbIlce";
            this.CmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbIlce.Size = new System.Drawing.Size(144, 20);
            this.CmbIlce.TabIndex = 12;
            // 
            // Cmbil
            // 
            this.Cmbil.Location = new System.Drawing.Point(89, 64);
            this.Cmbil.Name = "Cmbil";
            this.Cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmbil.Size = new System.Drawing.Size(144, 20);
            this.Cmbil.TabIndex = 11;
            this.Cmbil.SelectedIndexChanged += new System.EventHandler(this.Cmbil_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(63, 97);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(21, 13);
            this.labelControl8.TabIndex = 61;
            this.labelControl8.Text = "İlçe:";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(74, 71);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(10, 13);
            this.labelControl14.TabIndex = 60;
            this.labelControl14.Text = "İl:";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(89, 354);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(145, 23);
            this.BtnGuncelle.TabIndex = 59;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(89, 315);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(145, 23);
            this.BtnSil.TabIndex = 58;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(89, 273);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(145, 23);
            this.BtnKaydet.TabIndex = 57;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtVergiD
            // 
            this.TxtVergiD.EditValue = "";
            this.TxtVergiD.Location = new System.Drawing.Point(89, 117);
            this.TxtVergiD.Name = "TxtVergiD";
            this.TxtVergiD.Size = new System.Drawing.Size(144, 20);
            this.TxtVergiD.TabIndex = 13;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(23, 124);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(63, 13);
            this.labelControl15.TabIndex = 55;
            this.labelControl15.Text = "Vergi Dairesi:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(54, 143);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(32, 13);
            this.labelControl11.TabIndex = 51;
            this.labelControl11.Text = "Adres:";
            // 
            // RchAdres
            // 
            this.RchAdres.Location = new System.Drawing.Point(89, 143);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(144, 73);
            this.RchAdres.TabIndex = 14;
            this.RchAdres.Text = "";
            // 
            // FrmFirmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(875, 462);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmFirmalar";
            this.Text = "FİRMALAR";
            this.Load += new System.EventHandler(this.FrmFirmalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYGorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSektor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiD.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.MaskedTextBox MskYTC;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtSektor;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox MskTel2;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private System.Windows.Forms.MaskedTextBox MskFax;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.MaskedTextBox MskTel3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.MaskedTextBox MskTel1;
        private DevExpress.XtraEditors.TextEdit TxtYGorev;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtYetkili;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.ComboBoxEdit CmbIlce;
        private DevExpress.XtraEditors.ComboBoxEdit Cmbil;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit TxtVergiD;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.RichTextBox RchAdres;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
    }
}