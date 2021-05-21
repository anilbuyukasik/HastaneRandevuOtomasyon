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

namespace Hastane_v0._2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        MainMenu mn = new MainMenu();

        public string durum = "false";
        public string adSoyad, yetki,id,poliklinik = "";
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select g.id,ad,soyad,y.yetki from gorevliler g join yetkiler y on g.yetki=y.id where tcno=@tc and sifre=@sifre", bgl.baglanti());
                cmd.Parameters.AddWithValue("@tc", txtTc.Text);
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                SqlCommand cmd2 = new SqlCommand("select d_id, d_ad, d_soyad, p.p_adi from doktorlar d join poliklinikler p on d.p_id=p.p_id where tc=@tc and sifre=@sifre", bgl.baglanti());
                cmd2.Parameters.AddWithValue("@tc", txtTc.Text);
                cmd2.Parameters.AddWithValue("@sifre", txtSifre.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                dr.Read();
                dr2.Read();
                if (dr.HasRows)
                {
                    id = dr["id"].ToString();
                    adSoyad = dr["ad"].ToString() + " " + dr["soyad"].ToString();
                    yetki = dr["yetki"].ToString();
                    MetroFramework.MetroMessageBox.Show(this,"Sisteme giriş yapıldı!\nGörevli: " + adSoyad, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    durum = "true";

                }
                else if (dr2.HasRows)
                {
                    id = dr2["d_id"].ToString();
                    adSoyad = dr2["d_ad"].ToString() + " " + dr2["d_soyad"].ToString();
                    yetki = "Doktor";
                    poliklinik = dr2["p_adi"].ToString();
                    MetroFramework.MetroMessageBox.Show(this,"Sisteme giriş yapıldı!\nDoktor: " + adSoyad,"Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                    durum = "true";
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Görevli bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTc.ResetText();
                    txtSifre.ResetText();
                    txtTc.Focus();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        

        private void Login_Load(object sender, EventArgs e)
        {
            //txtSifre.ResetText();
            //txtTc.ResetText();
            //txtTc.Focus();

            txtTc.Text = "50077041734";
            txtSifre.Text = "123456";

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
