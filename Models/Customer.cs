using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoustmerApp.Models
{
    public class Customer
    {
        public class MyData
        {
            public string CustID { get; set; }
            public string CustName { get; set; }
            public string CustAddress { get; set; }

            public override string ToString()
            {

                return $"The EmployeeID:{CustID}<p>The name:{CustName}<p>The Employee Address:{CustAddress}<p><p>";
            }
        }
    }
}
