namespace Otomasyon_Sistemi
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.CmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtGorev = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGorev.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
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
            this.gridControl1.Size = new System.Drawing.Size(576, 469);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // CmbIlce
            // 
            this.CmbIlce.Location = new System.Drawing.Point(85, 192);
            this.CmbIlce.Name = "CmbIlce";
            this.CmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbIlce.Size = new System.Drawing.Size(144, 20);
            this.CmbIlce.TabIndex = 7;
            // 
            // Cmbil
            // 
            this.Cmbil.Location = new System.Drawing.Point(84, 166);
            this.Cmbil.Name = "Cmbil";
            this.Cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmbil.Size = new System.Drawing.Size(144, 20);
            this.Cmbil.TabIndex = 6;
            this.Cmbil.SelectedIndexChanged += new System.EventHandler(this.Cmbil_SelectedIndexChanged);
            // 
            // MskTC
            // 
            this.MskTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MskTC.Location = new System.Drawing.Point(84, 113);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(144, 21);
            this.MskTC.TabIndex = 4;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // MskTel
            // 
            this.MskTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MskTel.Location = new System.Drawing.Point(84, 86);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(144, 21);
            this.MskTel.TabIndex = 3;
            // 
            // TxtGorev
            // 
            this.TxtGorev.Location = new System.Drawing.Point(84, 218);
            this.TxtGorev.Name = "TxtGorev";
            this.TxtGorev.Size = new System.Drawing.Size(144, 20);
            this.TxtGorev.TabIndex = 8;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(47, 244);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(32, 13);
            this.labelControl11.TabIndex = 44;
            this.labelControl11.Text = "Adres:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(48, 225);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 13);
            this.labelControl10.TabIndex = 43;
            this.labelControl10.Text = "Görev:";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(84, 397);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(144, 23);
            this.BtnGuncelle.TabIndex = 41;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(84, 368);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(144, 23);
            this.BtnSil.TabIndex = 40;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(84, 339);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(144, 23);
            this.BtnKaydet.TabIndex = 39;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RchAdres
            // 
            this.RchAdres.Location = new System.Drawing.Point(84, 244);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(144, 69);
            this.RchAdres.TabIndex = 9;
            this.RchAdres.Text = "";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.BtnTemizle);
            this.xtraTabPage1.Controls.Add(this.CmbIlce);
            this.xtraTabPage1.Controls.Add(this.Cmbil);
            this.xtraTabPage1.Controls.Add(this.MskTC);
            this.xtraTabPage1.Controls.Add(this.MskTel);
            this.xtraTabPage1.Controls.Add(this.TxtGorev);
            this.xtraTabPage1.Controls.Add(this.labelControl11);
            this.xtraTabPage1.Controls.Add(this.labelControl10);
            this.xtraTabPage1.Controls.Add(this.BtnGuncelle);
            this.xtraTabPage1.Controls.Add(this.BtnSil);
            this.xtraTabPage1.Controls.Add(this.BtnKaydet);
            this.xtraTabPage1.Controls.Add(this.RchAdres);
            this.xtraTabPage1.Controls.Add(this.labelControl9);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.TxtMail);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.TxtSoyad);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.TxtAd);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.Txtid);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(282, 441);
            this.xtraTabPage1.Text = "Personeller";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(84, 426);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(144, 23);
            this.BtnTemizle.TabIndex = 50;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(58, 199);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(21, 13);
            this.labelControl9.TabIndex = 37;
            this.labelControl9.Text = "İlçe:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(69, 173);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(10, 13);
            this.labelControl8.TabIndex = 35;
            this.labelControl8.Text = "İl:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(84, 140);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(144, 20);
            this.TxtMail.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(57, 147);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(22, 13);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "Mail:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(62, 121);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(17, 13);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "TC:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(41, 94);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Telefon:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(84, 61);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(144, 20);
            this.TxtSoyad.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(47, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(84, 35);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(144, 20);
            this.TxtAd.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(62, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Ad:";
            // 
            // Txtid
            // 
            this.Txtid.EditValue = "";
            this.Txtid.Location = new System.Drawing.Point(84, 9);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(144, 20);
            this.Txtid.TabIndex = 100;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(64, 16);
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
            this.splitContainer1.Size = new System.Drawing.Size(868, 469);
            this.splitContainer1.SplitterDistance = 288;
            this.splitContainer1.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(288, 469);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(868, 469);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmPersonel";
            this.Text = "PERSONELLER";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGorev.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private DevExpress.XtraEditors.TextEdit TxtGorev;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RchAdres;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
    }
}