using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Net_MVC_with_SlickGrid.Models
{
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }
 

}