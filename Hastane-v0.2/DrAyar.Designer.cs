namespace Hastane_v0._2
{
    partial class DrAyar
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
            this.lblEski = new System.Windows.Forms.Label();
            this.txtEski = new System.Windows.Forms.TextBox();
            this.txtYeni = new System.Windows.Forms.TextBox();
            this.lblYeniTekrar = new System.Windows.Forms.Label();
            this.txtYeniTekrar = new System.Windows.Forms.TextBox();
            this.lblYeniT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEski
            // 
            this.lblEski.AutoSize = true;
            this.lblEski.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEski.Location = new System.Drawing.Point(73, 84);
            this.lblEski.Name = "lblEski";
            this.lblEski.Size = new System.Drawing.Size(75, 21);
            this.lblEski.TabIndex = 0;
            this.lblEski.Text = "Eski Şifre:";
            // 
            // txtEski
            // 
            this.txtEski.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEski.Location = new System.Drawing.Point(154, 78);
            this.txtEski.MaxLength = 18;
            this.txtEski.Name = "txtEski";
            this.txtEski.PasswordChar = '*';
            this.txtEski.Size = new System.Drawing.Size(199, 27);
            this.txtEski.TabIndex = 1;
            // 
            // txtYeni
            // 
            this.txtYeni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeni.Location = new System.Drawing.Point(154, 154);
            this.txtYeni.MaxLength = 18;
            this.txtYeni.Name = "txtYeni";
            this.txtYeni.PasswordChar = '*';
            this.txtYeni.Size = new System.Drawing.Size(199, 27);
            this.txtYeni.TabIndex = 3;
            // 
            // lblYeniTekrar
            // 
            this.lblYeniTekrar.AutoSize = true;
            this.lblYeniTekrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniTekrar.Location = new System.Drawing.Point(65, 160);
            this.lblYeniTekrar.Name = "lblYeniTekrar";
            this.lblYeniTekrar.Size = new System.Drawing.Size(83, 21);
            this.lblYeniTekrar.TabIndex = 2;
            this.lblYeniTekrar.Text = "Yeni Şifre:";
            // 
            // txtYeniTekrar
            // 
            this.txtYeniTekrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniTekrar.Location = new System.Drawing.Point(154, 211);
            this.txtYeniTekrar.MaxLength = 18;
            this.txtYeniTekrar.Name = "txtYeniTekrar";
            this.txtYeniTekrar.PasswordChar = '*';
            this.txtYeniTekrar.Size = new System.Drawing.Size(199, 27);
            this.txtYeniTekrar.TabIndex = 5;
            // 
            // lblYeniT
            // 
            this.lblYeniT.AutoSize = true;
            this.lblYeniT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniT.Location = new System.Drawing.Point(14, 217);
            this.lblYeniT.Name = "lblYeniT";
            this.lblYeniT.Size = new System.Drawing.Size(134, 21);
            this.lblYeniT.TabIndex = 4;
            this.lblYeniT.Text = "Yeni Şifre Tekrar:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(154, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "Değiştir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtYeniTekrar);
            this.Controls.Add(this.lblYeniT);
            this.Controls.Add(this.txtYeni);
            this.Controls.Add(this.lblYeniTekrar);
            this.Controls.Add(this.txtEski);
            this.Controls.Add(this.lblEski);
            this.MinimumSize = new System.Drawing.Size(800, 0);
            this.Name = "DrAyar";
            this.Size = new System.Drawing.Size(800, 740);
            this.Load += new System.EventHandler(this.DrAyar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEski;
        private System.Windows.Forms.TextBox txtEski;
        private System.Windows.Forms.TextBox txtYeni;
        private System.Windows.Forms.Label lblYeniTekrar;
        private System.Windows.Forms.TextBox txtYeniTekrar;
        private System.Windows.Forms.Label lblYeniT;
        private System.Windows.Forms.Button button1;
    }
}
