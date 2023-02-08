using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProjectBudgetApp.Validator
{
    public interface IDateValidator
    {
        bool ValidateOnMonday(DateTime date);

        bool ValidateOnFriday(DateTime date);
    }
}
