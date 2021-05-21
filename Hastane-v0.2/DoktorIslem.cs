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
    public partial class DoktorIslem : UserControl
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public DoktorIslem()
        {
            InitializeComponent();
        }
        private void DoktorIslem_Load(object sender, EventArgs e)
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
            cBoxMemleket.ValueMember = "id";
            cBoxMemleket.DisplayMember = "sehir";
            cBoxMemleket.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from poliklinikler", bgl.baglanti());
            da2.Fill(dt2);
            cBoxPoliklinik.ValueMember = "p_id";
            cBoxPoliklinik.DisplayMember = "p_adi";
            cBoxPoliklinik.DataSource = dt2;

            Dictionary<char, string> combosource = new Dictionary<char, string>();
            combosource.Add('E', "Erkek");
            combosource.Add('K', "Kadın");
            cBoxCins.DataSource = new BindingSource(combosource, null);
            cBoxCins.ValueMember = "Key";
            cBoxCins.DisplayMember = "Value";
            cBoxCins.Text = "Seçiniz";
            yukle();
        }
        void yukle()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select tc as 'T.C. NO',d_ad as 'AD',d_soyad as 'SOYAD',tel as 'TELEFON',p_adi as 'POLİKLİNİK',mail as 'E-MAİL',cinsiyet as 'CİNSİYET',sehir as 'MEMLEKET'  from doktorlar d join poliklinikler p on d.p_id=p.p_id join iller i on d.memleket=i.id", bgl.baglanti());
            DataSet ds = new DataSet();
            sda.Fill(ds, "doktorlar");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtTc.Text!="" && txtAd.Text!="" && txtSoyad.Text!="" && cBoxCins.Text!="Seçiniz"  && txtTel.Text != "" && txtMail.Text!="" )
            {
                SqlCommand komut = new SqlCommand("select * from doktorlar where tc=" + txtTc.Text, bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.HasRows)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Bu doktor sisteme kayıtlı!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtTc.Text = "";
                    txtTc.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into doktorlar (tc,d_ad,d_soyad,tel,p_id,mail,cinsiyet,memleket) values (@tc,@ad,@soyad,@tel,@pol,@mail,@cins,@memleket)", bgl.baglanti());
                    cmd.Parameters.AddWithValue("@tc", txtTc.Text);
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@tel", txtTel.Text.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty).Replace(" ", string.Empty));
                    cmd.Parameters.AddWithValue("@pol", cBoxPoliklinik.SelectedValue);
                    cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                    cmd.Parameters.AddWithValue("@cins", cBoxCins.SelectedValue);
                    cmd.Parameters.AddWithValue("@memleket", cBoxMemleket.SelectedValue);
                    cmd.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    yukle();
                    MetroFramework.MetroMessageBox.Show(this, "Kayıt işlemi başarıyla tamamlandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Tüm alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.MaskCompleted)
            {
                SqlCommand cmd = new SqlCommand("select tc as 'T.C. NO',d_ad as 'AD',d_soyad as 'SOYAD',tel as 'TELEFON',p_adi as 'POLİKLİNİK',mail as 'E-MAİL',cinsiyet as 'CİNSİYET',sehir as 'MEMLEKET'  from doktorlar d join poliklinikler p on d.p_id=p.p_id join iller i on d.memleket=i.id where tc=" + txtTc.Text, bgl.baglanti());
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
                    txtTel.Text = dr["TELEFON"].ToString();
                    txtMail.Text = dr["E-MAİL"].ToString();
                    cBoxMemleket.Text = dr["MEMLEKET"].ToString();
                    cBoxPoliklinik.Text = dr["POLİKLİNİK"].ToString();
                    btnKaydet.Enabled = false;
                    btnGuncelle.Enabled = true;
                    txtTc.ReadOnly = true;

                }
            }
        }
        void temizle()
        {
            txtTc.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cBoxCins.Text = "Seçiniz";
            txtTel.Text = "";
            txtMail.Text = "";
            cBoxMemleket.SelectedIndex = 0;
            cBoxPoliklinik.SelectedIndex = 0;
            txtTc.ReadOnly = false;
            btnGuncelle.Enabled = false;
            btnKaydet.Enabled = true;
            txtTc.Focus();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTc.Text != "" && txtAd.Text != "" && txtSoyad.Text != "" && cBoxCins.Text!="Seçiniz" && txtTel.Text != "" && txtMail.Text != "")
            {
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this,"Doktor bilgilerini güncellemek istediğine emin misin?", "Uyarı", MessageBoxButtons.YesNo);
                 if (dialog == DialogResult.Yes)
                 {
                     SqlCommand cmd = new SqlCommand("update doktorlar set tc=@tc,d_ad=@ad,d_soyad=@soyad,tel=@tel,p_id=@pol,mail=@mail,cinsiyet=@cins,memleket=@memleket where tc=@tc", bgl.baglanti());
                     cmd.Parameters.AddWithValue("@tc", txtTc.Text);
                     cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                     cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                     cmd.Parameters.AddWithValue("@tel", txtTel.Text.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty).Replace(" ", string.Empty));
                     cmd.Parameters.AddWithValue("@pol", cBoxPoliklinik.SelectedValue);
                     cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                     cmd.Parameters.AddWithValue("@cins", cBoxCins.SelectedValue);
                     cmd.Parameters.AddWithValue("@memleket", cBoxMemleket.SelectedValue);
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string cins = "";

            if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "E") cins = "Erkek";
            else cins = "Kadın";

            txtTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cBoxPoliklinik.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cBoxCins.Text = cins.ToString();
            cBoxMemleket.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtTc.ReadOnly = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this,"Doktor bilgilerini silmek istediğine emin misin?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from doktorlar where tc=" + dataGridView1.CurrentRow.Cells[0].Value.ToString(), bgl.baglanti());
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                MetroFramework.MetroMessageBox.Show(this,"Silme işlemi başarıyla tamamlandı");
                yukle();
                temizle();
            }
        }

        private void cBoxCins_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
