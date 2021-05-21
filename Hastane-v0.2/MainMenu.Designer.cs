namespace Hastane_v0._2
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ustPanel = new System.Windows.Forms.Panel();
            this.lblPoli = new System.Windows.Forms.Label();
            this.lblsaat = new System.Windows.Forms.Label();
            this.lbltarihyaz = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.solPanel = new System.Windows.Forms.Panel();
            this.btnPoli = new System.Windows.Forms.Button();
            this.btnizinOnay = new System.Windows.Forms.Button();
            this.btnGorevli = new System.Windows.Forms.Button();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.panelStick = new System.Windows.Forms.Panel();
            this.btnHastaIslem = new System.Windows.Forms.Button();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.btnRandevular = new System.Windows.Forms.Button();
            this.grpGorevli = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblYetki = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.drPanel = new System.Windows.Forms.Panel();
            this.btnIzin = new System.Windows.Forms.Button();
            this.btnAyar = new System.Windows.Forms.Button();
            this.panelStick2 = new System.Windows.Forms.Panel();
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnMuayene = new System.Windows.Forms.Button();
            this.btnDrRandevu = new System.Windows.Forms.Button();
            this.ustPanel.SuspendLayout();
            this.solPanel.SuspendLayout();
            this.grpGorevli.SuspendLayout();
            this.drPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ustPanel
            // 
            this.ustPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ustPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(181)))), ((int)(((byte)(122)))));
            this.ustPanel.Controls.Add(this.lblPoli);
            this.ustPanel.Controls.Add(this.lblsaat);
            this.ustPanel.Controls.Add(this.lbltarihyaz);
            this.ustPanel.Controls.Add(this.btnMin);
            this.ustPanel.Controls.Add(this.btnSize);
            this.ustPanel.Controls.Add(this.btnClose);
            this.ustPanel.Location = new System.Drawing.Point(0, 0);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(1228, 50);
            this.ustPanel.TabIndex = 0;
            this.ustPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ustPanel_MouseDown);
            this.ustPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ustPanel_MouseMove);
            this.ustPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ustPanel_MouseUp);
            // 
            // lblPoli
            // 
            this.lblPoli.AutoSize = true;
            this.lblPoli.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPoli.ForeColor = System.Drawing.Color.White;
            this.lblPoli.Location = new System.Drawing.Point(582, 14);
            this.lblPoli.Name = "lblPoli";
            this.lblPoli.Size = new System.Drawing.Size(25, 22);
            this.lblPoli.TabIndex = 5;
            this.lblPoli.Text = "...";
            this.lblPoli.Visible = false;
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsaat.ForeColor = System.Drawing.Color.White;
            this.lblsaat.Location = new System.Drawing.Point(296, 17);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(65, 22);
            this.lblsaat.TabIndex = 4;
            this.lblsaat.Text = "label2";
            // 
            // lbltarihyaz
            // 
            this.lbltarihyaz.AutoSize = true;
            this.lbltarihyaz.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltarihyaz.ForeColor = System.Drawing.Color.White;
            this.lbltarihyaz.Location = new System.Drawing.Point(12, 17);
            this.lbltarihyaz.Name = "lbltarihyaz";
            this.lbltarihyaz.Size = new System.Drawing.Size(65, 22);
            this.lbltarihyaz.TabIndex = 3;
            this.lbltarihyaz.Text = "label1";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackgroundImage = global::Hastane_v0._2.Properties.Resources.min;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(1081, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 50);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSize
            // 
            this.btnSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSize.BackgroundImage = global::Hastane_v0._2.Properties.Resources.size;
            this.btnSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSize.FlatAppearance.BorderSize = 0;
            this.btnSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSize.Location = new System.Drawing.Point(1128, 0);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(50, 50);
            this.btnSize.TabIndex = 1;
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::Hastane_v0._2.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1176, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // solPanel
            // 
            this.solPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.solPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(193)))), ((int)(((byte)(177)))));
            this.solPanel.Controls.Add(this.btnPoli);
            this.solPanel.Controls.Add(this.btnizinOnay);
            this.solPanel.Controls.Add(this.btnGorevli);
            this.solPanel.Controls.Add(this.btnDoktor);
            this.solPanel.Controls.Add(this.panelStick);
            this.solPanel.Controls.Add(this.btnHastaIslem);
            this.solPanel.Controls.Add(this.btnRandevuAl);
            this.solPanel.Controls.Add(this.btnRandevular);
            this.solPanel.Location = new System.Drawing.Point(0, 50);
            this.solPanel.Name = "solPanel";
            this.solPanel.Size = new System.Drawing.Size(200, 751);
            this.solPanel.TabIndex = 1;
            this.solPanel.Visible = false;
            // 
            // btnPoli
            // 
            this.btnPoli.FlatAppearance.BorderSize = 0;
            this.btnPoli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoli.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPoli.Location = new System.Drawing.Point(0, 294);
            this.btnPoli.Name = "btnPoli";
            this.btnPoli.Size = new System.Drawing.Size(192, 50);
            this.btnPoli.TabIndex = 8;
            this.btnPoli.Text = "Poliklinik İşlemleri";
            this.btnPoli.UseVisualStyleBackColor = true;
            this.btnPoli.Visible = false;
            this.btnPoli.Click += new System.EventHandler(this.btnPoli_Click);
            // 
            // btnizinOnay
            // 
            this.btnizinOnay.FlatAppearance.BorderSize = 0;
            this.btnizinOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnizinOnay.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnizinOnay.Location = new System.Drawing.Point(0, 245);
            this.btnizinOnay.Name = "btnizinOnay";
            this.btnizinOnay.Size = new System.Drawing.Size(192, 50);
            this.btnizinOnay.TabIndex = 7;
            this.btnizinOnay.Text = "İzin Onay";
            this.btnizinOnay.UseVisualStyleBackColor = true;
            this.btnizinOnay.Visible = false;
            this.btnizinOnay.Click += new System.EventHandler(this.btnizinOnay_Click);
            // 
            // btnGorevli
            // 
            this.btnGorevli.FlatAppearance.BorderSize = 0;
            this.btnGorevli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorevli.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevli.Location = new System.Drawing.Point(0, 196);
            this.btnGorevli.Name = "btnGorevli";
            this.btnGorevli.Size = new System.Drawing.Size(192, 50);
            this.btnGorevli.TabIndex = 6;
            this.btnGorevli.Text = "Görevli İşlemleri";
            this.btnGorevli.UseVisualStyleBackColor = true;
            this.btnGorevli.Visible = false;
            this.btnGorevli.Click += new System.EventHandler(this.btnGorevli_Click);
            // 
            // btnDoktor
            // 
            this.btnDoktor.FlatAppearance.BorderSize = 0;
            this.btnDoktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktor.Location = new System.Drawing.Point(0, 147);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(192, 50);
            this.btnDoktor.TabIndex = 5;
            this.btnDoktor.Text = "Doktor İşlemleri";
            this.btnDoktor.UseVisualStyleBackColor = true;
            this.btnDoktor.Visible = false;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // panelStick
            // 
            this.panelStick.BackColor = System.Drawing.SystemColors.Control;
            this.panelStick.Location = new System.Drawing.Point(192, 0);
            this.panelStick.Name = "panelStick";
            this.panelStick.Size = new System.Drawing.Size(8, 50);
            this.panelStick.TabIndex = 2;
            // 
            // btnHastaIslem
            // 
            this.btnHastaIslem.FlatAppearance.BorderSize = 0;
            this.btnHastaIslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaIslem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaIslem.Location = new System.Drawing.Point(0, 98);
            this.btnHastaIslem.Name = "btnHastaIslem";
            this.btnHastaIslem.Size = new System.Drawing.Size(192, 50);
            this.btnHastaIslem.TabIndex = 4;
            this.btnHastaIslem.Text = "Hasta İşlemleri";
            this.btnHastaIslem.UseVisualStyleBackColor = true;
            this.btnHastaIslem.Click += new System.EventHandler(this.btnHastaIslem_Click);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.FlatAppearance.BorderSize = 0;
            this.btnRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuAl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuAl.Location = new System.Drawing.Point(0, 49);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(192, 50);
            this.btnRandevuAl.TabIndex = 3;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // btnRandevular
            // 
            this.btnRandevular.FlatAppearance.BorderSize = 0;
            this.btnRandevular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevular.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevular.Location = new System.Drawing.Point(0, 0);
            this.btnRandevular.Name = "btnRandevular";
            this.btnRandevular.Size = new System.Drawing.Size(192, 50);
            this.btnRandevular.TabIndex = 2;
            this.btnRandevular.Text = "Randevular";
            this.btnRandevular.UseVisualStyleBackColor = true;
            this.btnRandevular.Click += new System.EventHandler(this.btnRandevular_Click);
            // 
            // grpGorevli
            // 
            this.grpGorevli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGorevli.BackColor = System.Drawing.Color.Transparent;
            this.grpGorevli.Controls.Add(this.btnCikis);
            this.grpGorevli.Controls.Add(this.lblYetki);
            this.grpGorevli.Controls.Add(this.lblAdSoyad);
            this.grpGorevli.Controls.Add(this.btnGiris);
            this.grpGorevli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpGorevli.Location = new System.Drawing.Point(1015, 56);
            this.grpGorevli.Name = "grpGorevli";
            this.grpGorevli.Size = new System.Drawing.Size(200, 184);
            this.grpGorevli.TabIndex = 2;
            this.grpGorevli.TabStop = false;
            this.grpGorevli.Text = "Görevli";
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(6, 149);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(188, 29);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Visible = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Location = new System.Drawing.Point(12, 108);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(57, 21);
            this.lblYetki.TabIndex = 2;
            this.lblYetki.Text = "label2";
            this.lblYetki.Visible = false;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(12, 62);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(57, 21);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "label1";
            this.lblAdSoyad.Visible = false;
            // 
            // btnGiris
            // 
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(6, 19);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(188, 29);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(199, 50);
            this.panel1.MinimumSize = new System.Drawing.Size(800, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 719);
            this.panel1.TabIndex = 3;
            // 
            // drPanel
            // 
            this.drPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.drPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(193)))), ((int)(((byte)(177)))));
            this.drPanel.Controls.Add(this.btnIzin);
            this.drPanel.Controls.Add(this.btnAyar);
            this.drPanel.Controls.Add(this.panelStick2);
            this.drPanel.Controls.Add(this.btnHasta);
            this.drPanel.Controls.Add(this.btnMuayene);
            this.drPanel.Controls.Add(this.btnDrRandevu);
            this.drPanel.Location = new System.Drawing.Point(0, 50);
            this.drPanel.Name = "drPanel";
            this.drPanel.Size = new System.Drawing.Size(200, 751);
            this.drPanel.TabIndex = 7;
            this.drPanel.Visible = false;
            // 
            // btnIzin
            // 
            this.btnIzin.FlatAppearance.BorderSize = 0;
            this.btnIzin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzin.Location = new System.Drawing.Point(0, 196);
            this.btnIzin.Name = "btnIzin";
            this.btnIzin.Size = new System.Drawing.Size(192, 50);
            this.btnIzin.TabIndex = 6;
            this.btnIzin.Text = "İzin İşlemleri";
            this.btnIzin.UseVisualStyleBackColor = true;
            this.btnIzin.Click += new System.EventHandler(this.btnIzin_Click);
            // 
            // btnAyar
            // 
            this.btnAyar.FlatAppearance.BorderSize = 0;
            this.btnAyar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyar.Location = new System.Drawing.Point(0, 147);
            this.btnAyar.Name = "btnAyar";
            this.btnAyar.Size = new System.Drawing.Size(192, 50);
            this.btnAyar.TabIndex = 5;
            this.btnAyar.Text = "Ayarlar";
            this.btnAyar.UseVisualStyleBackColor = true;
            this.btnAyar.Click += new System.EventHandler(this.btnAyar_Click);
            // 
            // panelStick2
            // 
            this.panelStick2.BackColor = System.Drawing.SystemColors.Control;
            this.panelStick2.Location = new System.Drawing.Point(192, 0);
            this.panelStick2.Name = "panelStick2";
            this.panelStick2.Size = new System.Drawing.Size(8, 50);
            this.panelStick2.TabIndex = 2;
            // 
            // btnHasta
            // 
            this.btnHasta.FlatAppearance.BorderSize = 0;
            this.btnHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHasta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHasta.Location = new System.Drawing.Point(0, 98);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(192, 50);
            this.btnHasta.TabIndex = 4;
            this.btnHasta.Text = "Hastalar";
            this.btnHasta.UseVisualStyleBackColor = true;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnMuayene
            // 
            this.btnMuayene.FlatAppearance.BorderSize = 0;
            this.btnMuayene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuayene.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuayene.Location = new System.Drawing.Point(0, 49);
            this.btnMuayene.Name = "btnMuayene";
            this.btnMuayene.Size = new System.Drawing.Size(192, 50);
            this.btnMuayene.TabIndex = 3;
            this.btnMuayene.Text = "Muayene";
            this.btnMuayene.UseVisualStyleBackColor = true;
            this.btnMuayene.Click += new System.EventHandler(this.btnMuayene_Click);
            // 
            // btnDrRandevu
            // 
            this.btnDrRandevu.FlatAppearance.BorderSize = 0;
            this.btnDrRandevu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrRandevu.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDrRandevu.Location = new System.Drawing.Point(0, 0);
            this.btnDrRandevu.Name = "btnDrRandevu";
            this.btnDrRandevu.Size = new System.Drawing.Size(192, 50);
            this.btnDrRandevu.TabIndex = 2;
            this.btnDrRandevu.Text = "Randevular";
            this.btnDrRandevu.UseVisualStyleBackColor = true;
            this.btnDrRandevu.Click += new System.EventHandler(this.btnDrRandevu_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hastane_v0._2.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(1227, 786);
            this.ControlBox = false;
            this.Controls.Add(this.grpGorevli);
            this.Controls.Add(this.ustPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.solPanel);
            this.Controls.Add(this.drPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ustPanel.ResumeLayout(false);
            this.ustPanel.PerformLayout();
            this.solPanel.ResumeLayout(false);
            this.grpGorevli.ResumeLayout(false);
            this.grpGorevli.PerformLayout();
            this.drPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ustPanel;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelStick;
        public System.Windows.Forms.Panel solPanel;
        public System.Windows.Forms.Button btnRandevular;
        public System.Windows.Forms.Button btnHastaIslem;
        public System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.GroupBox grpGorevli;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Label lbltarihyaz;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btnDoktor;
        public System.Windows.Forms.Button btnGorevli;
        public System.Windows.Forms.Panel drPanel;
        public System.Windows.Forms.Button btnIzin;
        public System.Windows.Forms.Button btnAyar;
        public System.Windows.Forms.Button btnHasta;
        public System.Windows.Forms.Button btnMuayene;
        public System.Windows.Forms.Button btnDrRandevu;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panelStick2;
        public System.Windows.Forms.Button btnPoli;
        public System.Windows.Forms.Button btnizinOnay;
        private System.Windows.Forms.Label lblPoli;
    }
}

