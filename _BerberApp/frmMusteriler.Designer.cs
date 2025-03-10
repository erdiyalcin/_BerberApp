namespace _BerberApp
{
    partial class frmMusteriler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSil = new System.Windows.Forms.ToolStripMenuItem();
            this.cbYetki = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.randevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRandevuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRandevuListele = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMusteriler
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMusteriler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMusteriler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMusteriler.Location = new System.Drawing.Point(48, 149);
            this.dgvMusteriler.Name = "dgvMusteriler";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusteriler.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMusteriler.RowHeadersWidth = 102;
            this.dgvMusteriler.RowTemplate.Height = 40;
            this.dgvMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriler.Size = new System.Drawing.Size(2050, 827);
            this.dgvMusteriler.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDuzenle,
            this.menuSil,
            this.randevuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(361, 203);
            // 
            // menuDuzenle
            // 
            this.menuDuzenle.Name = "menuDuzenle";
            this.menuDuzenle.Size = new System.Drawing.Size(360, 48);
            this.menuDuzenle.Text = "Düzenle";
            this.menuDuzenle.Click += new System.EventHandler(this.menuDuzenle_Click);
            // 
            // menuSil
            // 
            this.menuSil.Name = "menuSil";
            this.menuSil.Size = new System.Drawing.Size(360, 48);
            this.menuSil.Text = "Sil";
            this.menuSil.Click += new System.EventHandler(this.menuSil_Click);
            // 
            // cbYetki
            // 
            this.cbYetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYetki.FormattingEnabled = true;
            this.cbYetki.Location = new System.Drawing.Point(513, 55);
            this.cbYetki.Name = "cbYetki";
            this.cbYetki.Size = new System.Drawing.Size(266, 54);
            this.cbYetki.TabIndex = 25;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(1477, 55);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(266, 113);
            this.btnAra.TabIndex = 24;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArama.Location = new System.Drawing.Point(932, 55);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(266, 60);
            this.txtArama.TabIndex = 23;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(48, 54);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(266, 113);
            this.btnMusteriEkle.TabIndex = 22;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRandevuEkle,
            this.menuRandevuListele});
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(360, 48);
            this.randevuToolStripMenuItem.Text = "Randevu";
            // 
            // menuRandevuEkle
            // 
            this.menuRandevuEkle.Name = "menuRandevuEkle";
            this.menuRandevuEkle.Size = new System.Drawing.Size(448, 54);
            this.menuRandevuEkle.Text = "Ekle";
            this.menuRandevuEkle.Click += new System.EventHandler(this.menuRandevuEkle_Click);
            // 
            // menuRandevuListele
            // 
            this.menuRandevuListele.Name = "menuRandevuListele";
            this.menuRandevuListele.Size = new System.Drawing.Size(448, 54);
            this.menuRandevuListele.Text = "Listesi";
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2201, 1083);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.cbYetki);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnMusteriEkle);
            this.Name = "frmMusteriler";
            this.Text = "frmMusteriler";
            this.Load += new System.EventHandler(this.frmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDuzenle;
        private System.Windows.Forms.ToolStripMenuItem menuSil;
        private System.Windows.Forms.ComboBox cbYetki;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRandevuEkle;
        private System.Windows.Forms.ToolStripMenuItem menuRandevuListele;
    }
}