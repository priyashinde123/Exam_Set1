using SET1.Entitites;
using SET1.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Set1
{
    public class Question1
    {
        private static string connection_String = @"Data Source=DESKTOP-7K173KI\SQL2016EXPRESS;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=aa";

       private static usp_TotalOrderCount_Operation count_operation = new usp_TotalOrderCount_Operation(connection_String);
        public static  void execute()
        {   
            Console.WriteLine("enter FromDate");

            DateTime from_date= DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
            Console.WriteLine("enter ToDate");

             DateTime to_date = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);

            List<usp_TotalOrderCount> list= count_operation.GetTotalOrderCounts(from_date.ToString("yyyy-MM-dd"), from_date.ToString("yyyy-MM-dd"));
      
            Console.WriteLine("EmployeId\tOrderId\tTotalOrderPrice");
            foreach (usp_TotalOrderCount item in list)
            {
                Console.WriteLine($"{item.emp_name}\t{item.order_id}\t\t\t{item.total_order_count}");
                
            }
        }
    }
}
