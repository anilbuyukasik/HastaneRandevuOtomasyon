namespace Hastane_v0._2
{
    partial class DoktorIslem
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
            this.txtTc = new System.Windows.Forms.MaskedTextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.cBoxMemleket = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.cBoxCins = new System.Windows.Forms.ComboBox();
            this.cBoxPoliklinik = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblil = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblCins = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.Location = new System.Drawing.Point(149, 15);
            this.txtTc.Mask = "00000000000";
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(249, 27);
            this.txtTc.TabIndex = 0;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Azure;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(13, 226);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(79, 37);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSil.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(518, 226);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(249, 37);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Seçileni Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuncelle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(643, 183);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(124, 37);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(149, 48);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(249, 27);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(149, 81);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(249, 27);
            this.txtSoyad.TabIndex = 2;
            // 
            // cBoxMemleket
            // 
            this.cBoxMemleket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBoxMemleket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMemleket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxMemleket.FormattingEnabled = true;
            this.cBoxMemleket.Location = new System.Drawing.Point(518, 79);
            this.cBoxMemleket.Name = "cBoxMemleket";
            this.cBoxMemleket.Size = new System.Drawing.Size(249, 29);
            this.cBoxMemleket.TabIndex = 6;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel.Location = new System.Drawing.Point(518, 15);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(249, 27);
            this.txtTel.TabIndex = 4;
            // 
            // cBoxCins
            // 
            this.cBoxCins.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxCins.FormattingEnabled = true;
            this.cBoxCins.Location = new System.Drawing.Point(149, 114);
            this.cBoxCins.Name = "cBoxCins";
            this.cBoxCins.Size = new System.Drawing.Size(249, 29);
            this.cBoxCins.TabIndex = 3;
            this.cBoxCins.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cBoxCins_KeyDown);
            // 
            // cBoxPoliklinik
            // 
            this.cBoxPoliklinik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBoxPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPoliklinik.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxPoliklinik.FormattingEnabled = true;
            this.cBoxPoliklinik.Location = new System.Drawing.Point(518, 114);
            this.cBoxPoliklinik.Name = "cBoxPoliklinik";
            this.cBoxPoliklinik.Size = new System.Drawing.Size(249, 29);
            this.cBoxPoliklinik.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(518, 48);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(249, 27);
            this.txtMail.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblil);
            this.panel1.Controls.Add(this.lblTel);
            this.panel1.Controls.Add(this.lblTc);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Controls.Add(this.txtTc);
            this.panel1.Controls.Add(this.lblSoyad);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.lblCins);
            this.panel1.Controls.Add(this.cBoxCins);
            this.panel1.Controls.Add(this.cBoxPoliklinik);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.cBoxMemleket);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Location = new System.Drawing.Point(5, 14);
            this.panel1.MinimumSize = new System.Drawing.Size(790, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 280);
            this.panel1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(442, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Poliklinik:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(424, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Memleket:";
            // 
            // lblil
            // 
            this.lblil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblil.AutoSize = true;
            this.lblil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblil.Location = new System.Drawing.Point(456, 54);
            this.lblil.Name = "lblil";
            this.lblil.Size = new System.Drawing.Size(60, 21);
            this.lblil.TabIndex = 40;
            this.lblil.Text = "E-Mail:";
            // 
            // lblTel
            // 
            this.lblTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTel.Location = new System.Drawing.Point(442, 21);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(70, 21);
            this.lblTel.TabIndex = 39;
            this.lblTel.Text = "Telefon:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(72, 21);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(69, 21);
            this.lblTc.TabIndex = 35;
            this.lblTc.Text = "T.C. No:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(103, 54);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(38, 21);
            this.lblAd.TabIndex = 36;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(81, 87);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(62, 21);
            this.lblSoyad.TabIndex = 37;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblCins
            // 
            this.lblCins.AutoSize = true;
            this.lblCins.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCins.Location = new System.Drawing.Point(67, 122);
            this.lblCins.Name = "lblCins";
            this.lblCins.Size = new System.Drawing.Size(74, 21);
            this.lblCins.TabIndex = 38;
            this.lblCins.Text = "Cinsiyet:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKaydet.BackColor = System.Drawing.Color.SpringGreen;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(518, 183);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(124, 37);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 315);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(790, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(790, 425);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // DoktorIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 0);
            this.Name = "DoktorIslem";
            this.Size = new System.Drawing.Size(800, 740);
            this.Load += new System.EventHandler(this.DoktorIslem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTc;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.ComboBox cBoxMemleket;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.ComboBox cBoxCins;
        private System.Windows.Forms.ComboBox cBoxPoliklinik;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblCins;
        private System.Windows.Forms.Label lblil;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
