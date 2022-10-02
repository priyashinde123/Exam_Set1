using SET1_LIB_.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1_LIB_.Operations
{
    public class usp_TotalOrderCount_Operation
    {
        private string _connectionString;
        public usp_TotalOrderCount_Operation(string connectionString)
        {
            _connectionString = connectionString;
        }
        /*
        public List<Entitites.usp_TotalOrderCount> getinfo(DateTime d1, DateTime d2)
        {
            List<usp_TotalOrderCount> info = new List<usp_TotalOrderCount>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                SqlCommand command = new SqlCommand($"EXECUTE[dbo].[usp_complaint] {d1.ToString("yyyy-MM-dd")}, {d2.ToString("yyyy-MM-dd")}", connection);

                connection.Open();


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    usp_TotalOrderCount c = new usp_TotalOrderCount();
                    c.first_name = (string)reader[0];
                    c.query = (string)reader[1];
                    c.query_status = (string)reader[2];

                    info.Add(c);

                }

                connection.Close();

            }

            return info;
        }*/
    }
}
