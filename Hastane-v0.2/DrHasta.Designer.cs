namespace Hastane_v0._2
{
    partial class DrHasta
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
            this.btnAra = new System.Windows.Forms.Button();
            this.radioAdSoyad = new System.Windows.Forms.RadioButton();
            this.radioTc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(321, 36);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(112, 43);
            this.btnAra.TabIndex = 22;
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
            this.radioAdSoyad.TabIndex = 21;
            this.radioAdSoyad.TabStop = true;
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
            this.radioTc.TabIndex = 20;
            this.radioTc.TabStop = true;
            this.radioTc.Text = "T.C. No";
            this.radioTc.UseVisualStyleBackColor = true;
            this.radioTc.CheckedChanged += new System.EventHandler(this.radioTc_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ara:";
            // 
            // txtAra
            // 
            this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(52, 58);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(239, 20);
            this.txtAra.TabIndex = 18;
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 627);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // DrHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.radioAdSoyad);
            this.Controls.Add(this.radioTc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(800, 0);
            this.Name = "DrHasta";
            this.Size = new System.Drawing.Size(800, 740);
            this.Load += new System.EventHandler(this.DrHasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.RadioButton radioAdSoyad;
        private System.Windows.Forms.RadioButton radioTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
