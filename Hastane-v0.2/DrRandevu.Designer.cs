namespace Hastane_v0._2
{
    partial class DrRandevu
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
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.radioAdSoyad = new System.Windows.Forms.RadioButton();
            this.radioTc = new System.Windows.Forms.RadioButton();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblAra = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hastaGelmediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(685, 112);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(112, 24);
            this.btnTemizle.TabIndex = 35;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(52, 93);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(112, 43);
            this.btnAra.TabIndex = 34;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // radioAdSoyad
            // 
            this.radioAdSoyad.AutoSize = true;
            this.radioAdSoyad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioAdSoyad.Location = new System.Drawing.Point(52, 32);
            this.radioAdSoyad.Name = "radioAdSoyad";
            this.radioAdSoyad.Size = new System.Drawing.Size(87, 21);
            this.radioAdSoyad.TabIndex = 33;
            this.radioAdSoyad.Text = "Ad Soyad";
            this.radioAdSoyad.UseVisualStyleBackColor = true;
            this.radioAdSoyad.CheckedChanged += new System.EventHandler(this.radioAdSoyad_CheckedChanged);
            // 
            // radioTc
            // 
            this.radioTc.AutoSize = true;
            this.radioTc.Checked = true;
            this.radioTc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioTc.Location = new System.Drawing.Point(52, 9);
            this.radioTc.Name = "radioTc";
            this.radioTc.Size = new System.Drawing.Size(73, 21);
            this.radioTc.TabIndex = 32;
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
            this.btnFiltrele.Location = new System.Drawing.Point(649, 45);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(133, 43);
            this.btnFiltrele.TabIndex = 29;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitis.Location = new System.Drawing.Point(417, 25);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(58, 21);
            this.lblBitis.TabIndex = 28;
            this.lblBitis.Text = "Bitiş T.:";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangic.Location = new System.Drawing.Point(177, 24);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(104, 21);
            this.lblBaslangic.TabIndex = 27;
            this.lblBaslangic.Text = "Başlangıç T.:";
            // 
            // dtBitis
            // 
            this.dtBitis.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Location = new System.Drawing.Point(421, 52);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(222, 26);
            this.dtBitis.TabIndex = 26;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Location = new System.Drawing.Point(181, 52);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(222, 26);
            this.dtBaslangic.TabIndex = 25;
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAra.Location = new System.Drawing.Point(3, 58);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(43, 21);
            this.lblAra.TabIndex = 20;
            this.lblAra.Text = "Ara:";
            // 
            // txtAra
            // 
            this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(52, 58);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(112, 20);
            this.txtAra.TabIndex = 19;
            this.txtAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAra_KeyPress);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 589);
            this.dataGridView1.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaGelmediToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 26);
            // 
            // hastaGelmediToolStripMenuItem
            // 
            this.hastaGelmediToolStripMenuItem.Name = "hastaGelmediToolStripMenuItem";
            this.hastaGelmediToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hastaGelmediToolStripMenuItem.Text = "Hasta Gelmedi";
            // 
            // DrRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.radioAdSoyad);
            this.Controls.Add(this.radioTc);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(800, 0);
            this.Name = "DrRandevu";
            this.Size = new System.Drawing.Size(800, 740);
            this.Load += new System.EventHandler(this.DrRandevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.RadioButton radioAdSoyad;
        private System.Windows.Forms.RadioButton radioTc;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaGelmediToolStripMenuItem;
    }
}
