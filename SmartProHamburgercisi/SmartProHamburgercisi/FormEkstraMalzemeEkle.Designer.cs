namespace SmartProHamburgercisi
{
    partial class FormEkstraMalzemeEkle
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEkstraMalzemeFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraMalzemeAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstEkstraMalzemeler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtEkstraMalzemeFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(257, 104);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 227);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(254, 431);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ekstra Malzeme Adi";
            // 
            // txtEkstraMalzemeFiyat
            // 
            this.txtEkstraMalzemeFiyat.Location = new System.Drawing.Point(257, 65);
            this.txtEkstraMalzemeFiyat.Name = "txtEkstraMalzemeFiyat";
            this.txtEkstraMalzemeFiyat.Size = new System.Drawing.Size(197, 20);
            this.txtEkstraMalzemeFiyat.TabIndex = 18;
            // 
            // txtEkstraMalzemeAdi
            // 
            this.txtEkstraMalzemeAdi.Location = new System.Drawing.Point(257, 26);
            this.txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            this.txtEkstraMalzemeAdi.Size = new System.Drawing.Size(197, 20);
            this.txtEkstraMalzemeAdi.TabIndex = 17;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(382, 431);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstEkstraMalzemeler
            // 
            this.lstEkstraMalzemeler.FormattingEnabled = true;
            this.lstEkstraMalzemeler.Location = new System.Drawing.Point(8, 11);
            this.lstEkstraMalzemeler.Name = "lstEkstraMalzemeler";
            this.lstEkstraMalzemeler.Size = new System.Drawing.Size(240, 446);
            this.lstEkstraMalzemeler.TabIndex = 15;
            // 
            // FormEkstraMalzemeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 468);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEkstraMalzemeFiyat);
            this.Controls.Add(this.txtEkstraMalzemeAdi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstEkstraMalzemeler);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEkstraMalzemeEkle";
            this.Text = "FormEkstraMalzemeEkle";
            this.Load += new System.EventHandler(this.FormEkstraMalzemeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEkstraMalzemeFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtEkstraMalzemeFiyat;
        private System.Windows.Forms.TextBox txtEkstraMalzemeAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstEkstraMalzemeler;
    }
}