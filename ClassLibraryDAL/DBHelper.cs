using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
           SqlConnection con = new SqlConnection("Data Source=DESKTOP-7CD7A74\\Abdullah;Initial Catalog=FloodDestruction;Integrated Security=True;TrustServerCertificate=true;");

            return con;
        }

    }
}
