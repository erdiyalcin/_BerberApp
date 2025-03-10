namespace _BerberApp
{
    partial class frmGiris
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
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMatematik = new System.Windows.Forms.Label();
            this.txtMatematik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.Tomato;
            this.btnGirisYap.Location = new System.Drawing.Point(729, 622);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(291, 94);
            this.btnGirisYap.TabIndex = 0;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(201, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eposta : ";
            // 
            // txtEposta
            // 
            this.txtEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEposta.Location = new System.Drawing.Point(454, 319);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(566, 71);
            this.txtEposta.TabIndex = 2;
            this.txtEposta.Text = "erdi@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(259, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 64);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre : ";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.Location = new System.Drawing.Point(454, 425);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(566, 71);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.Text = "1234";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(448, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 135);
            this.label3.TabIndex = 5;
            this.label3.Text = "BerBer";
            // 
            // lblMatematik
            // 
            this.lblMatematik.AutoSize = true;
            this.lblMatematik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatematik.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMatematik.Location = new System.Drawing.Point(460, 532);
            this.lblMatematik.Name = "lblMatematik";
            this.lblMatematik.Size = new System.Drawing.Size(75, 64);
            this.lblMatematik.TabIndex = 6;
            this.lblMatematik.Text = "...";
            // 
            // txtMatematik
            // 
            this.txtMatematik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatematik.Location = new System.Drawing.Point(729, 525);
            this.txtMatematik.Name = "txtMatematik";
            this.txtMatematik.Size = new System.Drawing.Size(291, 71);
            this.txtMatematik.TabIndex = 7;
            this.txtMatematik.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1437, 1106);
            this.Controls.Add(this.txtMatematik);
            this.Controls.Add(this.lblMatematik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGirisYap);
            this.Name = "frmGiris";
            this.Text = "Berber App v1.0";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMatematik;
        private System.Windows.Forms.TextBox txtMatematik;
    }
}