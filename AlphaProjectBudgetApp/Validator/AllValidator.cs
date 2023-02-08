using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProjectBudgetApp.Validator
{
    public class AllValidator : IDateValidator
    {
        public bool ValidateOnFriday(DateTime enddate)
        {
            if (enddate.DayOfWeek == DayOfWeek.Friday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateOnMonday(DateTime startdate)
        {

            if (startdate.DayOfWeek == DayOfWeek.Monday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
