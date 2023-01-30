using MySql.Data.MySqlClient;

namespace Microservice1.Repository
{
    public class Globals
    {
        internal const string connectionStringFormat = "Server={0};User ID={1};Password={2};Database={3};Connection Timeout=100;Max Pool Size=20000;persistsecurityinfo=True;Convert Zero Datetime=True;Treat Tiny As Boolean=False; Allow User Variables=true;";

        public static string DBServer { get; set; }
        public static string DBUser { get; set; }
        public static string DBPassword { get; set; }
        public static string DBName { get; set; }

        internal static string connectionString;
        public static string ConnectionString
        {
            get
            {
                if (connectionString == null || connectionString == "")
                {
                    // connectionString = Settings.Default.connectionString;
                    connectionString = string.Format(connectionStringFormat, Globals.DBServer, Globals.DBUser, Globals.DBPassword, Globals.DBName);
                }
                return connectionString;
            }
        }
        public static MySqlConnection Connection
        {
            get
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString);

                conn.Open();
                return conn;
            }
        }
    }
}
