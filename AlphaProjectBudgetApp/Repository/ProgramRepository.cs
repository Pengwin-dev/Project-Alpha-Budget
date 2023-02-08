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
        List<Models.Programm> programs = new List<Models.Programm>();

        public void AddProgram(Models.Programm program)
        {
            programs.Add(program);
        }
    }
}
