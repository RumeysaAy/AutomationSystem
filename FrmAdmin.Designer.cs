namespace Otomasyon_Sistemi
{
    partial class FrmAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.TxtParola = new DevExpress.XtraEditors.TextEdit();
            this.BtnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtParola.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            // 
            // TxtKullanici
            // 
            this.TxtKullanici.Location = new System.Drawing.Point(38, 87);
            this.TxtKullanici.Name = "TxtKullanici";
            this.TxtKullanici.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.TxtKullanici.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullanici.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtKullanici.Properties.Appearance.Options.UseBackColor = true;
            this.TxtKullanici.Properties.Appearance.Options.UseFont = true;
            this.TxtKullanici.Properties.Appearance.Options.UseForeColor = true;
            this.TxtKullanici.Size = new System.Drawing.Size(170, 26);
            this.TxtKullanici.TabIndex = 2;
            // 
            // TxtParola
            // 
            this.TxtParola.Location = new System.Drawing.Point(38, 177);
            this.TxtParola.Name = "TxtParola";
            this.TxtParola.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.TxtParola.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtParola.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtParola.Properties.Appearance.Options.UseBackColor = true;
            this.TxtParola.Properties.Appearance.Options.UseFont = true;
            this.TxtParola.Properties.Appearance.Options.UseForeColor = true;
            this.TxtParola.Properties.UseSystemPasswordChar = true;
            this.TxtParola.Size = new System.Drawing.Size(170, 26);
            this.TxtParola.TabIndex = 3;
            // 
            // BtnGiris
            // 
            this.BtnGiris.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.Appearance.Options.UseFont = true;
            this.BtnGiris.Location = new System.Drawing.Point(38, 254);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(170, 23);
            this.BtnGiris.TabIndex = 4;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(80, 320);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(249, 393);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.TxtParola);
            this.Controls.Add(this.TxtKullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMİN";
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtParola.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit TxtKullanici;
        private DevExpress.XtraEditors.TextEdit TxtParola;
        private DevExpress.XtraEditors.SimpleButton BtnGiris;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}