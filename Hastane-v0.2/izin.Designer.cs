namespace Hastane_v0._2
{
    partial class izin
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
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.btnizinAl = new System.Windows.Forms.Button();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblizinler = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitis.Location = new System.Drawing.Point(90, 145);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(116, 21);
            this.lblBitis.TabIndex = 9;
            this.lblBitis.Text = "İzin bitiş tarihi:";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangic.Location = new System.Drawing.Point(44, 89);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(162, 21);
            this.lblBaslangic.TabIndex = 8;
            this.lblBaslangic.Text = "İzin başlangıç tarihi:";
            // 
            // btnizinAl
            // 
            this.btnizinAl.BackColor = System.Drawing.Color.ForestGreen;
            this.btnizinAl.FlatAppearance.BorderSize = 0;
            this.btnizinAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnizinAl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnizinAl.ForeColor = System.Drawing.Color.White;
            this.btnizinAl.Location = new System.Drawing.Point(212, 195);
            this.btnizinAl.Name = "btnizinAl";
            this.btnizinAl.Size = new System.Drawing.Size(200, 52);
            this.btnizinAl.TabIndex = 7;
            this.btnizinAl.Text = "İzin Al";
            this.btnizinAl.UseVisualStyleBackColor = false;
            this.btnizinAl.Click += new System.EventHandler(this.btnizinAl_Click);
            // 
            // dtBitis
            // 
            this.dtBitis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Location = new System.Drawing.Point(212, 139);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(200, 27);
            this.dtBitis.TabIndex = 6;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Location = new System.Drawing.Point(212, 83);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(200, 27);
            this.dtBaslangic.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 414);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblizinler
            // 
            this.lblizinler.AutoSize = true;
            this.lblizinler.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblizinler.Location = new System.Drawing.Point(3, 296);
            this.lblizinler.Name = "lblizinler";
            this.lblizinler.Size = new System.Drawing.Size(89, 24);
            this.lblizinler.TabIndex = 11;
            this.lblizinler.Text = "İzinlerim";
            // 
            // izin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.lblizinler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.btnizinAl);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.MinimumSize = new System.Drawing.Size(800, 0);
            this.Name = "izin";
            this.Size = new System.Drawing.Size(800, 740);
            this.Load += new System.EventHandler(this.izin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Button btnizinAl;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblizinler;
    }
}
