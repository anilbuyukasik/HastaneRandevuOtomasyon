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

namespace Hastane_v0._2
{
    public partial class Randevular : UserControl
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public Randevular()
        {
            InitializeComponent();
        }
        void yukle()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select r_id as 'RANDEVO NO',(h.h_ad+' '+h.h_soyad) as 'HASTA',h.tcno as 'HASTA T.C',p.p_adi as 'POLİKLİNİK',(d.d_ad+ ' '+d.d_soyad) as 'DOKTOR',tarih as 'TARİH',saat as 'SAAT', (g.ad+ ' '+g.soyad) as 'GÖREVLİ',drm.durum as 'DURUM' from randevu r join hastalar h on r.hasta=h.h_id join doktorlar d on r.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id join gorevliler g on r.gorevli=g.id join durumlar drm on r.durum=drm.id where tarih>=CONVERT(date,GETDATE()) order by tarih", bgl.baglanti());
            DataSet ds = new DataSet();
            sda.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            bgl.baglanti().Close();
        }
        private void Randevular_Load(object sender, EventArgs e)
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

            cBoxPoliklinik.Enabled = false;
            cBoxDoktor.Enabled = false;
            chkDr.Enabled = false;
            radioTc.Checked = true;


            yukle();
        }

        private void chkDr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDr.Checked)
            {
                cBoxDoktor.Enabled = true;
                SqlDataAdapter da = new SqlDataAdapter("select d_id, (d_ad+ ' '+d_soyad) as doktor from doktorlar where p_id=" + cBoxPoliklinik.SelectedValue, bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                cBoxDoktor.ValueMember = "d_id";
                cBoxDoktor.DisplayMember = "doktor";
                cBoxDoktor.DataSource = dt;
            }
            else
            {
                cBoxDoktor.Enabled = false;
                cBoxDoktor.DataSource = null;
            }
        }

        private void chkPol_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt;
            if (chkPol.Checked)
            {
                cBoxPoliklinik.Enabled = true;
                chkDr.Enabled = true;
                da = new SqlDataAdapter("select * from poliklinikler", bgl.baglanti());
                dt = new DataTable();
                da.Fill(dt);
                cBoxPoliklinik.ValueMember = "p_id";
                cBoxPoliklinik.DisplayMember = "p_adi";
                cBoxPoliklinik.DataSource = dt;

            }
            else
            {
                cBoxPoliklinik.Enabled = false;
                chkDr.Checked = false;
                chkDr.Enabled = false;
                cBoxPoliklinik.DataSource = null;
                cBoxDoktor.DataSource = null;

            }
        }

        private void cBoxPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxPoliklinik.DataSource!=null && chkDr.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("select d_id, (d_ad+ ' '+d_soyad) as doktor from doktorlar where p_id=" + cBoxPoliklinik.SelectedValue, bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                cBoxDoktor.ValueMember = "d_id";
                cBoxDoktor.DisplayMember = "doktor";
                cBoxDoktor.DataSource = dt;
            }

            
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            string sorgu = "select r_id as 'RANDEVO NO',(h.h_ad+' '+h.h_soyad) as 'HASTA',h.tcno as 'HASTA T.C',p.p_adi as 'POLİKLİNİK',(d.d_ad+ ' '+d.d_soyad) as 'DOKTOR',tarih as 'TARİH',saat as 'SAAT', (g.ad+ ' '+g.soyad) as 'GÖREVLİ',drm.durum as 'DURUM' from randevu r join hastalar h on r.hasta=h.h_id join doktorlar d on r.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id join gorevliler g on r.gorevli=g.id join durumlar drm on r.durum=drm.id  where";
            string kosul = " tarih between'" + dtBaslangic.Value.Date.ToString("yyyy-M-dd") + "' and '" + dtBitis.Value.Date.ToString("yyyy-M-dd") + "'";
            if (chkPol.Checked)
            {
                kosul += " and p.p_id=" + cBoxPoliklinik.SelectedValue;
            }
            if (chkDr.Checked)
            {
                kosul += " and d.d_id=" + cBoxDoktor.SelectedValue;
            }
            kosul += " order by tarih";
            sorgu += kosul;
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataSet ds = new DataSet();
            sda.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            bgl.baglanti().Close();

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            yukle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAra.Text != "") 
            {
                string sorgu = "select r_id as 'RANDEVO NO',(h.h_ad+' '+h.h_soyad) as 'HASTA',h.tcno as 'HASTA T.C',p.p_adi as 'POLİKLİNİK',(d.d_ad+ ' '+d.d_soyad) as 'DOKTOR',tarih as 'TARİH',saat as 'SAAT', (g.ad+ ' '+g.soyad) as 'GÖREVLİ',drm.durum as 'DURUM' from randevu r join hastalar h on r.hasta=h.h_id join doktorlar d on r.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id join gorevliler g on r.gorevli=g.id join durumlar drm on r.durum=drm.id  where ";
                string kosul = "";
                if (radioTc.Checked)
                {
                    kosul = " h.tcno='" + txtAra.Text + "'";
                }
                if (radioAdSoyad.Checked)
                {
                    kosul = " (h.h_ad+' '+h.h_soyad) like '%" + txtAra.Text + "%'";
                }
                sorgu += kosul;
                SqlDataAdapter sda = new SqlDataAdapter(sorgu, bgl.baglanti());
                DataSet ds = new DataSet();
                sda.Fill(ds, "randevu");
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
                bgl.baglanti().Close();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Aranacak veriyi giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this,"Randevuyu iptal etmek istediğine emin misin?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("update randevu set durum=8 where r_id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString(), bgl.baglanti());
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                MetroFramework.MetroMessageBox.Show(this,"Randevu iptal edildi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yukle();
            }
        }

        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && radioTc.Checked)
            {
                e.Handled = true;
            }
            else if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && radioAdSoyad.Checked)
            {
                e.Handled = true;
            }
        }

        private void radioTc_CheckedChanged(object sender, EventArgs e)
        {
            txtAra.ResetText();
            txtAra.MaxLength = 11;
        }

        private void radioAdSoyad_CheckedChanged(object sender, EventArgs e)
        {
            txtAra.ResetText();
            txtAra.MaxLength = 50;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string randevu, ad, soyad, tc, pol, dr, tarih, saat;

            string[] adsoyad = dataGridView1.CurrentRow.Cells[1].Value.ToString().Split(' ');

            randevu = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ad = adsoyad[0].ToString();
            soyad = adsoyad[1].ToString();
            tc = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            pol = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dr = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tarih = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            saat = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            RandevuOnay rndv = new RandevuOnay(randevu, tc, ad, soyad, pol, dr, tarih, saat);
            rndv.ShowDialog();
        }

      
    }
}
