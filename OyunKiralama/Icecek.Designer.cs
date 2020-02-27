namespace OyunKiralama
{
    partial class Icecek
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
            this.silbuton = new System.Windows.Forms.Button();
            this.Eklebuton = new System.Windows.Forms.Button();
            this.guncellebuton = new System.Windows.Forms.Button();
            this.textTarih = new System.Windows.Forms.TextBox();
            this.textMiktar = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(424, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(830, 344);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // silbuton
            // 
            this.silbuton.Location = new System.Drawing.Point(180, 323);
            this.silbuton.Name = "silbuton";
            this.silbuton.Size = new System.Drawing.Size(116, 79);
            this.silbuton.TabIndex = 46;
            this.silbuton.Text = "SİL";
            this.silbuton.UseVisualStyleBackColor = true;
            this.silbuton.Click += new System.EventHandler(this.silbuton_Click);
            // 
            // Eklebuton
            // 
            this.Eklebuton.Location = new System.Drawing.Point(302, 323);
            this.Eklebuton.Name = "Eklebuton";
            this.Eklebuton.Size = new System.Drawing.Size(116, 79);
            this.Eklebuton.TabIndex = 45;
            this.Eklebuton.Text = "EKLE";
            this.Eklebuton.UseVisualStyleBackColor = true;
            this.Eklebuton.Click += new System.EventHandler(this.Eklebuton_Click);
            // 
            // guncellebuton
            // 
            this.guncellebuton.Location = new System.Drawing.Point(58, 325);
            this.guncellebuton.Name = "guncellebuton";
            this.guncellebuton.Size = new System.Drawing.Size(116, 79);
            this.guncellebuton.TabIndex = 44;
            this.guncellebuton.Text = "GÜNCELLE";
            this.guncellebuton.UseVisualStyleBackColor = true;
            this.guncellebuton.Click += new System.EventHandler(this.guncellebuton_Click);
            // 
            // textTarih
            // 
            this.textTarih.Location = new System.Drawing.Point(180, 220);
            this.textTarih.Name = "textTarih";
            this.textTarih.Size = new System.Drawing.Size(240, 22);
            this.textTarih.TabIndex = 40;
            // 
            // textMiktar
            // 
            this.textMiktar.Location = new System.Drawing.Point(180, 180);
            this.textMiktar.Name = "textMiktar";
            this.textMiktar.Size = new System.Drawing.Size(240, 22);
            this.textMiktar.TabIndex = 39;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(180, 144);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(240, 22);
            this.textAd.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(2, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Satın Alma Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(98, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Miktar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(64, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "İçecek Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(28, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 36);
            this.label3.TabIndex = 47;
            this.label3.Text = "DÜKKAN İÇECEK STOĞU";
            // 
            // Icecek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(1272, 440);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.silbuton);
            this.Controls.Add(this.Eklebuton);
            this.Controls.Add(this.guncellebuton);
            this.Controls.Add(this.textTarih);
            this.Controls.Add(this.textMiktar);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Icecek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Icecek";
            this.Load += new System.EventHandler(this.Icecek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button silbuton;
        private System.Windows.Forms.Button Eklebuton;
        private System.Windows.Forms.Button guncellebuton;
        private System.Windows.Forms.TextBox textTarih;
        private System.Windows.Forms.TextBox textMiktar;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}