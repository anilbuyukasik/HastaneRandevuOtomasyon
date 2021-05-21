namespace Hastane_v0._2
{
    partial class izinOnay
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
            this.drpFiltre = new System.Windows.Forms.DataGridView();
            this.sec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iziniOnaylaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.radioAdSoyad = new System.Windows.Forms.RadioButton();
            this.radioTc = new System.Windows.Forms.RadioButton();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.radioHepsi = new System.Windows.Forms.RadioButton();
            this.radioOnaylandi = new System.Windows.Forms.RadioButton();
            this.radioOnaylanmamis = new System.Windows.Forms.RadioButton();
            this.grpAra = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioHepsi1 = new System.Windows.Forms.RadioButton();
            this.radioOnaylandi1 = new System.Windows.Forms.RadioButton();
            this.radioOnaylanmamis1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.drpFiltre)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.grpAra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drpFiltre
            // 
            this.drpFiltre.AllowUserToAddRows = false;
            this.drpFiltre.AllowUserToDeleteRows = false;
            this.drpFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drpFiltre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.drpFiltre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.drpFiltre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drpFiltre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sec});
            this.drpFiltre.ContextMenuStrip = this.contextMenuStrip1;
            this.drpFiltre.Location = new System.Drawing.Point(4, 210);
            this.drpFiltre.MultiSelect = false;
            this.drpFiltre.Name = "drpFiltre";
            this.drpFiltre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drpFiltre.Size = new System.Drawing.Size(793, 527);
            this.drpFiltre.TabIndex = 0;
            // 
            // sec
            // 
            this.sec.HeaderText = "Seç";
            this.sec.Name = "sec";
            this.sec.Width = 32;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iziniOnaylaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 26);
            // 
            // iziniOnaylaToolStripMenuItem
            // 
            this.iziniOnaylaToolStripMenuItem.Name = "iziniOnaylaToolStripMenuItem";
            this.iziniOnaylaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.iziniOnaylaToolStripMenuItem.Text = "İzini Onayla";
            this.iziniOnaylaToolStripMenuItem.Click += new System.EventHandler(this.iziniOnaylaToolStripMenuItem_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(330, 180);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(112, 24);
            this.btnTemizle.TabIndex = 34;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(51, 104);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(112, 43);
            this.btnAra.TabIndex = 33;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // radioAdSoyad
            // 
            this.radioAdSoyad.AutoSize = true;
            this.radioAdSoyad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioAdSoyad.Location = new System.Drawing.Point(51, 43);
            this.radioAdSoyad.Name = "radioAdSoyad";
            this.radioAdSoyad.Size = new System.Drawing.Size(87, 21);
            this.radioAdSoyad.TabIndex = 32;
            this.radioAdSoyad.Text = "Ad Soyad";
            this.radioAdSoyad.UseVisualStyleBackColor = true;
            this.radioAdSoyad.CheckedChanged += new System.EventHandler(this.radioAdSoyad_CheckedChanged);
            // 
            // radioTc
            // 
            this.radioTc.AutoSize = true;
            this.radioTc.Checked = true;
            this.radioTc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioTc.Location = new System.Drawing.Point(51, 20);
            this.radioTc.Name = "radioTc";
            this.radioTc.Size = new System.Drawing.Size(73, 21);
            this.radioTc.TabIndex = 31;
            this.radioTc.TabStop = true;
            this.radioTc.Text = "T.C. No";
            this.radioTc.UseVisualStyleBackColor = true;
            this.radioTc.CheckedChanged += new System.EventHandler(this.radioTc_CheckedChanged);
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrele.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiltrele.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrele.Location = new System.Drawing.Point(128, 103);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(222, 43);
            this.btnFiltrele.TabIndex = 28;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(64, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Bitiş T.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Başlangıç T.:";
            // 
            // dtBitis
            // 
            this.dtBitis.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Location = new System.Drawing.Point(128, 71);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(222, 26);
            this.dtBitis.TabIndex = 25;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Location = new System.Drawing.Point(128, 33);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(222, 26);
            this.dtBaslangic.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ara:";
            // 
            // txtAra
            // 
            this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(51, 69);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(112, 20);
            this.txtAra.TabIndex = 18;
            this.txtAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAra_KeyPress);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAll.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectAll.Location = new System.Drawing.Point(4, 176);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(112, 28);
            this.btnSelectAll.TabIndex = 35;
            this.btnSelectAll.Text = "Tümünü Seç";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(122, 176);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(138, 28);
            this.btnOnayla.TabIndex = 36;
            this.btnOnayla.Text = "Seçilenleri Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // radioHepsi
            // 
            this.radioHepsi.AutoSize = true;
            this.radioHepsi.Checked = true;
            this.radioHepsi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioHepsi.Location = new System.Drawing.Point(389, 31);
            this.radioHepsi.Name = "radioHepsi";
            this.radioHepsi.Size = new System.Drawing.Size(69, 25);
            this.radioHepsi.TabIndex = 37;
            this.radioHepsi.TabStop = true;
            this.radioHepsi.Text = "Hepsi";
            this.radioHepsi.UseVisualStyleBackColor = true;
            this.radioHepsi.CheckedChanged += new System.EventHandler(this.radioHepsi_CheckedChanged);
            // 
            // radioOnaylandi
            // 
            this.radioOnaylandi.AutoSize = true;
            this.radioOnaylandi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioOnaylandi.Location = new System.Drawing.Point(389, 56);
            this.radioOnaylandi.Name = "radioOnaylandi";
            this.radioOnaylandi.Size = new System.Drawing.Size(109, 25);
            this.radioOnaylandi.TabIndex = 38;
            this.radioOnaylandi.Text = "Onaylandı";
            this.radioOnaylandi.UseVisualStyleBackColor = true;
            // 
            // radioOnaylanmamis
            // 
            this.radioOnaylanmamis.AutoSize = true;
            this.radioOnaylanmamis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioOnaylanmamis.Location = new System.Drawing.Point(389, 81);
            this.radioOnaylanmamis.Name = "radioOnaylanmamis";
            this.radioOnaylanmamis.Size = new System.Drawing.Size(145, 25);
            this.radioOnaylanmamis.TabIndex = 38;
            this.radioOnaylanmamis.Text = "Onaylanmamış";
            this.radioOnaylanmamis.UseVisualStyleBackColor = true;
            // 
            // grpAra
            // 
            this.grpAra.Controls.Add(this.radioTc);
            this.grpAra.Controls.Add(this.txtAra);
            this.grpAra.Controls.Add(this.label1);
            this.grpAra.Controls.Add(this.radioAdSoyad);
            this.grpAra.Controls.Add(this.btnAra);
            this.grpAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAra.Location = new System.Drawing.Point(4, 5);
            this.grpAra.Name = "grpAra";
            this.grpAra.Size = new System.Drawing.Size(192, 158);
            this.grpAra.TabIndex = 39;
            this.grpAra.TabStop = false;
            this.grpAra.Text = "Arama";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtBaslangic);
            this.groupBox1.Controls.Add(this.radioOnaylanmamis);
            this.groupBox1.Controls.Add(this.dtBitis);
            this.groupBox1.Controls.Add(this.radioOnaylandi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioHepsi);
            this.groupBox1.Controls.Add(this.btnFiltrele);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(202, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 158);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtreleme";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioHepsi1
            // 
            this.radioHepsi1.AutoSize = true;
            this.radioHepsi1.Checked = true;
            this.radioHepsi1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioHepsi1.Location = new System.Drawing.Point(448, 180);
            this.radioHepsi1.Name = "radioHepsi1";
            this.radioHepsi1.Size = new System.Drawing.Size(69, 25);
            this.radioHepsi1.TabIndex = 41;
            this.radioHepsi1.TabStop = true;
            this.radioHepsi1.Text = "Hepsi";
            this.radioHepsi1.UseVisualStyleBackColor = true;
            this.radioHepsi1.CheckedChanged += new System.EventHandler(this.radioHepsi1_CheckedChanged);
            // 
            // radioOnaylandi1
            // 
            this.radioOnaylandi1.AutoSize = true;
            this.radioOnaylandi1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioOnaylandi1.Location = new System.Drawing.Point(523, 180);
            this.radioOnaylandi1.Name = "radioOnaylandi1";
            this.radioOnaylandi1.Size = new System.Drawing.Size(109, 25);
            this.radioOnaylandi1.TabIndex = 42;
            this.radioOnaylandi1.Text = "Onaylandı";
            this.radioOnaylandi1.UseVisualStyleBackColor = true;
            this.radioOnaylandi1.CheckedChanged += new System.EventHandler(this.radioOnaylandi1_CheckedChanged);
            // 
            // radioOnaylanmamis1
            // 
            this.radioOnaylanmamis1.AutoSize = true;
            this.radioOnaylanmamis1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioOnaylanmamis1.Location = new System.Drawing.Point(638, 180);
            this.radioOnaylanmamis1.Name = "radioOnaylanmamis1";
            this.radioOnaylanmamis1.Size = new System.Drawing.Size(145, 25);
            this.radioOnaylanmamis1.TabIndex = 43;
            this.radioOnaylanmamis1.Text = "Onaylanmamış";
            this.radioOnaylanmamis1.UseVisualStyleBackColor = true;
            this.radioOnaylanmamis1.CheckedChanged += new System.EventHandler(this.radioOnaylanmamis1_CheckedChanged);
            // 
            // izinOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.radioOnaylanmamis1);
            this.Controls.Add(this.radioOnaylandi1);
            this.Controls.Add(this.radioHepsi1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAra);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.drpFiltre);
            this.MinimumSize = new System.Drawing.Size(800, 0);
            this.Name = "izinOnay";
            this.Size = new System.Drawing.Size(800, 740);
            this.Load += new System.EventHandler(this.izinOnay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drpFiltre)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpAra.ResumeLayout(false);
            this.grpAra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView drpFiltre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sec;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.RadioButton radioAdSoyad;
        private System.Windows.Forms.RadioButton radioTc;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iziniOnaylaToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioHepsi;
        private System.Windows.Forms.RadioButton radioOnaylandi;
        private System.Windows.Forms.RadioButton radioOnaylanmamis;
        private System.Windows.Forms.GroupBox grpAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioHepsi1;
        private System.Windows.Forms.RadioButton radioOnaylandi1;
        private System.Windows.Forms.RadioButton radioOnaylanmamis1;
    }
}
