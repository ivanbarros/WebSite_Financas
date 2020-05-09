using MySql.Data.MySqlClient;
using System.Data;

namespace MyFinance.Utils
{
    public class DAL
    {
        private static string server = "50.62.209.87";
        private static string database = "Finance_Project";
        private static string user = "finance";
        private static string password = "Pophets3003@";
        private static string charset = "utf8;convert zero datetime=True";
        private static string provider = "MySql.Data.MySqlClient";
        private string connectionString = $"Datasource={server};Database={database};Uid={user};Pwd={password};CHARSET={charset}";
        private MySqlConnection connection;

        public DAL()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
        //Executa Selects
        public DataTable RetDataTable(string sql)
        {
            DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dataTable);
            return dataTable;
        }
        //Executa Inserts, Updates e Deletes
        public void ExecutaComandoSql(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();

        }
    }
}
