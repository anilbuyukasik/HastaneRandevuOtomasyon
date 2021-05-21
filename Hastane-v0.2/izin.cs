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
    public partial class izin : UserControl
    {
        public izin(string doktor)
        {
            InitializeComponent();
            dr_id = doktor.ToString();
        }
        public string dr_id;
        SqlBaglanti bgl = new SqlBaglanti();
        private void izin_Load(object sender, EventArgs e)
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

            dtBaslangic.MinDate = DateTime.Now.AddDays(1);
            dtBitis.MinDate = DateTime.Now.AddDays(1);
            yukle();
        }

        private void btnizinAl_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            SqlCommand cmd2 = new SqlCommand("select * from izinler where doktor=" + dr_id, bgl.baglanti());
            SqlDataReader dr=cmd2.ExecuteReader();
            while (dr.Read())
            {
                if (sayac > 0) break;
                DateTime baslangic = Convert.ToDateTime(dr["baslangic"].ToString());
                DateTime bitis = Convert.ToDateTime(dr["bitis"].ToString());
                if (baslangic == dtBaslangic.Value || bitis == dtBitis.Value || dtBaslangic.Value < bitis)
                {
                    sayac++;
                }
            }
            if (dtBaslangic.Value > dtBitis.Value)
            {
                MetroFramework.MetroMessageBox.Show(this,"Başlangıç tarihi bitiş tarihinden sonra olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sayac > 0)
            {
                MetroFramework.MetroMessageBox.Show(this,"Kesişen tarihler var.\nBu tarihlerde izin alamazsınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult onay = MetroFramework.MetroMessageBox.Show(this, "İzin onaylandığı takdirde seçtiğiniz tarihler arasındaki randevular iptal olacaktır. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (onay==DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("insert into izinler (doktor,baslangic,bitis,durum) values(@doktor,@baslangic,@bitis,@durum)", bgl.baglanti());
                    cmd.Parameters.AddWithValue("@doktor", dr_id);
                    cmd.Parameters.AddWithValue("@baslangic", dtBaslangic.Value);
                    cmd.Parameters.AddWithValue("@bitis", dtBitis.Value);
                    cmd.Parameters.AddWithValue("@durum", "4");
                    cmd.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this, "İzin talebiniz alınmıştır.\nYetkili tarafından onaylanmasını bekleyin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yukle();
                }
                
            }
            
        }
        void yukle()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select baslangic as 'İZİN BAŞLANGIÇ', bitis as 'İZİN BİTİŞ',d.durum as 'DURUM' from izinler i join durumlar d on i.durum=d.id where doktor=" + dr_id, bgl.baglanti());
            DataSet ds = new DataSet();
            sda.Fill(ds, "izinler");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            bgl.baglanti().Close();
        }
    }
}
