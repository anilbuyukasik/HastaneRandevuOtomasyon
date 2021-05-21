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
using System.Drawing.Printing;
namespace Hastane_v0._2
{
    public partial class MuayeneGecmis : Form
    {
        public MuayeneGecmis(string h_tc)
        {
            InitializeComponent();
            tc = h_tc.ToString();
        }
        int mov;
        int movX;
        int movY;
        SqlBaglanti bgl = new SqlBaglanti();
        public string tc;
        private void MuayeneGecmis_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.None;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(83, 195, 237);
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(196, 223, 186);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 16);


            dataGridView1.BackgroundColor = Color.FromArgb(97, 223, 252);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 53, 71);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            SqlDataAdapter sda = new SqlDataAdapter("select id,(d_ad+' '+d_soyad) as doktor,p_adi,tarih,sikayet,m_notu,tani,oneri,ilac from muayene m join randevu r on m.randevu=r.r_id join hastalar h on r.hasta=h.h_id join doktorlar d on r.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id where h.tcno=" + tc, bgl.baglanti());

            DataSet ds = new DataSet();
            sda.Fill(ds, "muayene");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            bgl.baglanti().Close();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ustPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string id, h_tc ,hasta, yas, cins, doktor, pol, tarih, sikayet, not, tani, oneri, ilac;
        private void muayeneBilgileriniYazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            SqlCommand cmd = new SqlCommand("select id,tcno,(h_ad+' '+h_soyad) as hasta,DATEDIFF(YEAR,dtarihi,GETDATE()) as yas,h.cinsiyet,(d_ad+' '+d_soyad) as doktor,p_adi,tarih,sikayet,m_notu,tani,oneri,ilac from muayene m join randevu r on m.randevu=r.r_id join hastalar h on r.hasta=h.h_id join doktorlar d on r.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id where id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString(), bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = dr["id"].ToString();
                h_tc = dr["tcno"].ToString();
                hasta = dr["hasta"].ToString();
                yas = dr["yas"].ToString();
                cins = dr["cinsiyet"].ToString();
                doktor = dr["doktor"].ToString();
                pol = dr["p_adi"].ToString();
                tarih = dr["tarih"].ToString();
                sikayet = dr["sikayet"].ToString();
                not = dr["m_notu"].ToString();
                tani = dr["tani"].ToString();
                oneri = dr["oneri"].ToString();
                ilac = dr["ilac"].ToString();
                
            }
            dr.Dispose();
            cmd.Dispose();

            PrintDocument myDoc = new PrintDocument();
            PrintPreviewDialog print_dlg = new PrintPreviewDialog();
            print_dlg.Document = printDocument1;
            print_dlg.ShowDialog();
            this.Close();

        }
        Font baslikk = new Font("Verdana", 15, FontStyle.Bold);
        Font altbaslikk = new Font("Verdana", 12, FontStyle.Bold);
        Font icerik = new Font("Verdana", 10);
        SolidBrush sbb = new SolidBrush(Color.Black);
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringFormat stt = new StringFormat();
            stt.Alignment = StringAlignment.Near;

            e.Graphics.DrawString("Muayene Bilgileri", baslikk, sbb, 20, 20, stt);


            e.Graphics.DrawString("Muayene No", altbaslikk, sbb, 100, 80, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 80, stt);
            e.Graphics.DrawString(id, altbaslikk, sbb, 320, 80, stt);

            e.Graphics.DrawString("Hasta Tc No", altbaslikk, sbb, 100, 110, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 110, stt);
            e.Graphics.DrawString(h_tc, altbaslikk, sbb, 320, 110, stt);

            e.Graphics.DrawString("Hasta Ad Soyad", altbaslikk, sbb, 100, 140, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 140, stt);
            e.Graphics.DrawString(hasta, altbaslikk, sbb, 320, 140, stt);

            e.Graphics.DrawString("Yaş", altbaslikk, sbb, 100, 170, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 170, stt);
            e.Graphics.DrawString(yas, altbaslikk, sbb, 320, 170, stt);

            e.Graphics.DrawString("Cinsiyet", altbaslikk, sbb, 100, 200, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 200, stt);
            e.Graphics.DrawString(cins, altbaslikk, sbb, 320, 200, stt);

            e.Graphics.DrawString("Poliklinik", altbaslikk, sbb, 100, 230, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 230, stt);
            e.Graphics.DrawString(pol, altbaslikk, sbb, 320, 230, stt);

            e.Graphics.DrawString("Doktor", altbaslikk, sbb, 100, 260, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 260, stt);
            e.Graphics.DrawString(doktor, altbaslikk, sbb, 320, 260, stt);

            e.Graphics.DrawString("Tarih", altbaslikk, sbb, 100, 290, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 290, stt);
            e.Graphics.DrawString(tarih, altbaslikk, sbb, 320, 290, stt);

            e.Graphics.DrawString("Şikayet", altbaslikk, sbb, 100, 320, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 320, stt);
            e.Graphics.DrawString(sikayet, altbaslikk, sbb, 320, 320, stt);

            e.Graphics.DrawString("Muayene Notu", altbaslikk, sbb, 100, 350, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 350, stt);
            e.Graphics.DrawString(not, altbaslikk, sbb, 320, 350, stt);

            e.Graphics.DrawString("Tanı", altbaslikk, sbb, 100, 380, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 380, stt);
            e.Graphics.DrawString(tani, altbaslikk, sbb, 320, 380, stt);

            e.Graphics.DrawString("Öneri", altbaslikk, sbb, 100, 410, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 410, stt);
            e.Graphics.DrawString(oneri, altbaslikk, sbb, 320, 410, stt);

            e.Graphics.DrawString("İlaçlar", altbaslikk, sbb, 100, 440, stt);
            e.Graphics.DrawString(":", altbaslikk, sbb, 300, 440, stt);
            e.Graphics.DrawString(ilac, altbaslikk, sbb, 320, 440, stt);



            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", altbaslikk, sbb, 20, 530, stt);
        }
    }
}
