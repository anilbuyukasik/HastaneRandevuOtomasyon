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
    public partial class Poliklinikler : UserControl
    {
        public Poliklinikler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void Poliklinikler_Load(object sender, EventArgs e)
        {
            yukle();
        }
        void yukle()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from poliklinikler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cBoxSil.ValueMember = "p_id";
            cBoxSil.DisplayMember = "p_adi";
            cBoxSil.DataSource = dt;

            SqlDataAdapter da3 = new SqlDataAdapter("select * from poliklinikler", bgl.baglanti());
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            cBoxGuncelle.ValueMember = "p_id";
            cBoxGuncelle.DisplayMember = "p_adi";
            cBoxGuncelle.DataSource = dt3;

            SqlDataAdapter da2 = new SqlDataAdapter("select * from durumlar where id in(1,2)", bgl.baglanti());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cBoxDurum.ValueMember = "id";
            cBoxDurum.DisplayMember = "durum";
            cBoxDurum.DataSource = dt2;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtEkle.Text!="")
            {
                SqlCommand cmd = new SqlCommand("select * from poliklinikler where p_adi='" + txtEkle.Text.Trim()+"'", bgl.baglanti());
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Girdiğiniz poliklinik adı zaten mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("insert into poliklinikler (p_adi,durum) values(@pol,@drm)", bgl.baglanti());
                    cmd2.Parameters.AddWithValue("@pol", txtEkle.Text.Trim());
                    cmd2.Parameters.AddWithValue("@drm", "2");
                    cmd2.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this,"Poliklinik eklendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEkle.ResetText();
                    yukle();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Lütfen poliklinik adını giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cBoxGuncelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select durum from poliklinikler where p_adi='" + cBoxGuncelle.Text+"'", bgl.baglanti());
            int id = int.Parse(cmd.ExecuteScalar().ToString());
            cBoxDurum.SelectedValue = id;
            txtGuncelle.Text = cBoxGuncelle.Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = MetroFramework.MetroMessageBox.Show(this,"Seçilen poliklinik silindiği takdirde içindeki doktor bilgileri de silinecektir!\n\nSilmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (onay == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from doktorlar where p_id=" + cBoxSil.SelectedValue, bgl.baglanti());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = new SqlCommand("delete from poliklinikler where p_id=" + cBoxSil.SelectedValue, bgl.baglanti());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MetroFramework.MetroMessageBox.Show(this,"Poliklinik silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yukle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtGuncelle.Text!="")
            {
                DialogResult onay = MetroFramework.MetroMessageBox.Show(this,"Poliklinik bilgilerini güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay==DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("update poliklinikler set p_adi=@pol,durum=@drm where p_id=" + cBoxGuncelle.SelectedValue,bgl.baglanti());
                    cmd.Parameters.AddWithValue("@pol", txtGuncelle.Text.Trim());
                    cmd.Parameters.AddWithValue("@drm", cBoxDurum.SelectedValue);
                    cmd.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this,"Poliklinik güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yukle();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Lütfen poliklinik adını giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
