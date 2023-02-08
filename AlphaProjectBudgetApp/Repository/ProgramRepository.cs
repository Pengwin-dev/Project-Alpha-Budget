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
        List<Programm> programs = new List<Programm>();

        public void AddProgram(Programm program)
        {
            programs.Add(program);
        }
    }
}
