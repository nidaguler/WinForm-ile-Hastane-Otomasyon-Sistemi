﻿namespace Hastane_Otomasyon
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCins = new System.Windows.Forms.ComboBox();
            this.mskTlf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBilgiGuncelleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(68, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cinsiyet:";
            // 
            // cmbCins
            // 
            this.cmbCins.FormattingEnabled = true;
            this.cmbCins.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbCins.Location = new System.Drawing.Point(154, 143);
            this.cmbCins.Name = "cmbCins";
            this.cmbCins.Size = new System.Drawing.Size(126, 21);
            this.cmbCins.TabIndex = 5;
            // 
            // mskTlf
            // 
            this.mskTlf.Location = new System.Drawing.Point(154, 116);
            this.mskTlf.Mask = "(999) 000-0000";
            this.mskTlf.Name = "mskTlf";
            this.mskTlf.Size = new System.Drawing.Size(126, 20);
            this.mskTlf.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(69, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Telefon:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(154, 86);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(126, 20);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(154, 60);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(126, 20);
            this.txtAd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(80, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(109, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ad:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(154, 177);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(126, 20);
            this.txtSifre.TabIndex = 6;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(154, 30);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(126, 20);
            this.mskTC.TabIndex = 1;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "TC Kimlik No:";
            // 
            // btnBilgiGuncelleme
            // 
            this.btnBilgiGuncelleme.Location = new System.Drawing.Point(162, 214);
            this.btnBilgiGuncelleme.Name = "btnBilgiGuncelleme";
            this.btnBilgiGuncelleme.Size = new System.Drawing.Size(106, 23);
            this.btnBilgiGuncelleme.TabIndex = 7;
            this.btnBilgiGuncelleme.Text = "Bilgilerimi Güncelle";
            this.btnBilgiGuncelleme.UseVisualStyleBackColor = true;
            this.btnBilgiGuncelleme.Click += new System.EventHandler(this.btnBilgiGuncelleme_Click);
            // 
            // FrmBilgiDuzenle
            // 
            this.AcceptButton = this.btnBilgiGuncelleme;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(346, 276);
            this.Controls.Add(this.btnBilgiGuncelleme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCins);
            this.Controls.Add(this.mskTlf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDuzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCins;
        private System.Windows.Forms.MaskedTextBox mskTlf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBilgiGuncelleme;
    }
}