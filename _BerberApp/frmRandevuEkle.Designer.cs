namespace _BerberApp
{
    partial class frmRandevuEkle
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
            this.cbIslem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.dtpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.txtBahsis = new System.Windows.Forms.TextBox();
            this.chkGeldiMi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbIslem
            // 
            this.cbIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIslem.FormattingEnabled = true;
            this.cbIslem.Location = new System.Drawing.Point(501, 482);
            this.cbIslem.Name = "cbIslem";
            this.cbIslem.Size = new System.Drawing.Size(477, 62);
            this.cbIslem.TabIndex = 31;
            this.cbIslem.SelectedIndexChanged += new System.EventHandler(this.cbIslem_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(294, 668);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 54);
            this.label6.TabIndex = 30;
            this.label6.Text = "Bahşiş : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(281, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 54);
            this.label5.TabIndex = 29;
            this.label5.Text = "Müşteri : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(118, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 54);
            this.label4.TabIndex = 28;
            this.label4.Text = "Randevu Tarihi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(373, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(493, 83);
            this.label3.TabIndex = 27;
            this.label3.Text = "Randevu Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(322, 573);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 54);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ücret : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(323, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 54);
            this.label1.TabIndex = 25;
            this.label1.Text = "İşlem : ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Green;
            this.btnKaydet.Location = new System.Drawing.Point(733, 851);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(245, 79);
            this.btnKaydet.TabIndex = 24;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusteri.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMusteri.Location = new System.Drawing.Point(501, 302);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(62, 54);
            this.lblMusteri.TabIndex = 32;
            this.lblMusteri.Text = "...";
            // 
            // dtpRandevuTarihi
            // 
            this.dtpRandevuTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRandevuTarihi.Location = new System.Drawing.Point(501, 396);
            this.dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            this.dtpRandevuTarihi.Size = new System.Drawing.Size(792, 53);
            this.dtpRandevuTarihi.TabIndex = 33;
            // 
            // txtUcret
            // 
            this.txtUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUcret.Location = new System.Drawing.Point(501, 577);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(477, 53);
            this.txtUcret.TabIndex = 34;
            // 
            // txtBahsis
            // 
            this.txtBahsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBahsis.Location = new System.Drawing.Point(501, 669);
            this.txtBahsis.Name = "txtBahsis";
            this.txtBahsis.Size = new System.Drawing.Size(477, 53);
            this.txtBahsis.TabIndex = 35;
            // 
            // chkGeldiMi
            // 
            this.chkGeldiMi.AutoSize = true;
            this.chkGeldiMi.Checked = true;
            this.chkGeldiMi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGeldiMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGeldiMi.Location = new System.Drawing.Point(501, 765);
            this.chkGeldiMi.Name = "chkGeldiMi";
            this.chkGeldiMi.Size = new System.Drawing.Size(226, 50);
            this.chkGeldiMi.TabIndex = 36;
            this.chkGeldiMi.Text = "Geldi Mi?";
            this.chkGeldiMi.UseVisualStyleBackColor = true;
            // 
            // frmRandevuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 1258);
            this.Controls.Add(this.chkGeldiMi);
            this.Controls.Add(this.txtBahsis);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.dtpRandevuTarihi);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.cbIslem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Name = "frmRandevuEkle";
            this.Text = "frmRandevuEkle";
            this.Load += new System.EventHandler(this.frmRandevuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIslem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.DateTimePicker dtpRandevuTarihi;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtBahsis;
        private System.Windows.Forms.CheckBox chkGeldiMi;
    }
}