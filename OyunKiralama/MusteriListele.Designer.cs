using System;
using System.Windows.Forms;

namespace OyunKiralama
{
    partial class MusteriListele
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
            this.iptalbuton = new System.Windows.Forms.Button();
            this.guncellebuton = new System.Windows.Forms.Button();
            this.textADRES = new System.Windows.Forms.TextBox();
            this.textTEL = new System.Windows.Forms.TextBox();
            this.textMAIL = new System.Windows.Forms.TextBox();
            this.textSOYAD = new System.Windows.Forms.TextBox();
            this.textAD = new System.Windows.Forms.TextBox();
            this.textTC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.silbuton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(481, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(830, 344);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // iptalbuton
            // 
            this.iptalbuton.Location = new System.Drawing.Point(336, 312);
            this.iptalbuton.Name = "iptalbuton";
            this.iptalbuton.Size = new System.Drawing.Size(116, 79);
            this.iptalbuton.TabIndex = 30;
            this.iptalbuton.Text = "İPTAL";
            this.iptalbuton.UseVisualStyleBackColor = true;
            this.iptalbuton.Click += new System.EventHandler(this.iptalbuton_Click);
            // 
            // guncellebuton
            // 
            this.guncellebuton.Location = new System.Drawing.Point(92, 314);
            this.guncellebuton.Name = "guncellebuton";
            this.guncellebuton.Size = new System.Drawing.Size(116, 79);
            this.guncellebuton.TabIndex = 29;
            this.guncellebuton.Text = "GÜNCELLE";
            this.guncellebuton.UseVisualStyleBackColor = true;
            this.guncellebuton.Click += new System.EventHandler(this.guncellebuton_Click);
            // 
            // textADRES
            // 
            this.textADRES.Location = new System.Drawing.Point(208, 245);
            this.textADRES.Name = "textADRES";
            this.textADRES.Size = new System.Drawing.Size(240, 22);
            this.textADRES.TabIndex = 28;
            // 
            // textTEL
            // 
            this.textTEL.Location = new System.Drawing.Point(208, 208);
            this.textTEL.Name = "textTEL";
            this.textTEL.Size = new System.Drawing.Size(240, 22);
            this.textTEL.TabIndex = 27;
            // 
            // textMAIL
            // 
            this.textMAIL.Location = new System.Drawing.Point(208, 168);
            this.textMAIL.Name = "textMAIL";
            this.textMAIL.Size = new System.Drawing.Size(240, 22);
            this.textMAIL.TabIndex = 26;
            // 
            // textSOYAD
            // 
            this.textSOYAD.Location = new System.Drawing.Point(208, 128);
            this.textSOYAD.Name = "textSOYAD";
            this.textSOYAD.Size = new System.Drawing.Size(240, 22);
            this.textSOYAD.TabIndex = 25;
            // 
            // textAD
            // 
            this.textAD.Location = new System.Drawing.Point(208, 88);
            this.textAD.Name = "textAD";
            this.textAD.Size = new System.Drawing.Size(240, 22);
            this.textAD.TabIndex = 24;
            // 
            // textTC
            // 
            this.textTC.Location = new System.Drawing.Point(208, 52);
            this.textTC.Name = "textTC";
            this.textTC.Size = new System.Drawing.Size(240, 22);
            this.textTC.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(111, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "ADRES :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(87, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "TELEFON :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(97, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "E - MAİL  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(103, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "SOYADI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(146, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "ADI :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "TC NUMARASI :";
            // 
            // silbuton
            // 
            this.silbuton.Location = new System.Drawing.Point(214, 312);
            this.silbuton.Name = "silbuton";
            this.silbuton.Size = new System.Drawing.Size(116, 79);
            this.silbuton.TabIndex = 31;
            this.silbuton.Text = "SİL";
            this.silbuton.UseVisualStyleBackColor = true;
            this.silbuton.Click += new System.EventHandler(this.silbuton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1071, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 33;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(14)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(973, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "TC ARA";
            // 
            // MusteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(1337, 415);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.silbuton);
            this.Controls.Add(this.iptalbuton);
            this.Controls.Add(this.guncellebuton);
            this.Controls.Add(this.textADRES);
            this.Controls.Add(this.textTEL);
            this.Controls.Add(this.textMAIL);
            this.Controls.Add(this.textSOYAD);
            this.Controls.Add(this.textAD);
            this.Controls.Add(this.textTC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MusteriListele";
            this.Text = "Musteri Listeleme Sayfası";
            this.Load += new System.EventHandler(this.MusteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button iptalbuton;
        private System.Windows.Forms.Button guncellebuton;
        private System.Windows.Forms.TextBox textADRES;
        private System.Windows.Forms.TextBox textTEL;
        private System.Windows.Forms.TextBox textMAIL;
        private System.Windows.Forms.TextBox textSOYAD;
        private System.Windows.Forms.TextBox textAD;
        private System.Windows.Forms.TextBox textTC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button silbuton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}