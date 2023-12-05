using System.Data.SqlClient;

namespace StoreManagement.Functions
{
    class Connection
    {
        private static readonly string ConnectionString = @"Data Source=NGOCTRINH;Initial Catalog=StoreManagement;Integrated Security=True;TrustServerCertificate=True";
        
        public static SqlConnection Getconnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
