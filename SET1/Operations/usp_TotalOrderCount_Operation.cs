using SET1.Entitites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1.Operations
{
    public class usp_TotalOrderCount_Operation
    {
        private string _connectionString;
        public usp_TotalOrderCount_Operation(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public List<Entitites.usp_TotalOrderCount> GetTotalOrderCounts(string d1, string d2)
        {
            List<usp_TotalOrderCount> totalcount = new List<usp_TotalOrderCount>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                SqlCommand command = new SqlCommand($"EXECUTE [dbo].[usp_TotalOrderCount_] '{d1}','{d2}'", connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
               

                while (reader.Read())
                {
                    usp_TotalOrderCount count = new usp_TotalOrderCount();
                    count.emp_name = (string)reader[0];
                    count.order_id = (string)reader[1];
                    count.total_order_count = (int)reader[2];


                    totalcount.Add(count);

                }

                connection.Close();

            }

            return totalcount;
        }
    }
}
