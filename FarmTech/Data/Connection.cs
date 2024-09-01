using System.Data.SqlClient;
using System.Windows.Forms;

namespace FarmTech.Data
{
    public class Connection
    {

        public Connection() {
            string connectionString = @"Server = DESKTOP-IU450N3\SQLEXPRESS; Database = dbFarmTech; Trusted_Connection = True;";
           var cn = new SqlConnection(connectionString);
        }
    }
        
}
