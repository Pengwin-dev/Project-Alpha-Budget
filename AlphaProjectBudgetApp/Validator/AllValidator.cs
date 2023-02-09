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
            bool result = false;
            if (enddate.DayOfWeek == DayOfWeek.Friday)
            {
                result = true;
            }
                return result;
            
        }

        public bool ValidateOnMonday(DateTime startdate)
        {

            bool result = false;
            if (startdate.DayOfWeek == DayOfWeek.Monday)
            {
                result = true;
            }
            return result;
        }
    }
}
