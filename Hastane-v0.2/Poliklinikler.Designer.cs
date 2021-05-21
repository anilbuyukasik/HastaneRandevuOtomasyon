namespace Hastane_v0._2
{
    partial class Poliklinikler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpEkle = new System.Windows.Forms.GroupBox();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grpSil = new System.Windows.Forms.GroupBox();
            this.cBoxSil = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpGuncelle = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxGuncelle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuncelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxDurum = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grpEkle.SuspendLayout();
            this.grpSil.SuspendLayout();
            this.grpGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEkle
            // 
            this.grpEkle.Controls.Add(this.btnEkle);
            this.grpEkle.Controls.Add(this.label1);
            this.grpEkle.Controls.Add(this.txtEkle);
            this.grpEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpEkle.Location = new System.Drawing.Point(18, 30);
            this.grpEkle.Name = "grpEkle";
            this.grpEkle.Size = new System.Drawing.Size(349, 220);
            this.grpEkle.TabIndex = 0;
            this.grpEkle.TabStop = false;
            this.grpEkle.Text = "Poliklinik Ekle";
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(96, 50);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(176, 27);
            this.txtEkle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Poliklinik Adı:";
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(96, 120);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(180, 50);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // grpSil
            // 
            this.grpSil.Controls.Add(this.label2);
            this.grpSil.Controls.Add(this.btnSil);
            this.grpSil.Controls.Add(this.cBoxSil);
            this.grpSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSil.Location = new System.Drawing.Point(398, 30);
            this.grpSil.Name = "grpSil";
            this.grpSil.Size = new System.Drawing.Size(349, 220);
            this.grpSil.TabIndex = 1;
            this.grpSil.TabStop = false;
            this.grpSil.Text = "Poliklinik Sil";
            // 
            // cBoxSil
            // 
            this.cBoxSil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSil.FormattingEnabled = true;
            this.cBoxSil.Location = new System.Drawing.Point(102, 56);
            this.cBoxSil.Name = "cBoxSil";
            this.cBoxSil.Size = new System.Drawing.Size(176, 29);
            this.cBoxSil.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(102, 120);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(180, 50);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Poliklinik Adı:";
            // 
            // grpGuncelle
            // 
            this.grpGuncelle.Controls.Add(this.btnGuncelle);
            this.grpGuncelle.Controls.Add(this.label5);
            this.grpGuncelle.Controls.Add(this.cBoxDurum);
            this.grpGuncelle.Controls.Add(this.label4);
            this.grpGuncelle.Controls.Add(this.txtGuncelle);
            this.grpGuncelle.Controls.Add(this.label3);
            this.grpGuncelle.Controls.Add(this.cBoxGuncelle);
            this.grpGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpGuncelle.Location = new System.Drawing.Point(18, 296);
            this.grpGuncelle.Name = "grpGuncelle";
            this.grpGuncelle.Size = new System.Drawing.Size(729, 246);
            this.grpGuncelle.TabIndex = 2;
            this.grpGuncelle.TabStop = false;
            this.grpGuncelle.Text = "Poliklinik Güncelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Poliklinik Adı:";
            // 
            // cBoxGuncelle
            // 
            this.cBoxGuncelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGuncelle.FormattingEnabled = true;
            this.cBoxGuncelle.Location = new System.Drawing.Point(96, 55);
            this.cBoxGuncelle.Name = "cBoxGuncelle";
            this.cBoxGuncelle.Size = new System.Drawing.Size(176, 29);
            this.cBoxGuncelle.TabIndex = 3;
            this.cBoxGuncelle.SelectedIndexChanged += new System.EventHandler(this.cBoxGuncelle_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(355, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yeni Poliklinik Adı:";
            // 
            // txtGuncelle
            // 
            this.txtGuncelle.Location = new System.Drawing.Point(482, 56);
            this.txtGuncelle.Name = "txtGuncelle";
            this.txtGuncelle.Size = new System.Drawing.Size(176, 27);
            this.txtGuncelle.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Durum:";
            // 
            // cBoxDurum
            // 
            this.cBoxDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDurum.FormattingEnabled = true;
            this.cBoxDurum.Location = new System.Drawing.Point(96, 176);
            this.cBoxDurum.Name = "cBoxDurum";
            this.cBoxDurum.Size = new System.Drawing.Size(176, 29);
            this.cBoxDurum.TabIndex = 7;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(478, 164);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(180, 50);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Poliklinikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(225)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.grpGuncelle);
            this.Controls.Add(this.grpSil);
            this.Controls.Add(this.grpEkle);
            this.MinimumSize = new System.Drawing.Size(800, 0);
            this.Name = "Poliklinikler";
            this.Size = new System.Drawing.Size(800, 740);
            this.Load += new System.EventHandler(this.Poliklinikler_Load);
            this.grpEkle.ResumeLayout(false);
            this.grpEkle.PerformLayout();
            this.grpSil.ResumeLayout(false);
            this.grpSil.PerformLayout();
            this.grpGuncelle.ResumeLayout(false);
            this.grpGuncelle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.GroupBox grpSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cBoxSil;
        private System.Windows.Forms.GroupBox grpGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxDurum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxGuncelle;
    }
}
