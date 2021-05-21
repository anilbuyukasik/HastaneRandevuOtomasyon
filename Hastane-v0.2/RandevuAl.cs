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
    public partial class RandevuAl : UserControl
    {
        
        public RandevuAl(string gorevli)
        {
            InitializeComponent();
            g_id = gorevli;
        }
        SqlBaglanti bgl = new SqlBaglanti();


        private void btnOnay_Click(object sender, EventArgs e)
        {
            string rsaat = null;
            foreach (Control saat in panel1.Controls)
            {
                if (saat is RadioButton)
                {
                    RadioButton radio = saat as RadioButton;
                    if (radio.Checked)
                    {
                        rsaat = radio.Text;
                    }
                }
            }
            if (txtTc.MaskCompleted && rsaat!=null)
            {
                DialogResult onay = MetroFramework.MetroMessageBox.Show(this,"Randevuyu onaylamak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    string adsoyad = txtAdSoyad.Text;
                    char[] x = { ' ' };
                    string[] ayir = adsoyad.Split(x, StringSplitOptions.RemoveEmptyEntries);

                    
                    tc = txtTc.Text;
                    hasta_ad = ayir[0];
                    hasta_soyad = ayir[1];
                    pol = cBoxPoliklinik.Text;
                    doktor = cBoxDoktor.Text;
                    tarih = dtRandevu.Value.ToShortDateString();
                    rnsaat = rsaat.ToString();

                    SqlCommand cmd = new SqlCommand("insert into randevu (doktor,hasta,tarih,saat,gorevli,durum) values (@doktor,@hasta,@tarih,@saat,@gorevli,5); select SCOPE_IDENTITY();", bgl.baglanti());
                    cmd.Parameters.AddWithValue("@doktor", cBoxDoktor.SelectedValue);
                    cmd.Parameters.AddWithValue("@hasta", id.ToString());
                    cmd.Parameters.AddWithValue("@tarih", dtRandevu.Value.Date.ToString("yyyy-M-dd"));
                    cmd.Parameters.AddWithValue("@saat", rsaat.ToString());
                    cmd.Parameters.AddWithValue("@gorevli", g_id.ToString());
                    randevu_id = cmd.ExecuteScalar().ToString();
                    MetroFramework.MetroMessageBox.Show(this,"Randevunuz onaylanmıştır!","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    RandevuOnay rndv = new RandevuOnay(randevu_id, tc, hasta_ad, hasta_soyad, pol, doktor, tarih, rnsaat);
                    rndv.ShowDialog();
                    iptal();
                }


            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Gerekli alanları doldurunuz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public string tc = "",id="",g_id;
        public string randevu_id, doktor, hasta_ad, hasta_soyad, pol, tarih, rnsaat;

        private void RandevuAl_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from poliklinikler where durum=1", bgl.baglanti());
            da.Fill(dt);
            cBoxPoliklinik.ValueMember = "p_id";
            cBoxPoliklinik.DisplayMember = "p_adi";
            cBoxPoliklinik.DataSource = dt;

            dtRandevu.MinDate = DateTime.Now;
            dtRandevu.Enabled = false;
            cBoxPoliklinik.Enabled = false;
            cBoxDoktor.Enabled = false;
            panel1.Enabled = false;
            
        }

        private void cBoxPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control saat in panel1.Controls)
            {
                if (saat is RadioButton)
                {
                    RadioButton radio = saat as RadioButton;
                    radio.Enabled = true;
                }
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select d_id, (d_ad+ ' '+d_soyad) as doktor from doktorlar where p_id=" + cBoxPoliklinik.SelectedValue + " and d_id not in(select doktor from izinler where '" + dtRandevu.Value.Date.ToString("yyyy-M-dd") + "'between baslangic and bitis and durum=3) ", bgl.baglanti());
            da.Fill(dt);
            cBoxDoktor.ValueMember = "d_id";
            cBoxDoktor.DisplayMember = "doktor";
            cBoxDoktor.DataSource = dt;
            if (cBoxDoktor.Items.Count > 0 )
            {
                cBoxDoktor.Enabled = true;
                panel1.Enabled = true;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Seçtiğiniz tarihte bu poliklinikte doktor bulunmamaktadır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBoxDoktor.Text = "";
                cBoxDoktor.Enabled = false;
                panel1.Enabled = false;
            }
        }

        private void cBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cBoxDoktor.Items.Count>0)
            {
                foreach (Control saat in panel1.Controls)
                {
                    if (saat is RadioButton)
                    {
                        RadioButton radio = saat as RadioButton;
                        radio.Enabled = true;
                        radio.BackColor = Color.SteelBlue;
                    }
                }
                foreach (Control saat in panel1.Controls)
                {
                    if (saat is RadioButton)
                    {
                        RadioButton radio = saat as RadioButton;
                        SqlCommand cmd = new SqlCommand("select convert(varchar(5),saat) as rsaat from randevu where doktor=@dr and tarih=@tarih and durum!=8", bgl.baglanti());
                        cmd.Parameters.AddWithValue("@dr", cBoxDoktor.SelectedValue);
                        cmd.Parameters.AddWithValue("@tarih", dtRandevu.Value.Date.ToString("yyyy-M-dd"));
                        SqlDataReader dr = cmd.ExecuteReader();
                        DateTime saat2 = Convert.ToDateTime(dtRandevu.Value.Date.ToShortDateString() + " " + radio.Text);
                        if (saat2 < DateTime.Now)
                        {
                            radio.Enabled = false;
                            radio.BackColor = Color.Gray;
                        }
                        else
                        {
                            radio.Enabled = true;
                            radio.BackColor = Color.SteelBlue;
                        }
                        while (dr.Read())
                        {
                            if (radio.Text == dr["rsaat"].ToString())
                            {
                                radio.Enabled = false;
                                radio.BackColor = Color.Gray;
                            }
                        }

                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Seçtiğiniz poliklinikte doktor bulunmamaktadır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtRandevu_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control saat in panel1.Controls)
            {
                if (saat is RadioButton)
                {
                    RadioButton radio = saat as RadioButton;
                    radio.Enabled= true;
                    radio.BackColor = Color.SteelBlue;
                }
            }
            if (cBoxDoktor.Text!="")
            {
                foreach (Control saat in panel1.Controls)
                {
                    if (saat is RadioButton)
                    {
                        RadioButton radio = saat as RadioButton;
                        
                        SqlCommand cmd = new SqlCommand("select convert(varchar(5),saat) as rsaat from randevu where doktor=@dr and tarih=@tarih and durum!=8", bgl.baglanti());
                        cmd.Parameters.AddWithValue("@dr", cBoxDoktor.SelectedValue);
                        cmd.Parameters.AddWithValue("@tarih", dtRandevu.Value.Date.ToString("yyyy-M-dd"));
                        SqlDataReader dr = cmd.ExecuteReader();
                        DateTime saat2 = Convert.ToDateTime(dtRandevu.Value.Date.ToShortDateString() + " " + radio.Text);
                        if (saat2 < DateTime.Now)
                        {
                            radio.Enabled = false;
                            radio.BackColor = Color.Gray;
                        }
                        else
                        {
                            radio.Enabled = true;
                            radio.BackColor = Color.SteelBlue;
                        }
                        while (dr.Read())
                        {
                            if (radio.Text == dr["rsaat"].ToString())
                            {
                                radio.Enabled = false;
                                radio.BackColor = Color.Gray;
                            }
                        }

                    }
                }
            }
            dtRandevu.ValueChanged += new EventHandler(cBoxPoliklinik_SelectedIndexChanged);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            iptal();
        }
        void iptal()
        {
            foreach (Control saat in panel1.Controls)
            {
                if (saat is RadioButton)
                {
                    RadioButton radio = saat as RadioButton;
                    radio.Checked = false;
                }
            }
            txtTc.ResetText();
            dtRandevu.Value = DateTime.Now;
            cBoxPoliklinik.SelectedIndex = 0;
            cBoxDoktor.SelectedIndex = 0;
            txtTc.Enabled = true;
            dtRandevu.Enabled = false;
            cBoxPoliklinik.Enabled = false;
            cBoxDoktor.Enabled = false;
            panel1.Enabled = false;
            txtAdSoyad.ResetText();
            txtCins.ResetText();
            txtYas.ResetText();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.MaskCompleted)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select h_id,h_ad,h_soyad,cinsiyet,DATEDIFF(YEAR,dtarihi,GETDATE()) as yas from hastalar where tcno=@tc", bgl.baglanti());
                    cmd.Parameters.AddWithValue("@tc", txtTc.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        id = dr["h_id"].ToString();
                        txtAdSoyad.Text = dr["h_ad"].ToString() + " " + dr["h_soyad"].ToString();
                        txtCins.Text = dr["cinsiyet"].ToString();
                        txtYas.Text = dr["yas"].ToString();
                        txtTc.Enabled = false;
                        dtRandevu.Enabled = true;
                        cBoxPoliklinik.Enabled = true;
                        cBoxDoktor.Enabled = true;
                        panel1.Enabled = true;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this,"Hasta sisteme kayıtlı değil!\nHasta işlemler ekranına gidiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tc = txtTc.Text;

                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
