using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalisahaOdev
{
    class db
    {
        public SqlConnection baglanti()
        {

            //SqlConnection baglanti = new SqlConnection(@"Data Source=.\;Initial Catalog = Dodoiletisim2; Integrated Security = True");
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5B025AR\SQLEXPRESS; initial catalog=FieldAppDB2;Integrated Security=True");

            //SqlConnection baglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = Dodoiletisim; Integrated Security = True");


            baglanti.Open();
            return baglanti;
        }
    }
}
