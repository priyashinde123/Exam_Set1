using SET1.Entities;
using SET1.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Set1
{
    public class Question3
    {
        private static string connection_String = @"Data Source=DESKTOP-7K173KI\SQL2016EXPRESS;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=aa";

        private static usp_Monthly_Report_Operation monthly_report_operation = new usp_Monthly_Report_Operation(connection_String);
        public static void execute()
        {
            Console.WriteLine("enter Product Name");
            string product_name = Console.ReadLine();
            Console.WriteLine("enter Month");
            string month =Console.ReadLine();
            Console.WriteLine("enter Year");
            string year = Console.ReadLine();
           
            usp_Monthly_Report item = monthly_report_operation.GetYealyStatement(product_name, month,year);
            
            Console.WriteLine($"Product Name \t Month\t Total Order Price");
            Console.WriteLine($"{item.product_name}\t\t{item.month}\t{item.total_order_price}");

            
        }
    }
}
