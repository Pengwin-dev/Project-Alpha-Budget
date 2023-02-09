using AlphaProjectBudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProjectBudgetApp.Repository
{
    public class ProgramRepository : IRepository<Programm>
    {
        private List<Programm> programs = new List<Programm>();

        public void Add(Programm program)
        {
            programs.Add(program);
        }

        public List<Programm> GetList()
        {
            return programs;
        }
    }
}
