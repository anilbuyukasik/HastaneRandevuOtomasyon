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
    public partial class izinOnay : UserControl
    {
        public izinOnay()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void izinOnay_Load(object sender, EventArgs e)
        {
            drpFiltre.BorderStyle = BorderStyle.None;

            drpFiltre.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(83, 195, 237);
            drpFiltre.DefaultCellStyle.BackColor = Color.FromArgb(196, 223, 186);
            drpFiltre.DefaultCellStyle.ForeColor = Color.Black;
            drpFiltre.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            drpFiltre.DefaultCellStyle.SelectionBackColor = Color.White;
            drpFiltre.DefaultCellStyle.SelectionForeColor = Color.Black;
            drpFiltre.DefaultCellStyle.Font = new Font("Century Gothic", 16);


            drpFiltre.BackgroundColor = Color.FromArgb(97, 223, 252);
            drpFiltre.EnableHeadersVisualStyles = false;
            drpFiltre.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            drpFiltre.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 53, 71);
            drpFiltre.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            
           
            radioTc.Checked = true;

            yukle();
        }
        void yukle()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select i.id as 'İZİN ID', tc as 'T.C. NO',(d_ad+' '+d_soyad) as 'DOKTOR',p.p_adi as 'POLİKLİNİK',baslangic as 'BAŞLANGIÇ',bitis as 'BİTİS',drm.durum as 'DURUM' from izinler i join doktorlar d on i.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id join durumlar drm on i.durum=drm.id", bgl.baglanti());
            DataSet ds = new DataSet();
            sda.Fill(ds, "izinler");
            drpFiltre.DataSource = ds.Tables[0];
            drpFiltre.Refresh();
            bgl.baglanti().Close();
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

       

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            string sorgu = "select i.id as 'İZİN ID', tc as 'T.C. NO',(d_ad+' '+d_soyad) as 'DOKTOR',p.p_adi as 'POLİKLİNİK',baslangic as 'BAŞLANGIÇ',bitis as 'BİTİS',drm.durum as 'DURUM' from izinler i join doktorlar d on i.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id join durumlar drm on i.durum=drm.id where";
            string kosul = " baslangic >='" + dtBaslangic.Value.Date.ToString("yyyy-M-dd") + "' and bitis <= '" + dtBitis.Value.Date.ToString("yyyy-M-dd") + "'";
            if (radioOnaylandi.Checked)
            {
                kosul += " and i.durum=3";
            }
            else if (radioOnaylanmamis.Checked)
            {
                kosul += " and i.durum=4";
            }
            sorgu += kosul;
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataSet ds = new DataSet();
            sda.Fill(ds, "izinler");
            drpFiltre.DataSource = ds.Tables[0];
            drpFiltre.Refresh();
            bgl.baglanti().Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAra.ResetText();
            radioTc.Checked = true;
            radioHepsi.Checked = true;
            radioHepsi1.Checked = true;
            dtBaslangic.Value = DateTime.Now;
            dtBitis.Value = DateTime.Now;
            yukle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAra.Text != "")
            {
                string sorgu = "select i.id as 'İZİN ID', tc as 'T.C. NO',(d_ad+' '+d_soyad) as 'DOKTOR',p.p_adi as 'POLİKLİNİK',baslangic as 'BAŞLANGIÇ',bitis as 'BİTİS',drm.durum as 'DURUM' from izinler i join doktorlar d on i.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id join durumlar drm on i.durum=drm.id where ";
                string kosul = "";
                if (radioTc.Checked)
                {
                    kosul = " d.tc='" + txtAra.Text + "'";
                }
                if (radioAdSoyad.Checked)
                {
                    kosul = " (d.d_ad+' '+d.d_soyad) like '%" + txtAra.Text + "%'";
                }
                sorgu += kosul;
                SqlDataAdapter sda = new SqlDataAdapter(sorgu, bgl.baglanti());
                DataSet ds = new DataSet();
                sda.Fill(ds, "izinler");
                drpFiltre.DataSource = ds.Tables[0];
                drpFiltre.Refresh();
                bgl.baglanti().Close();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Aranacak veriyi giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < drpFiltre.Rows.Count; i++)
            {
                drpFiltre.Rows[i].Cells[0].Value = true;
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            string secilen = "";
            for (int i = 0; i < drpFiltre.Rows.Count; i++)
            {
                if (drpFiltre.Rows[i].Cells[0].Value != null)
                {
                    secilen += drpFiltre.Rows[i].Cells[1].Value.ToString() + ",";
                }
            }
            if (secilen=="")
            {
                MetroFramework.MetroMessageBox.Show(this,"Hiçbir kayıt seçilmedi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                secilen = secilen.Substring(0, secilen.Length - 1).ToString();
                DialogResult onay = MetroFramework.MetroMessageBox.Show(this,"Seçilen izinleri onaylamak istediğine emin misin?\nSeçilen izin numaraları: " + secilen + "", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("update izinler set durum=3 where id in(" + secilen + ")", bgl.baglanti());
                    cmd.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this,"İzinler onaylandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string[] idlerim = secilen.Split(',');

                    for (int i = 0; i < idlerim.Length; i++)
                    {
                        SqlCommand sorguizin = new SqlCommand("select * from izinler where id=@id", bgl.baglanti());
                        sorguizin.Parameters.AddWithValue("@id", idlerim[i]);
                        SqlDataReader veridr = sorguizin.ExecuteReader();
                        if (veridr.Read())
                        {
                            string baslangicc, bitiss,doktorid;

                            baslangicc = Convert.ToDateTime(veridr["baslangic"]).ToString("yyyy-M-dd");
                            bitiss = Convert.ToDateTime(veridr["bitis"]).ToString("yyyy-M-dd");
                            doktorid = veridr["doktor"].ToString();


                            SqlCommand guncelle = new SqlCommand("update randevu set durum='8' where tarih between  '"+baslangicc+"' AND '"+bitiss+"' AND doktor=@doktor", bgl.baglanti());
                            guncelle.Parameters.AddWithValue("@doktor", doktorid);
                            guncelle.ExecuteNonQuery();
                        }
                    }
                }
            }
            yukle();
        }

        private void iziniOnaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult onay = MetroFramework.MetroMessageBox.Show(this,"Seçilen izini onaylamak istediğine emin misin?\nSeçilen izin numarası: " + drpFiltre.CurrentRow.Cells[1].Value.ToString() + "", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay==DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("update izinler set durum=3 where id in(" + drpFiltre.CurrentRow.Cells[1].Value.ToString() + ")", bgl.baglanti());
                    cmd.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this,"İzin onaylandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                SqlCommand sorguizin = new SqlCommand("select * from izinler where id=@id", bgl.baglanti());
                        sorguizin.Parameters.AddWithValue("@id", drpFiltre.CurrentRow.Cells[1].Value.ToString());
                        SqlDataReader veridr = sorguizin.ExecuteReader();
                        if (veridr.Read())
                        {
                            string baslangicc, bitiss, doktorid;

                            baslangicc = Convert.ToDateTime(veridr["baslangic"]).ToString("yyyy-M-dd");
                            bitiss = Convert.ToDateTime(veridr["bitis"]).ToString("yyyy-M-dd");
                            doktorid = veridr["doktor"].ToString();


                            SqlCommand guncelle = new SqlCommand("update randevu set durum='8' where tarih between  '" + baslangicc + "' AND '" + bitiss + "' AND doktor=@doktor", bgl.baglanti());
                            guncelle.Parameters.AddWithValue("@doktor", doktorid);
                            guncelle.ExecuteNonQuery();
                        }
            }
            yukle();
        }

        private void radioHepsi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioHepsi1_CheckedChanged(object sender, EventArgs e)
        {
            yukle();
        }

        private void radioOnaylandi1_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select i.id as 'İZİN ID', tc as 'T.C. NO',(d_ad+' '+d_soyad) as 'DOKTOR',p.p_adi as 'POLİKLİNİK',baslangic as 'BAŞLANGIÇ',bitis as 'BİTİS',drm.durum as 'DURUM' from izinler i join doktorlar d on i.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id join durumlar drm on i.durum=drm.id where i.durum=3", bgl.baglanti());
            DataSet ds = new DataSet();
            sda.Fill(ds, "izinler");
            drpFiltre.DataSource = ds.Tables[0];
            drpFiltre.Refresh();
            bgl.baglanti().Close();
        }

        private void radioOnaylanmamis1_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select i.id as 'İZİN ID', tc as 'T.C. NO',(d_ad+' '+d_soyad) as 'DOKTOR',p.p_adi as 'POLİKLİNİK',baslangic as 'BAŞLANGIÇ',bitis as 'BİTİS',drm.durum as 'DURUM' from izinler i join doktorlar d on i.doktor=d.d_id join poliklinikler p on d.p_id=p.p_id join durumlar drm on i.durum=drm.id where i.durum=4", bgl.baglanti());
            DataSet ds = new DataSet();
            sda.Fill(ds, "izinler");
            drpFiltre.DataSource = ds.Tables[0];
            drpFiltre.Refresh();
            bgl.baglanti().Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
