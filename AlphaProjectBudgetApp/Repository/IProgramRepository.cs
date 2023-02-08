using AlphaProjectBudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProjectBudgetApp.Repository
{
    public interface IProgramRepository
    {
        void AddProgram(Models.AlphaProjectBudgetApp program);
    }
}
