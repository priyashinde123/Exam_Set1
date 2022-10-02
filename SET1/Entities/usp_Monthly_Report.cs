using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1.Entities
{
    public class usp_Monthly_Report
    {
     public   string product_name { get; set; }
      public  string month { get; set; }   

      public  double total_order_price { get; set; }
    }
}
