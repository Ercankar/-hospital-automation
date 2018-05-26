using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hastaneotomasyonu1
{
    class baglantı
    {
      public SqlConnection baglantım()
        {
            SqlConnection con = new SqlConnection(@"");

            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            return con;
        }
    }
}
