using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_v0._2
{
    public partial class RandevuOnay : Form
    {
       
        public RandevuOnay(string randevu_id,string tc,string ad,string soyad,string pol,string doktor,string tarih,string rnsaat)
        {
            InitializeComponent();
            rtc = tc.ToString();
            rad = ad.ToString();
            rsoyad = soyad.ToString();
            rpol = pol.ToString();
            rdoktor = doktor.ToString();
            rtarih = tarih.ToString();
            rnsaat1 = rnsaat.ToString();
            r_id = randevu_id.ToString();
            
        }
        public bool durum;
        public string r_id, rtc, rad, rsoyad, rpol, rdoktor, rtarih, rnsaat1;
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDocument myDoc = new PrintDocument();
            PrintPreviewDialog print_dlg = new PrintPreviewDialog();
            print_dlg.Document = printDocument1;
            print_dlg.ShowDialog();
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RandevuOnay_Load(object sender, EventArgs e)
        {
            lblTc.Text = rtc.ToString();
            lblAd.Text = rad.ToString();
            lblSoyad.Text = rsoyad.ToString();
            lblPol.Text = rpol.ToString();
            lblDr.Text = rdoktor.ToString();
            lblTarih.Text = rtarih.ToString();
            lblSaat.Text = rnsaat1.ToString();
            lblID.Text = r_id.ToString();
        }

        Font baslikk = new Font("Verdana", 15, FontStyle.Bold);
        Font altbaslikk = new Font("Verdana", 12, FontStyle.Bold);
        Font icerik = new Font("Verdana", 10);
        SolidBrush sbb = new SolidBrush(Color.Black);


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            StringFormat stt = new StringFormat();
            stt.Alignment = StringAlignment.Near;

            e.Graphics.DrawString("Randevu Bilgileri", baslikk, sbb, 20, 20, stt);


            e.Graphics.DrawString("Randevu No", altbaslikk, sbb, 100, 80, stt); 
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 80, stt); 
            e.Graphics.DrawString(r_id, altbaslikk, sbb, 320, 80, stt);

            e.Graphics.DrawString("Hasta Tc No", altbaslikk, sbb, 100, 110, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 110, stt); 
            e.Graphics.DrawString(rtc, altbaslikk, sbb, 320, 110, stt);

            e.Graphics.DrawString("Hasta Ad Soyad", altbaslikk, sbb, 100, 140, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 140, stt); 
            e.Graphics.DrawString(rad+" "+rsoyad, altbaslikk, sbb, 320, 140, stt);

            e.Graphics.DrawString("Poliklinik", altbaslikk, sbb, 100, 170, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 170, stt); 
            e.Graphics.DrawString(rpol, altbaslikk, sbb, 320, 170, stt);

            e.Graphics.DrawString("Doktor", altbaslikk, sbb, 100, 200, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 200, stt); 
            e.Graphics.DrawString(rdoktor, altbaslikk, sbb, 320, 200, stt);

            e.Graphics.DrawString("Randevu Tarihi", altbaslikk, sbb, 100, 230, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 230, stt); 
            e.Graphics.DrawString(rtarih, altbaslikk, sbb, 320, 230, stt);

            e.Graphics.DrawString("Randevu Saati", altbaslikk, sbb, 100, 260, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 260, stt); 
            e.Graphics.DrawString(rnsaat1, altbaslikk, sbb, 320, 260, stt);
            

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", altbaslikk, sbb, 20, 350, stt);
        }
    }
}
