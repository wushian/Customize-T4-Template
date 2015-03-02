using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTemplate.Models
{
    public class Sample
    {
        public Int32 ID { get; set; }
        public String Name { get; set; }
        public String Designation { get; set; }
        public DateTime JoiningDate { get; set; }
        public Decimal Salary { get; set; }
    }
}