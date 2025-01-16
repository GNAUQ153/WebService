using System.Data.SqlClient;

namespace World_WS.DB
    {
    public class ConnectDB
        {
        static readonly string connStr = @"Data Source=DESKTOP-PV1HR7P\SQLEXPRESS;Initial Catalog=world;Integrated Security=True;Encrypt=False";

        public static SqlConnection GetInstance()
            {
            return new SqlConnection(connStr);
            }
        }
    }
