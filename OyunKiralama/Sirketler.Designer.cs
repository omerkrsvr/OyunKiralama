namespace OyunKiralama
{
    partial class Sirketler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eklebutton = new System.Windows.Forms.Button();
            this.silbuton = new System.Windows.Forms.Button();
            this.guncellebuton = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(980, 376);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // textAdres
            // 
            this.textAdres.Location = new System.Drawing.Point(195, 476);
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(240, 22);
            this.textAdres.TabIndex = 29;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(194, 438);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(240, 22);
            this.textAd.TabIndex = 28;
            this.textAd.TextChanged += new System.EventHandler(this.textBarkod_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(59, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Şirket Adres :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Şirket Adı:";
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(195, 552);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(240, 22);
            this.textMail.TabIndex = 33;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(194, 514);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(240, 22);
            this.textTel.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Şirket Mail Adresi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Şirket Telefon :";
            // 
            // eklebutton
            // 
            this.eklebutton.Location = new System.Drawing.Point(509, 443);
            this.eklebutton.Name = "eklebutton";
            this.eklebutton.Size = new System.Drawing.Size(97, 63);
            this.eklebutton.TabIndex = 34;
            this.eklebutton.Text = "EKLE";
            this.eklebutton.UseVisualStyleBackColor = true;
            this.eklebutton.Click += new System.EventHandler(this.eklebutton_Click);
            // 
            // silbuton
            // 
            this.silbuton.Location = new System.Drawing.Point(612, 444);
            this.silbuton.Name = "silbuton";
            this.silbuton.Size = new System.Drawing.Size(97, 63);
            this.silbuton.TabIndex = 35;
            this.silbuton.Text = "SİL";
            this.silbuton.UseVisualStyleBackColor = true;
            this.silbuton.Click += new System.EventHandler(this.silbuton_Click);
            // 
            // guncellebuton
            // 
            this.guncellebuton.Location = new System.Drawing.Point(715, 444);
            this.guncellebuton.Name = "guncellebuton";
            this.guncellebuton.Size = new System.Drawing.Size(97, 63);
            this.guncellebuton.TabIndex = 36;
            this.guncellebuton.Text = "GÜNCELLE";
            this.guncellebuton.UseVisualStyleBackColor = true;
            this.guncellebuton.Click += new System.EventHandler(this.guncellebuton_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(195, 404);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(240, 22);
            this.textID.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(87, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Şirket No :";
            // 
            // Sirketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(152)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 583);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guncellebuton);
            this.Controls.Add(this.silbuton);
            this.Controls.Add(this.eklebutton);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAdres);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sirketler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şirketler";
            this.Load += new System.EventHandler(this.Sirketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textAdres;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button eklebutton;
        private System.Windows.Forms.Button silbuton;
        private System.Windows.Forms.Button guncellebuton;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label5;
    }
}