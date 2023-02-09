using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProjectBudgetApp.Helpers
{
    public class WeekCalculator : IWeekCalculator
    {
        public int calculateWeeks(DateTime startDate, DateTime endDate)
        {
            int result;
            TimeSpan diff = endDate - startDate;
            double totalDays = diff.TotalDays;
            double totalWeeks = totalDays / 7;
            result = (int)Math.Ceiling(totalWeeks);
            return result;
        }
    }
}
