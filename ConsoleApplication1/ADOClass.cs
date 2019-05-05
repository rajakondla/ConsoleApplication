using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class ADOClass
    {
        static void Main()
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=(localdb)\\v12.0;Initial Catalog=MyDatabase;Integrated Security=True;Pooling=False");
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("select * from demo",sqlCon);
            var data=cmd.ExecuteNonQuery();
            sqlCon.Close();
        }
    }
}
