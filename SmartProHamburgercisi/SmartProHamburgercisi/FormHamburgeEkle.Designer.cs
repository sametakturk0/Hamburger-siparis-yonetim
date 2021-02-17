namespace SmartProHamburgercisi
{
    partial class FormHamburgeEkle
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
            this.btnSil = new System.Windows.Forms.Button();
            this.fpnlHamburgerMalzemeleri = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHamburgerFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtHamburgerAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstHamburgerListesi = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtHamburgerFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(345, 533);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 28);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // fpnlHamburgerMalzemeleri
            // 
            this.fpnlHamburgerMalzemeleri.Location = new System.Drawing.Point(345, 128);
            this.fpnlHamburgerMalzemeleri.Margin = new System.Windows.Forms.Padding(4);
            this.fpnlHamburgerMalzemeleri.Name = "fpnlHamburgerMalzemeleri";
            this.fpnlHamburgerMalzemeleri.Size = new System.Drawing.Size(267, 395);
            this.fpnlHamburgerMalzemeleri.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Malzemeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hamburger Adi";
            // 
            // txtHamburgerFiyat
            // 
            this.txtHamburgerFiyat.Location = new System.Drawing.Point(345, 80);
            this.txtHamburgerFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtHamburgerFiyat.Name = "txtHamburgerFiyat";
            this.txtHamburgerFiyat.Size = new System.Drawing.Size(263, 22);
            this.txtHamburgerFiyat.TabIndex = 10;
            // 
            // txtHamburgerAdi
            // 
            this.txtHamburgerAdi.Location = new System.Drawing.Point(345, 32);
            this.txtHamburgerAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtHamburgerAdi.Name = "txtHamburgerAdi";
            this.txtHamburgerAdi.Size = new System.Drawing.Size(261, 22);
            this.txtHamburgerAdi.TabIndex = 9;
            this.txtHamburgerAdi.TextChanged += new System.EventHandler(this.txtHamburgerAdi_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(512, 533);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 28);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstHamburgerListesi
            // 
            this.lstHamburgerListesi.FormattingEnabled = true;
            this.lstHamburgerListesi.ItemHeight = 16;
            this.lstHamburgerListesi.Location = new System.Drawing.Point(13, 13);
            this.lstHamburgerListesi.Margin = new System.Windows.Forms.Padding(4);
            this.lstHamburgerListesi.Name = "lstHamburgerListesi";
            this.lstHamburgerListesi.Size = new System.Drawing.Size(319, 548);
            this.lstHamburgerListesi.TabIndex = 7;
            this.lstHamburgerListesi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstHamburgerListesi_MouseDoubleClick);
            // 
            // FormHamburgeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 585);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.fpnlHamburgerMalzemeleri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHamburgerFiyat);
            this.Controls.Add(this.txtHamburgerAdi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstHamburgerListesi);
            this.Name = "FormHamburgeEkle";
            this.Text = "FormHamburgeEkle";
            this.Load += new System.EventHandler(this.FormHamburgeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtHamburgerFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.FlowLayoutPanel fpnlHamburgerMalzemeleri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtHamburgerFiyat;
        private System.Windows.Forms.TextBox txtHamburgerAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstHamburgerListesi;
    }
}