using AlphaProjectBudgetApp.Controllers;
using AlphaProjectBudgetApp.Models;
using AlphaProjectBudgetApp.Repository;
using AlphaProjectBudgetApp.Validator;
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
        public IRepository<Programm> programRepository;
        public ProgramController programControl; 
        public ProgramPrinter programPrinter;
        public IDateValidator dateValidator;
        
        public ProjectBudget() {
            programRepository = new ProgramRepository();
            dateValidator = new AllValidator();
            programControl = new ProgramController(programRepository,dateValidator);
            programPrinter = new ProgramPrinter();
            menu = new Menu(programControl, programPrinter);
        }
    }
}
