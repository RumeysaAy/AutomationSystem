namespace Otomasyon_Sistemi
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.TxtKonu = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.RchMesaj = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKonu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(100, 77);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.TxtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtMail.Properties.Appearance.Options.UseBackColor = true;
            this.TxtMail.Properties.Appearance.Options.UseFont = true;
            this.TxtMail.Properties.Appearance.Options.UseForeColor = true;
            this.TxtMail.Size = new System.Drawing.Size(159, 22);
            this.TxtMail.TabIndex = 1;
            // 
            // TxtKonu
            // 
            this.TxtKonu.Location = new System.Drawing.Point(100, 116);
            this.TxtKonu.Name = "TxtKonu";
            this.TxtKonu.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.TxtKonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKonu.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtKonu.Properties.Appearance.Options.UseBackColor = true;
            this.TxtKonu.Properties.Appearance.Options.UseFont = true;
            this.TxtKonu.Properties.Appearance.Options.UseForeColor = true;
            this.TxtKonu.Size = new System.Drawing.Size(159, 22);
            this.TxtKonu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu:";
            // 
            // RchMesaj
            // 
            this.RchMesaj.BackColor = System.Drawing.Color.Black;
            this.RchMesaj.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RchMesaj.ForeColor = System.Drawing.Color.White;
            this.RchMesaj.Location = new System.Drawing.Point(100, 157);
            this.RchMesaj.Name = "RchMesaj";
            this.RchMesaj.Size = new System.Drawing.Size(159, 96);
            this.RchMesaj.TabIndex = 4;
            this.RchMesaj.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesaj:";
            // 
            // BtnGonder
            // 
            this.BtnGonder.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGonder.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.BtnGonder.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGonder.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnGonder.Appearance.Options.UseBackColor = true;
            this.BtnGonder.Appearance.Options.UseFont = true;
            this.BtnGonder.Appearance.Options.UseForeColor = true;
            this.BtnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGonder.ImageOptions.Image")));
            this.BtnGonder.Location = new System.Drawing.Point(100, 273);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(159, 23);
            this.BtnGonder.TabIndex = 7;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "MAIL GÖNDERME";
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(302, 340);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnGonder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RchMesaj);
            this.Controls.Add(this.TxtKonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAIL";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKonu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.TextEdit TxtKonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RchMesaj;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton BtnGonder;
        private System.Windows.Forms.Label label4;
    }
}