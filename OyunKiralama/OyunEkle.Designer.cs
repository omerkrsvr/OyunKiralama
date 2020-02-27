namespace OyunKiralama
{
    partial class OyunEkle
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textPlatform = new System.Windows.Forms.TextBox();
            this.textYapimci = new System.Windows.Forms.TextBox();
            this.textOyunAd = new System.Windows.Forms.TextBox();
            this.textBarkod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboboxTur = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textUcret = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textStok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textCikisTarih = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 79);
            this.button2.TabIndex = 31;
            this.button2.Text = "İPTAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 79);
            this.button1.TabIndex = 30;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPlatform
            // 
            this.textPlatform.Location = new System.Drawing.Point(292, 384);
            this.textPlatform.Name = "textPlatform";
            this.textPlatform.Size = new System.Drawing.Size(240, 22);
            this.textPlatform.TabIndex = 28;
            this.textPlatform.TextChanged += new System.EventHandler(this.textTEL_TextChanged);
            // 
            // textYapimci
            // 
            this.textYapimci.Location = new System.Drawing.Point(292, 304);
            this.textYapimci.Name = "textYapimci";
            this.textYapimci.Size = new System.Drawing.Size(240, 22);
            this.textYapimci.TabIndex = 26;
            this.textYapimci.TextChanged += new System.EventHandler(this.textSOYAD_TextChanged);
            // 
            // textOyunAd
            // 
            this.textOyunAd.Location = new System.Drawing.Point(292, 264);
            this.textOyunAd.Name = "textOyunAd";
            this.textOyunAd.Size = new System.Drawing.Size(240, 22);
            this.textOyunAd.TabIndex = 25;
            this.textOyunAd.TextChanged += new System.EventHandler(this.textAD_TextChanged);
            // 
            // textBarkod
            // 
            this.textBarkod.Location = new System.Drawing.Point(291, 226);
            this.textBarkod.Name = "textBarkod";
            this.textBarkod.Size = new System.Drawing.Size(240, 22);
            this.textBarkod.TabIndex = 24;
            this.textBarkod.TextChanged += new System.EventHandler(this.textTC_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(179, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(367, 46);
            this.label7.TabIndex = 23;
            this.label7.Text = "YENİ OYUN KAYDI";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(60, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Desteklediği Platformlar :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(169, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Oyun Türü :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(139, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Yapımcı Şirket :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(181, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Oyun Adı :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(113, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Barkod Numarası :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(326, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // comboboxTur
            // 
            this.comboboxTur.FormattingEnabled = true;
            this.comboboxTur.Items.AddRange(new object[] {
            "FPS",
            "TPS",
            "RPG",
            "MMORPG",
            "Platform",
            "TBS",
            "RTS",
            "Spor",
            "Survival Horror",
            "Adventure"});
            this.comboboxTur.Location = new System.Drawing.Point(293, 341);
            this.comboboxTur.Name = "comboboxTur";
            this.comboboxTur.Size = new System.Drawing.Size(238, 24);
            this.comboboxTur.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 44);
            this.button3.TabIndex = 34;
            this.button3.Text = "RESİM YÜKLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textUcret
            // 
            this.textUcret.Location = new System.Drawing.Point(291, 462);
            this.textUcret.Name = "textUcret";
            this.textUcret.Size = new System.Drawing.Size(240, 22);
            this.textUcret.TabIndex = 36;
            this.textUcret.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(217, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ücret :";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // textStok
            // 
            this.textStok.Location = new System.Drawing.Point(291, 504);
            this.textStok.Name = "textStok";
            this.textStok.Size = new System.Drawing.Size(240, 22);
            this.textStok.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(223, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Stok :";
            // 
            // textCikisTarih
            // 
            this.textCikisTarih.Location = new System.Drawing.Point(291, 423);
            this.textCikisTarih.Name = "textCikisTarih";
            this.textCikisTarih.Size = new System.Drawing.Size(240, 22);
            this.textCikisTarih.TabIndex = 40;
            this.textCikisTarih.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(166, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Çıkış Tarihi :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OyunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(679, 680);
            this.Controls.Add(this.textCikisTarih);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textStok);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textUcret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboboxTur);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPlatform);
            this.Controls.Add(this.textYapimci);
            this.Controls.Add(this.textOyunAd);
            this.Controls.Add(this.textBarkod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "OyunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OyunEkle";
            this.Load += new System.EventHandler(this.OyunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textPlatform;
        private System.Windows.Forms.TextBox textYapimci;
        private System.Windows.Forms.TextBox textOyunAd;
        private System.Windows.Forms.TextBox textBarkod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboboxTur;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textUcret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCikisTarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}