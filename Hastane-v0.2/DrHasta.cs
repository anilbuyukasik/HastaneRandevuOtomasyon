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
    public partial class DrHasta : UserControl
    {
        public DrHasta(string doktor)
        {
            InitializeComponent();
            dr = doktor.ToString();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string dr;
        private void DrHasta_Load(object sender, EventArgs e)
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
            SqlDataAdapter sda = new SqlDataAdapter("select tcno as 'T.C. KİMLİK NO',(h_ad+' '+h_soyad) as 'ADI SOYADI',cinsiyet as 'CİNSİYET',DATEDIFF(YEAR,h.dtarihi,GETDATE()) as 'HASTA YAŞI',telno as 'TELEFON',il.sehir as 'İL',i.ilce as 'İLÇE' from hastalar h join randevu r on h.h_id=r.hasta join muayene m on r.r_id=m.randevu join ilceler i on h.ilce=i.id join iller il on i.sehir=il.id where r.doktor=" + dr, bgl.baglanti());

            DataSet ds = new DataSet();
            sda.Fill(ds, "hastalar");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tc = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (tc != "")
            {
                MuayeneGecmis mg = new MuayeneGecmis(tc);
                mg.ShowDialog();
            }
            else MetroFramework.MetroMessageBox.Show(this,"Hasta seçilmedi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAra.Text!="")
            {
                string sorgu = "select tcno as 'T.C. KİMLİK NO',(h_ad+' '+h_soyad) as 'ADI SOYADI',cinsiyet as 'CİNSİYET',DATEDIFF(YEAR,h.dtarihi,GETDATE()) as 'HASTA YAŞI',telno as 'TELEFON',il.sehir as 'İL',i.ilce as 'İLÇE' from hastalar h join randevu r on h.h_id=r.hasta join muayene m on r.r_id=m.randevu join ilceler i on h.ilce=i.id join iller il on i.sehir=il.id where r.doktor=" + dr;
                string kosul = "";
                if (radioTc.Checked)
                {
                    kosul = " and h.tcno='" + txtAra.Text + "'";
                }
                if (radioAdSoyad.Checked)
                {
                    kosul = " and (h.h_ad+' '+h.h_soyad) like '%" + txtAra.Text + "%'";
                }
                sorgu += kosul;
                SqlDataAdapter sda = new SqlDataAdapter(sorgu, bgl.baglanti());
                DataSet ds = new DataSet();
                sda.Fill(ds, "hastalar");
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
                bgl.baglanti().Close();
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
