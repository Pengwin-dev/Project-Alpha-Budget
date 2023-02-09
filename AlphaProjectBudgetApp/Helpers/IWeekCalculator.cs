using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProjectBudgetApp.Helpers
{
    public interface IWeekCalculator
    {
        public int calculateWeeks(DateTime startDate, DateTime endDate);
        
    }
}
