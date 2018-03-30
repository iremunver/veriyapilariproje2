namespace otoparkOtomasyon2
{
    partial class Form1
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
            this.lblRenk = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.btnBodrumEkle = new System.Windows.Forms.Button();
            this.btnKat1Ekle = new System.Windows.Forms.Button();
            this.btnKat2Ekle = new System.Windows.Forms.Button();
            this.lBoxBodrum = new System.Windows.Forms.ListBox();
            this.lBoxKat1 = new System.Windows.Forms.ListBox();
            this.lBoxKat2 = new System.Windows.Forms.ListBox();
            this.btnCikar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Location = new System.Drawing.Point(42, 42);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(37, 13);
            this.lblRenk.TabIndex = 0;
            this.lblRenk.Text = "RENK";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(131, 42);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 20);
            this.txtRenk.TabIndex = 1;
            // 
            // btnBodrumEkle
            // 
            this.btnBodrumEkle.Location = new System.Drawing.Point(45, 93);
            this.btnBodrumEkle.Name = "btnBodrumEkle";
            this.btnBodrumEkle.Size = new System.Drawing.Size(138, 23);
            this.btnBodrumEkle.TabIndex = 2;
            this.btnBodrumEkle.Text = "BODRUM KATA EKLE";
            this.btnBodrumEkle.UseVisualStyleBackColor = true;
            this.btnBodrumEkle.Click += new System.EventHandler(this.btnBodrumEkle_Click);
            // 
            // btnKat1Ekle
            // 
            this.btnKat1Ekle.Location = new System.Drawing.Point(240, 93);
            this.btnKat1Ekle.Name = "btnKat1Ekle";
            this.btnKat1Ekle.Size = new System.Drawing.Size(138, 23);
            this.btnKat1Ekle.TabIndex = 3;
            this.btnKat1Ekle.Text = "1. KATA EKLE";
            this.btnKat1Ekle.UseVisualStyleBackColor = true;
            this.btnKat1Ekle.Click += new System.EventHandler(this.btnKat1Ekle_Click);
            // 
            // btnKat2Ekle
            // 
            this.btnKat2Ekle.Location = new System.Drawing.Point(437, 93);
            this.btnKat2Ekle.Name = "btnKat2Ekle";
            this.btnKat2Ekle.Size = new System.Drawing.Size(138, 23);
            this.btnKat2Ekle.TabIndex = 4;
            this.btnKat2Ekle.Text = "2. KATA EKLE";
            this.btnKat2Ekle.UseVisualStyleBackColor = true;
            this.btnKat2Ekle.Click += new System.EventHandler(this.btnKat2Ekle_Click);
            // 
            // lBoxBodrum
            // 
            this.lBoxBodrum.FormattingEnabled = true;
            this.lBoxBodrum.Location = new System.Drawing.Point(45, 153);
            this.lBoxBodrum.Name = "lBoxBodrum";
            this.lBoxBodrum.Size = new System.Drawing.Size(138, 147);
            this.lBoxBodrum.TabIndex = 5;
            // 
            // lBoxKat1
            // 
            this.lBoxKat1.FormattingEnabled = true;
            this.lBoxKat1.Location = new System.Drawing.Point(240, 153);
            this.lBoxKat1.Name = "lBoxKat1";
            this.lBoxKat1.Size = new System.Drawing.Size(138, 147);
            this.lBoxKat1.TabIndex = 6;
            // 
            // lBoxKat2
            // 
            this.lBoxKat2.FormattingEnabled = true;
            this.lBoxKat2.Location = new System.Drawing.Point(437, 153);
            this.lBoxKat2.Name = "lBoxKat2";
            this.lBoxKat2.Size = new System.Drawing.Size(138, 147);
            this.lBoxKat2.TabIndex = 7;
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(240, 345);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(138, 23);
            this.btnCikar.TabIndex = 8;
            this.btnCikar.Text = "ÇIKAR";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 395);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.lBoxKat2);
            this.Controls.Add(this.lBoxKat1);
            this.Controls.Add(this.lBoxBodrum);
            this.Controls.Add(this.btnKat2Ekle);
            this.Controls.Add(this.btnKat1Ekle);
            this.Controls.Add(this.btnBodrumEkle);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.lblRenk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Button btnBodrumEkle;
        private System.Windows.Forms.Button btnKat1Ekle;
        private System.Windows.Forms.Button btnKat2Ekle;
        private System.Windows.Forms.ListBox lBoxBodrum;
        private System.Windows.Forms.ListBox lBoxKat1;
        private System.Windows.Forms.ListBox lBoxKat2;
        private System.Windows.Forms.Button btnCikar;
    }
}

