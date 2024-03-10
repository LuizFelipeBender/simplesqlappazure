using sqlapp.Models;
using System.Data.SqlClient;
namespace sqlapp.Services
{
    public class ProductService
    {
        private static string db_source = "";
        private static string db_user = "";
        private static string db_password = "";
        private static string db_database = "";

        private SqlConnection GetConnection()
        {
            var _builder=new System.Data.SqlClient.SqlConnectionStringBuilder();
            _builder.DataSource = db_source;
            _builder.UserID = db_user;
            _builder.Password = db_password;
            _builder.InitialCatalog = db_database;
            return new SqlConnection(_builder.ConnectionString);
        }

        public List<Product> GetProducts()
        {
            SqlConnection connection = GetConnection();

            List<Product> productslist = new List<Product>();

            string statement = "SELECT * FROM Products ";

            connection.Open();

            SqlCommand cmd = new SqlCommand(statement, connection);

            using (SqlDataReader reader = cmd.ExecuteReader()) 
            {
            while (reader.Read())
                {
                    Product product = new Product()
                    {
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        ProductDescription = reader.GetString(2),
                        Quantity = reader.GetInt32(3)
                    };
                    productslist.Add(product);
                }
            }
            connection.Close();
            return productslist;
        }

    }
}
