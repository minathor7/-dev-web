using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-J9V0010;Initial Catalog=Dbo_yazokulu;Integrated Security=True");

    }
}
