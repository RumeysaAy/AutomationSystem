namespace Otomasyon_Sistemi
{
    partial class FrmAyarlar
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtParola = new DevExpress.XtraEditors.TextEdit();
            this.TxtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.BtnGuncelle);
            this.splitContainerControl1.Panel1.Controls.Add(this.TxtMail);
            this.splitContainerControl1.Panel1.Controls.Add(this.label3);
            this.splitContainerControl1.Panel1.Controls.Add(this.BtnKaydet);
            this.splitContainerControl1.Panel1.Controls.Add(this.TxtParola);
            this.splitContainerControl1.Panel1.Controls.Add(this.TxtKullaniciAdi);
            this.splitContainerControl1.Panel1.Controls.Add(this.label2);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(657, 264);
            this.splitContainerControl1.SplitterPosition = 271;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(104, 96);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.TxtMail.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtMail.Properties.Appearance.Options.UseBackColor = true;
            this.TxtMail.Properties.Appearance.Options.UseFont = true;
            this.TxtMail.Properties.Appearance.Options.UseForeColor = true;
            this.TxtMail.Size = new System.Drawing.Size(142, 24);
            this.TxtMail.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mail:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.ForeColor = System.Drawing.Color.Black;
            this.BtnKaydet.Location = new System.Drawing.Point(104, 175);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(142, 27);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtParola
            // 
            this.TxtParola.Location = new System.Drawing.Point(104, 126);
            this.TxtParola.Name = "TxtParola";
            this.TxtParola.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.TxtParola.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtParola.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtParola.Properties.Appearance.Options.UseBackColor = true;
            this.TxtParola.Properties.Appearance.Options.UseFont = true;
            this.TxtParola.Properties.Appearance.Options.UseForeColor = true;
            this.TxtParola.Size = new System.Drawing.Size(142, 24);
            this.TxtParola.TabIndex = 8;
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(104, 66);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.TxtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAdi.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtKullaniciAdi.Properties.Appearance.Options.UseBackColor = true;
            this.TxtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.TxtKullaniciAdi.Properties.Appearance.Options.UseForeColor = true;
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(142, 24);
            this.TxtKullaniciAdi.TabIndex = 7;
            this.TxtKullaniciAdi.EditValueChanged += new System.EventHandler(this.TxtKullaniciAdi_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(381, 264);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.BtnGuncelle.Location = new System.Drawing.Point(104, 208);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(142, 27);
            this.BtnGuncelle.TabIndex = 12;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // FrmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(657, 264);
            this.Controls.Add(this.splitContainerControl1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAyarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AYARLAR";
            this.Load += new System.EventHandler(this.FrmAyarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Button BtnKaydet;
        private DevExpress.XtraEditors.TextEdit TxtParola;
        private DevExpress.XtraEditors.TextEdit TxtKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGuncelle;
    }
}