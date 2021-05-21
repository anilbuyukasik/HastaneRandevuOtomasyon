using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_v0._2
{
    public partial class MainMenu : Form
    {
        int mov;
        int movX;
        int movY;
        public MainMenu()
        {
            InitializeComponent();
        }
        public string gorevli = "";
        public string doktor;
        
            Login lg;
            SqlBaglanti bgl = new SqlBaglanti();
        private void MainMenu_Load(object sender, EventArgs e)
        {
            lg = new Login();
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
            this.WindowState = FormWindowState.Maximized;
            timer1.Enabled = true;
            panelStick.Height = btnRandevular.Height;
            panelStick.Top = btnRandevular.Top;
            panel1.Visible = false;

            SqlCommand cmd = new SqlCommand("update randevu set durum=7 where tarih<'" + DateTime.Now.ToString("yyy-M-dd")+"' and durum=5", bgl.baglanti());
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            
            
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            lg.durum = "false";
            lg.StartPosition = FormStartPosition.Manual;
            lg.Left = 200;
            lg.Top = 50;
            lg.ShowDialog();
            if (bool.Parse(lg.durum)==true)
            {
                panel1.Visible = true;
                lblAdSoyad.Visible = true; lblAdSoyad.Text = lg.adSoyad;
                lblYetki.Visible = true; lblYetki.Text = lg.yetki;
                btnCikis.Visible = true;
                btnGiris.Visible = false;
                
                if (lg.yetki != "Doktor")
                {
                    solPanel.Visible = true;
                    panel1.Controls.Clear();
                    Randevular rnd = new Randevular();
                    panel1.Controls.Add(rnd);
                    rnd.Dock = DockStyle.Fill;
                    
                    if (lg.yetki=="Yönetici")
                    {
                        btnDoktor.Visible = true;
                        btnGorevli.Visible = true;
                        btnAyar.Visible = true;
                        btnizinOnay.Visible = true;
                        btnPoli.Visible = true;
                    }
                }
                else
                {
                    drPanel.Visible = true;
                    panel1.Controls.Clear();
                    lblPoli.Visible = true;
                    lblPoli.Text = lg.poliklinik;
                    doktor = lg.id.ToString();
                    DrRandevu d = new DrRandevu(doktor);
                    panel1.Controls.Add(d);
                    d.Dock = DockStyle.Fill;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ustPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void ustPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void ustPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void btnRandevular_Click(object sender, EventArgs e)
        {
            panelStick.Height = btnRandevular.Height;
            panelStick.Top = btnRandevular.Top;

            panel1.Controls.Clear();
            Randevular rnd = new Randevular();
            panel1.Controls.Add(rnd);
            rnd.Dock = DockStyle.Fill;

        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            panelStick.Height = btnRandevuAl.Height;
            panelStick.Top = btnRandevuAl.Top;
            panel1.Controls.Clear();
            gorevli = lg.id.ToString();
            RandevuAl rndAl = new RandevuAl(gorevli);
            panel1.Controls.Add(rndAl);
            rndAl.Dock = DockStyle.Fill;

        }

        private void btnHastaIslem_Click(object sender, EventArgs e)
        {
            panelStick.Height = btnHastaIslem.Height;
            panelStick.Top = btnHastaIslem.Top;
            panel1.Controls.Clear();
            HastaIslem hst = new HastaIslem();
            panel1.Controls.Add(hst);
            hst.Dock = DockStyle.Fill;

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            lblPoli.Visible = false;
            lblAdSoyad.Visible = false;
            lblYetki.Visible = false;
            btnCikis.Visible = false;
            btnGiris.Visible = true;
            panelStick.Height = btnRandevular.Height;
            panelStick.Top = btnRandevular.Top;
            panelStick2.Height = btnDrRandevu.Height;
            panelStick2.Top = btnDrRandevu.Top;
            btnDoktor.Visible = false;
            panel1.Controls.Clear();
            panel1.Visible = false;
            btnGorevli.Visible = false;
            btnizinOnay.Visible = false;
            btnPoli.Visible = false;
            solPanel.Visible = false;
            drPanel.Visible = false;
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            var cultur = new System.Globalization.CultureInfo("tr-TR");
            var day = cultur.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);

            lbltarihyaz.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + day;
            lblsaat.Text = DateTime.Now.Hour + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second;

            if (Convert.ToInt32(DateTime.Now.Hour) > 17)
            {
                SqlCommand cmd = new SqlCommand("update randevu set durum=7 where tarih='" + DateTime.Now.ToString("yyyy-M-dd")+"' and durum=5", bgl.baglanti());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            panelStick.Top = btnDoktor.Top;
            panelStick.Height = btnDoktor.Height;
            panel1.Controls.Clear();
            DoktorIslem dr = new DoktorIslem();
            panel1.Controls.Add(dr);
            dr.Dock = DockStyle.Fill;

        }

        private void btnGorevli_Click(object sender, EventArgs e)
        {
            panelStick.Top = btnGorevli.Top;
            panelStick.Height = btnGorevli.Height;
            panel1.Controls.Clear();
            GorevliIslem grv = new GorevliIslem();
            panel1.Controls.Add(grv);
            grv.Dock = DockStyle.Fill;
        }

        private void btnMuayene_Click(object sender, EventArgs e)
        {
            panelStick2.Top = btnMuayene.Top;
            panelStick2.Height = btnMuayene.Height;
            panel1.Controls.Clear();
            doktor = lg.id.ToString();
            Muayene m = new Muayene(doktor);
            panel1.Controls.Add(m);
            m.Dock = DockStyle.Fill;
        }
        private void btnDrRandevu_Click(object sender, EventArgs e)
        {
            panelStick2.Top = btnDrRandevu.Top;
            panelStick2.Height = btnDrRandevu.Height;
            panel1.Controls.Clear();
            doktor = lg.id.ToString();
            DrRandevu d = new DrRandevu(doktor);
            panel1.Controls.Add(d);
            d.Dock = DockStyle.Fill;
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            panelStick2.Top = btnHasta.Top;
            panelStick2.Height = btnHasta.Height;
            panel1.Controls.Clear();
            doktor = lg.id.ToString();
            DrHasta dh = new DrHasta(doktor);
            panel1.Controls.Add(dh);
            dh.Dock = DockStyle.Fill;
        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            panelStick2.Top = btnAyar.Top;
            panelStick2.Height = btnAyar.Height;
            panel1.Controls.Clear();
            doktor = lg.id.ToString();
            DrAyar da = new DrAyar(doktor);
            panel1.Controls.Add(da);
            da.Dock = DockStyle.Fill;
        }

        private void btnIzin_Click(object sender, EventArgs e)
        {
            panelStick2.Top = btnIzin.Top;
            panelStick2.Height = btnIzin.Height;
            panel1.Controls.Clear();
            doktor = lg.id.ToString();
            izin iz = new izin(doktor);
            panel1.Controls.Add(iz);
            iz.Dock = DockStyle.Fill;
            
        }

        private void btnizinOnay_Click(object sender, EventArgs e)
        {
            panelStick.Top = btnizinOnay.Top;
            panelStick.Height = btnizinOnay.Height;
            panel1.Controls.Clear();
            izinOnay io = new izinOnay();
            panel1.Controls.Add(io);
            io.Dock = DockStyle.Fill;
        }

        private void btnPoli_Click(object sender, EventArgs e)
        {
            panelStick.Top = btnPoli.Top;
            panelStick.Height = btnPoli.Height;
            panel1.Controls.Clear();
            Poliklinikler pol = new Poliklinikler();
            panel1.Controls.Add(pol);
            pol.Dock = DockStyle.Fill;
        }


    }
}
