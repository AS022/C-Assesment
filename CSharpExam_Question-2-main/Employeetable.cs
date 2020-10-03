namespace ExamWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpTable
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public decimal EmpSalary { get; set; }
    }
}