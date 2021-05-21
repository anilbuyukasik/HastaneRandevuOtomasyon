using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
namespace Hastane_v0._2
{
    public partial class Muayene : UserControl
    {
        public Muayene(string dr)
        {
            InitializeComponent();
            dr_id = dr.ToString();
        }
        public string dr_id, r_id, adsoyad, h_tc, cinsiyet, h_yasi, m_id, id, h_tc2, hasta, yas, cins, doktor, pol, tarih, sikayet, not, tani, oneri, ilac;
        SqlBaglanti bgl = new SqlBaglanti();
        private void Muayene_Load(object sender, EventArgs e)
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
            yukle();
        }
        void yukle()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select r_id as 'RANDEVO NO',(h.h_ad+' '+h.h_soyad) as 'HASTA',h.tcno as 'HASTA T.C',h.cinsiyet as 'CİNSİYET',DATEDIFF(YEAR,h.dtarihi,GETDATE()) as 'HASTA YAŞI',tarih as 'TARİH',saat as 'SAAT', (g.ad+ ' '+g.soyad) as 'GÖREVLİ',drm.durum from randevu r join hastalar h on r.hasta=h.h_id join doktorlar d on r.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id join gorevliler g on r.gorevli=g.id join durumlar drm on r.durum=drm.id where  r.doktor=" + dr_id + " and tarih=CONVERT(date,GETDATE()) and r.durum !=8 order by tarih", bgl.baglanti());

            DataSet ds = new DataSet();
            sda.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            bgl.baglanti().Close();
        }
        private void btnRandevular_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            if (panel1.Visible) panel1.Visible = false;
            else panel1.Visible = true;
            
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            r_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            adsoyad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            h_tc = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cinsiyet = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            h_yasi = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            panel1.Visible = false;
            txtRandevuID.Text = r_id.ToString();
            txtTc.Text = h_tc.ToString();
            txtAdSoyad.Text = adsoyad.ToString();
            txtCins.Text = cinsiyet.ToString();
            txtYas.Text = h_yasi.ToString();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void txtIlac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstilaclar.Items.Add(txtIlac.Text);
                txtIlac.ResetText();
            }
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (txtRandevuID.Text != "" && txtTc.Text != "" && txtAdSoyad.Text != "" && txtCins.Text != "" && txtYas.Text != "" && txtSikayet.Text != "" && rtxtMuayene.Text != "" && txtTani.Text != "" && rtxtOneri.Text != "")
            {
                DialogResult onay = MetroFramework.MetroMessageBox.Show(this,"Muayeneyi tamamlamak istediğine emin misin?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay==DialogResult.Yes)
                {
                    string ilaclar = "";
                    if (lstilaclar.Items.Count > 0)
                    {
                        for (int i = 0; i < lstilaclar.Items.Count; i++)
                        {
                            ilaclar += lstilaclar.Items[i].ToString() + ",";
                        }
                        ilaclar = ilaclar.Substring(0, ilaclar.Length - 1);
                    }
                    else ilaclar = "Yok";

                    SqlCommand cmd = new SqlCommand("insert into muayene (randevu,sikayet,m_notu,tani,oneri,ilac) values(@randevu,@sikayet,@not,@tani,@oneri,@ilac); select SCOPE_IDENTITY();", bgl.baglanti());
                    cmd.Parameters.AddWithValue("@randevu", txtRandevuID.Text);
                    cmd.Parameters.AddWithValue("@sikayet", txtSikayet.Text);
                    cmd.Parameters.AddWithValue("@not", rtxtMuayene.Text);
                    cmd.Parameters.AddWithValue("@tani", txtTani.Text);
                    cmd.Parameters.AddWithValue("@oneri", rtxtOneri.Text);
                    cmd.Parameters.AddWithValue("@ilac", ilaclar);
                    m_id = cmd.ExecuteScalar().ToString();
                    cmd.Dispose();
                    cmd = new SqlCommand("update randevu set durum=6 where r_id=" + txtRandevuID.Text, bgl.baglanti());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MetroFramework.MetroMessageBox.Show(this,"Muayene işlemi tamamlandı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult yazdir = MetroFramework.MetroMessageBox.Show(this, "Muayene bilgilerini yazdırmak ister misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (yazdir == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("select id,tcno,(h_ad+' '+h_soyad) as hasta,DATEDIFF(YEAR,dtarihi,GETDATE()) as yas,h.cinsiyet,(d_ad+' '+d_soyad) as doktor,p_adi,tarih,sikayet,m_notu,tani,oneri,ilac from muayene m join randevu r on m.randevu=r.r_id join hastalar h on r.hasta=h.h_id join doktorlar d on r.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id where id=" + m_id, bgl.baglanti());
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            id = dr["id"].ToString();
                            h_tc2 = dr["tcno"].ToString();
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
                    }

                    temizle();
                }
                
            }
            else MetroFramework.MetroMessageBox.Show(this,"Gerekli alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void temizle()
        {
            txtRandevuID.ResetText();
            txtTc.Text = "";
            txtAdSoyad.ResetText();
            txtCins.ResetText();
            txtYas.ResetText();
            txtSikayet.ResetText(); 
            rtxtMuayene.ResetText();
            txtTani.ResetText();
            txtIlac.ResetText();
            rtxtOneri.ResetText();
            lstilaclar.Items.Clear();
            btnTamamla.Enabled = true;
            btnGuncelle.Enabled = false;
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            if (h_tc != null)
            {
                MuayeneGecmis mg = new MuayeneGecmis(h_tc);
                mg.Show();
            }
            else MetroFramework.MetroMessageBox.Show(this,"Hasta seçilmedi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void txtRandevuID_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select randevu,tarih,sikayet,m_notu,tani,oneri,ilac from muayene m join randevu r on m.randevu=r.r_id join hastalar h on r.hasta=h.h_id where randevu=" + r_id, bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtSikayet.Text = dr["sikayet"].ToString();
                rtxtMuayene.Text = dr["m_notu"].ToString();
                txtTani.Text = dr["tani"].ToString();
                rtxtOneri.Text = dr["oneri"].ToString();
                string ilaclar = dr["ilac"].ToString();
                char[] c = { ',' };
                string[] ayir = ilaclar.Split(c, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < ayir.Length; i++)
                {
                    lstilaclar.Items.Add(ayir[i]);
                }
                btnTamamla.Enabled = false;
                btnGuncelle.Enabled = true;
            }
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
