using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProjectBudgetApp.Models
{
    public class Programm
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //public Program()
        //{
        //    this.Code = code;
        //    this.StartDate = startDate;
        //    this.EndDate = endDate;
        //}
        public Programm(string code, string name, DateTime startDate, DateTime endDate)
        {
            this.Code = code;
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
        public Programm(string code, DateTime startDate, DateTime endDate)
        {
            this.Code = code;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}
