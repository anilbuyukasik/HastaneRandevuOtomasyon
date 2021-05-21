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
    public partial class DrAyar : UserControl
    {
        public DrAyar(string doktor)
        {
            InitializeComponent();
            dr_id = doktor.ToString();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string dr_id;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEski.Text != "" && txtYeni.Text != "" && txtYeniTekrar.Text != "") 
            {
                SqlCommand cmd = new SqlCommand("select * from doktorlar where d_id=" + dr_id, bgl.baglanti());
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (txtYeni.Text == txtYeniTekrar.Text)
                {
                    if (dr["sifre"].ToString()==txtEski.Text)
                    {
                        if (txtYeni.Text!=dr["sifre"].ToString())
                        {
                            SqlCommand cmd2 = new SqlCommand("update doktorlar set sifre=@sifre where d_id=" + dr_id, bgl.baglanti());
                            cmd2.Parameters.AddWithValue("@sifre", txtYeni.Text);
                            cmd2.ExecuteNonQuery();
                            MetroFramework.MetroMessageBox.Show(this,"Şifre değiştirildi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEski.ResetText();
                            txtYeni.ResetText();
                            txtYeniTekrar.ResetText();
                            txtEski.Focus();
                        }
                        else MetroFramework.MetroMessageBox.Show(this,"Yeni şifre, eski şifre ile aynı olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MetroFramework.MetroMessageBox.Show(this,"Eski şifre yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MetroFramework.MetroMessageBox.Show(this,"Şifreler uyuşmuyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MetroFramework.MetroMessageBox.Show(this,"Gerekli alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DrAyar_Load(object sender, EventArgs e)
        {

        }
    }
}
