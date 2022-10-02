using SET1.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1.Operations
{
    public class usp_Monthly_Report_Operation
    {
        private string _connectionString;
        public usp_Monthly_Report_Operation(string connectionString)
        {
            _connectionString = connectionString;
        }

         public usp_Monthly_Report GetYealyStatement(string product_name,string month,string year)
        {
            usp_Monthly_Report count = new usp_Monthly_Report();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                SqlCommand command = new SqlCommand($"EXECUTE[dbo].[Monthly_Report]'{product_name}','{month}','{year}'", connection);

                connection.Open();


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   
                    count.product_name = (string)reader[0];
                    count.month = (string)reader[1];
                    count.total_order_price = (double)reader[2];

                }

                connection.Close();

            }

            return count;
        }
    }
}
