using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DBConnection
    {
        public static string getConnection()
        {
            return string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Adeel Khan\source\repos\Three_Tier_Architecture\DataAccessLayer\StudentDB.mdf;Integrated Security=True");
        }
    }
}
