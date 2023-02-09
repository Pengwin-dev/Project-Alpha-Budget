using AlphaProjectBudgetApp.Controllers;
using AlphaProjectBudgetApp.Repository;
using AlphaProjectBudgetApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProjectBudgetApp
{
    public class ProjectBudget
    {
        public Menu menu;
        public ProgramController programControl = new ProgramController();
        public ProgramRepository programRepository = new ProgramRepository();
        public ProgramPrinter programPrinter = new ProgramPrinter();
        public ProjectBudget() {
            menu = new Menu(programControl,programPrinter);
        
        }
    }
}
