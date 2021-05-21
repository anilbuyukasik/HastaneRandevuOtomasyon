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
    public partial class HastaIslem : UserControl
    {
      
        SqlBaglanti bgl = new SqlBaglanti();
        public HastaIslem()
        {
            InitializeComponent();
        }

        private void HastaIslem_Load(object sender, EventArgs e)
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




            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from iller", bgl.baglanti());
            da.Fill(dt);
            cBoxil.ValueMember = "id";
            cBoxil.DisplayMember = "sehir";
            cBoxil.DataSource = dt;

            Dictionary<char,string> combosource = new Dictionary<char,string>();
            combosource.Add('E', "Erkek");
            combosource.Add('K', "Kadın");
            cBoxCins.DataSource = new BindingSource(combosource, null);
            cBoxCins.ValueMember = "Key";
            cBoxCins.DisplayMember = "Value";
            cBoxCins.Text = "Seçiniz";
            dtDTarihi.MaxDate = DateTime.Now.Date.AddDays(-1);
            yukle();
            temizle();

        }
        void yukle()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select tcno as 'T.C. NO',h_ad as 'AD',h_soyad as 'SOYAD',cinsiyet as 'CİNSİYET', dtarihi as 'DOĞUM TARİHİ',telno as 'TELEFON',il.sehir as 'İL',i.ilce as 'İLÇE',adres as 'ADRES' from hastalar h  join ilceler i on h.ilce=i.id  join iller il on i.sehir=il.id", bgl.baglanti());
            DataSet ds = new DataSet();
            sda.Fill(ds,"hastalar");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtTc.Text != "" && txtAd.Text != "" && txtSoyad.Text != ""  && txtTel.Text != "" &&  txtAdres.Text != "") 
            {
                SqlCommand komut = new SqlCommand("select * from hastalar where tcno=" + txtTc.Text, bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.HasRows)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Bu hasta kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTc.Text = "";
                    txtTc.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into hastalar (tcno,h_ad,h_soyad,cinsiyet,dtarihi,telno,ilce,adres) values (@tcno,@ad,@soyad,@cins,@dogum,@tel,@ilce,@adres)", bgl.baglanti());
                    cmd.Parameters.AddWithValue("@tcno", txtTc.Text.ToString());
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                    cmd.Parameters.AddWithValue("@cins", cBoxCins.SelectedValue);
                    cmd.Parameters.AddWithValue("@dogum", dtDTarihi.Value.Date);
                    cmd.Parameters.AddWithValue("@tel", txtTel.Text.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty).Replace(" ", string.Empty));
                    cmd.Parameters.AddWithValue("@ilce", cBoxilce.SelectedValue);
                    cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
                    cmd.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    yukle();
                    MetroFramework.MetroMessageBox.Show(this,"Kayıt işlemi başarıyla tamamlandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Tüm alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cBoxil_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from ilceler where sehir=" + cBoxil.SelectedValue, bgl.baglanti());
            da.Fill(dt);
            cBoxilce.ValueMember = "id";
            cBoxilce.DisplayMember = "ilce";
            cBoxilce.DataSource = dt;
        }


        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.MaskCompleted)
            {
                SqlCommand cmd = new SqlCommand("select tcno as 'T.C. NO',h_ad as 'AD',h_soyad as 'SOYAD',cinsiyet as 'CİNSİYET', dtarihi as 'DOĞUM TARİHİ',telno as 'TELEFON',il.sehir as 'İL',i.ilce as 'İLÇE',adres as 'ADRES' from hastalar h  join ilceler i on h.ilce=i.id  join iller il on i.sehir=il.id where tcno="+txtTc.Text, bgl.baglanti());
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                     string cins = "";
                    if (dr["CİNSİYET"].ToString() == "E") cins = "Erkek";
                    else cins = "Kadın";
                    txtAd.Text = dr["AD"].ToString();
                    txtSoyad.Text = dr["SOYAD"].ToString();
                    cBoxCins.Text = cins;
                    dtDTarihi.Text = dr["DOĞUM TARİHİ"].ToString();
                    txtTel.Text = dr["TELEFON"].ToString();
                    cBoxil.Text = dr["İL"].ToString();
                    cBoxilce.Text = dr["İLÇE"].ToString();
                    txtAdres.Text = dr["ADRES"].ToString();
                    btnKaydet.Enabled = false;
                    btnGuncelle.Enabled = true;
                    txtTc.ReadOnly = true;
                }
            }
        }

        private void cBoxCins_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void temizle()
        {
            txtTc.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            dtDTarihi.Value = DateTime.Now.Date.AddDays(-1);
            cBoxCins.Text = "Seçiniz";
            txtTel.Text = "";
            cBoxil.SelectedIndex = 0;
            cBoxilce.SelectedIndex = 0;
            txtAdres.Text = "";
            btnGuncelle.Enabled = false;
            btnKaydet.Enabled = true;
            txtTc.ReadOnly = false;
            txtTc.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string cins = "";

            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "E") cins = "Erkek";
            else cins = "Kadın";
            
            txtTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cBoxCins.Text = cins.ToString();
            dtDTarihi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cBoxil.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cBoxilce.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtTc.ReadOnly = true;
        }

        private void bynGuncelle_Click(object sender, EventArgs e)
        {
             if (txtTc.Text != "" && txtAd.Text != "" && txtSoyad.Text != ""  && txtTel.Text != "" &&  txtAdres.Text != "")
             {
                 DialogResult dialog = MetroFramework.MetroMessageBox.Show(this,"Hasta bilgilerini güncellemek istediğine emin misin?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (dialog==DialogResult.Yes)
                 {
                     SqlCommand cmd = new SqlCommand("update hastalar set tcno=@tcno,h_ad=@ad,h_soyad=@soyad,cinsiyet=@cins,dtarihi=@dogum,telno=@tel,ilce=@ilce,adres=@adres where tcno=@tcno", bgl.baglanti());
                     cmd.Parameters.AddWithValue("@tcno", txtTc.Text.ToString());
                     cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                     cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                     cmd.Parameters.AddWithValue("@cins", cBoxCins.SelectedValue);
                     cmd.Parameters.AddWithValue("@dogum", dtDTarihi.Value.Date);
                     cmd.Parameters.AddWithValue("@tel", txtTel.Text.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty).Replace(" ", string.Empty));
                     cmd.Parameters.AddWithValue("@ilce", cBoxilce.SelectedValue);
                     cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
                     cmd.ExecuteNonQuery();
                     bgl.baglanti().Close();
                     yukle();
                     MetroFramework.MetroMessageBox.Show(this,"Güncelleme işlemi başarıyla tamamlandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     temizle();
                 }
                 
             }
             else
             {
                 MetroFramework.MetroMessageBox.Show(this,"Tüm alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this,"Hasta bilgilerini silmek istediğine emin misin?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog==DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from hastalar where tcno=" + dataGridView1.CurrentRow.Cells[0].Value.ToString(), bgl.baglanti());
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                MetroFramework.MetroMessageBox.Show(this,"Silme işlemi başarıyla tamamlandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yukle();
                temizle();
            }
        }
    }
}
