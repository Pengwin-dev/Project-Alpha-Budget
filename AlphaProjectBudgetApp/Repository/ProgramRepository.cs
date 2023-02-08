using AlphaProjectBudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProjectBudgetApp.Repository
{
    public class ProgramRepository : IProgramRepository
    {
        List<Models.AlphaProjectBudgetApp> programs = new List<Models.AlphaProjectBudgetApp>();

        public void AddProgram(Models.AlphaProjectBudgetApp program)
        {
            programs.Add(program);
        }
    }
}
