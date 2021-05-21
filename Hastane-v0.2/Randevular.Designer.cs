namespace Hastane_v0._2
{
    partial class Randevular
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxPoliklinik = new System.Windows.Forms.ComboBox();
            this.cBoxDoktor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.chkDr = new System.Windows.Forms.CheckBox();
            this.chkPol = new System.Windows.Forms.CheckBox();
            this.radioTc = new System.Windows.Forms.RadioButton();
            this.radioAdSoyad = new System.Windows.Forms.RadioButton();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 589);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.silToolStripMenuItem.Text = "Randevuyu İptal Et";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // txtAra
            // 
            this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(52, 64);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(112, 20);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            this.txtAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAra_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ara:";
            // 
            // cBoxPoliklinik
            // 
            this.cBoxPoliklinik.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxPoliklinik.FormattingEnabled = true;
            this.cBoxPoliklinik.Location = new System.Drawing.Point(275, 15);
            this.cBoxPoliklinik.Name = "cBoxPoliklinik";
            this.cBoxPoliklinik.Size = new System.Drawing.Size(158, 29);
            this.cBoxPoliklinik.TabIndex = 3;
            this.cBoxPoliklinik.SelectedIndexChanged += new System.EventHandler(this.cBoxPoliklinik_SelectedIndexChanged);
            // 
            // cBoxDoktor
            // 
            this.cBoxDoktor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxDoktor.FormattingEnabled = true;
            this.cBoxDoktor.Location = new System.Drawing.Point(275, 55);
            this.cBoxDoktor.Name = "cBoxDoktor";
            this.cBoxDoktor.Size = new System.Drawing.Size(158, 29);
            this.cBoxDoktor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(186, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Poliklinik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(194, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doktor:";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Location = new System.Drawing.Point(574, 19);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(222, 26);
            this.dtBaslangic.TabIndex = 7;
            // 
            // dtBitis
            // 
            this.dtBitis.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Location = new System.Drawing.Point(574, 57);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(222, 26);
            this.dtBitis.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(510, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bitiş T.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(464, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Başlangıç T.:";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrele.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiltrele.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrele.Location = new System.Drawing.Point(574, 99);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(222, 43);
            this.btnFiltrele.TabIndex = 11;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // chkDr
            // 
            this.chkDr.AutoSize = true;
            this.chkDr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkDr.Location = new System.Drawing.Point(439, 60);
            this.chkDr.Name = "chkDr";
            this.chkDr.Size = new System.Drawing.Size(15, 14);
            this.chkDr.TabIndex = 12;
            this.chkDr.UseVisualStyleBackColor = true;
            this.chkDr.CheckedChanged += new System.EventHandler(this.chkDr_CheckedChanged);
            // 
            // chkPol
            // 
            this.chkPol.AutoSize = true;
            this.chkPol.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkPol.Location = new System.Drawing.Point(439, 23);
            this.chkPol.Name = "chkPol";
            this.chkPol.Size = new System.Drawing.Size(15, 14);
            this.chkPol.TabIndex = 13;
            this.chkPol.UseVisualStyleBackColor = true;
            this.chkPol.CheckedChanged += new System.EventHandler(this.chkPol_CheckedChanged);
            // 
            // radioTc
            // 
            this.radioTc.AutoSize = true;
            this.radioTc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioTc.Location = new System.Drawing.Point(52, 15);
            this.radioTc.Name = "radioTc";
            this.radioTc.Size = new System.Drawing.Size(73, 21);
            this.radioTc.TabIndex = 14;
            this.radioTc.TabStop = true;
            this.radioTc.Text = "T.C. No";
            this.radioTc.UseVisualStyleBackColor = true;
            this.radioTc.CheckedChanged += new System.EventHandler(this.radioTc_CheckedChanged);
            // 
            // radioAdSoyad
            // 
            this.radioAdSoyad.AutoSize = true;
            this.radioAdSoyad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioAdSoyad.Location = new System.Drawing.Point(52, 38);
            this.radioAdSoyad.Name = "radioAdSoyad";
            this.radioAdSoyad.Size = new System.Drawing.Size(87, 21);
            this.radioAdSoyad.TabIndex = 15;
            this.radioAdSoyad.TabStop = true;
            this.radioAdSoyad.Text = "Ad Soyad";
            this.radioAdSoyad.UseVisualStyleBackColor = true;
            this.radioAdSoyad.CheckedChanged += new System.EventHandler(this.radioAdSoyad_CheckedChanged);
            // 
            // btnAra
            // 
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(52, 99);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(112, 43);
            this.btnAra.TabIndex = 16;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(301, 118);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(112, 24);
            this.btnTemizle.TabIndex = 17;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Randevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.radioAdSoyad);
            this.Controls.Add(this.radioTc);
            this.Controls.Add(this.chkPol);
            this.Controls.Add(this.chkDr);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxDoktor);
            this.Controls.Add(this.cBoxPoliklinik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(800, 0);
            this.Name = "Randevular";
            this.Size = new System.Drawing.Size(800, 740);
            this.Load += new System.EventHandler(this.Randevular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxPoliklinik;
        private System.Windows.Forms.ComboBox cBoxDoktor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.CheckBox chkDr;
        private System.Windows.Forms.CheckBox chkPol;
        private System.Windows.Forms.RadioButton radioTc;
        private System.Windows.Forms.RadioButton radioAdSoyad;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}
