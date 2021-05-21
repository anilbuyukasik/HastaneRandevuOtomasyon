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
    public partial class DrRandevu : UserControl
    {
        public DrRandevu(string doktor)
        {
            InitializeComponent();
            dr_id = doktor.ToString();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string dr_id,r_id,h_tc,adsoyad,h_yasi,cinsiyet;
        private void DrRandevu_Load(object sender, EventArgs e)
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
            SqlDataAdapter sda = new SqlDataAdapter("select r_id as 'RANDEVO NO',(h.h_ad+' '+h.h_soyad) as 'HASTA',h.tcno as 'HASTA T.C',h.cinsiyet as 'CİNSİYET',DATEDIFF(YEAR,h.dtarihi,GETDATE()) as 'HASTA YAŞI',tarih as 'TARİH',saat as 'SAAT', (g.ad+ ' '+g.soyad) as 'GÖREVLİ',drm.durum as 'DURUM' from randevu r join hastalar h on r.hasta=h.h_id join doktorlar d on r.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id join gorevliler g on r.gorevli=g.id join durumlar drm on r.durum=drm.id where tarih>=CONVERT(date,GETDATE()) and r.doktor=" + dr_id + " and r.durum!=8 order by tarih", bgl.baglanti());
            
            DataSet ds = new DataSet();
            sda.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            bgl.baglanti().Close();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            string sorgu = "select r_id as 'RANDEVO NO',(h.h_ad+' '+h.h_soyad) as 'HASTA',h.tcno as 'HASTA T.C',h.cinsiyet as 'CİNSİYET',DATEDIFF(YEAR,h.dtarihi,GETDATE()) as 'HASTA YAŞI',tarih as 'TARİH',saat as 'SAAT', (g.ad+ ' '+g.soyad) as 'GÖREVLİ',drm.durum as 'DURUM' from randevu r join hastalar h on r.hasta=h.h_id join doktorlar d on r.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id join gorevliler g on r.gorevli=g.id join durumlar drm on r.durum=drm.id  where r.doktor=" + dr_id + " and r.durum!=8 and";
            string kosul = " tarih between'" + dtBaslangic.Value.Date.ToString("yyyy-M-dd") + "' and '" + dtBitis.Value.Date.ToString("yyyy-M-dd") + "'";
            kosul += " order by tarih";
            sorgu += kosul;
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataSet ds = new DataSet();
            sda.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            bgl.baglanti().Close();
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            yukle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAra.Text != "")
            {
                string sorgu = "select r_id as 'RANDEVO NO',(h.h_ad+' '+h.h_soyad) as 'HASTA',h.tcno as 'HASTA T.C',h.cinsiyet as 'CİNSİYET',DATEDIFF(YEAR,h.dtarihi,GETDATE()) as 'HASTA YAŞI',tarih as 'TARİH',saat as 'SAAT', (g.ad+ ' '+g.soyad) as 'GÖREVLİ',drm.durum as 'DURUM' from randevu r join hastalar h on r.hasta=h.h_id join doktorlar d on r.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id join gorevliler g on r.gorevli=g.id join durumlar drm on r.durum=drm.id  where r.doktor=" + dr_id + " and r.durum!=8 and";
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
                MetroFramework.MetroMessageBox.Show(this,"Aranacak veriyi giriniz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
    }
}
