using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class baglanti
    {
        public static SqlConnection bgl = new SqlConnection("Data Source=(localdb)\\Umut;Initial Catalog=DbKatmanliMimari;Integrated Security=True");   
    }
}
