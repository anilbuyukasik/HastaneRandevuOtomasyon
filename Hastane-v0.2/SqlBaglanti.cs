using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_v0._2
{
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Hastane;Integrated Security=True");
            //SqlConnection baglan = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Hastane.mdf;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
