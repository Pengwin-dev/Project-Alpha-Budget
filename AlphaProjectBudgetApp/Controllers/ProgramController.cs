using AlphaProjectBudgetApp.Models;
using AlphaProjectBudgetApp.Repository;
using AlphaProjectBudgetApp.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProjectBudgetApp.Controllers
{
    public class ProgramController : IProgramController
    {
        private IProgramRepository _programRepository;
        private IDateValidator _dateValidator;

        public ProgramController()
        {
            
        }
        public ProgramController(IProgramRepository programRepository, IDateValidator dateValidator)
        {
            _programRepository = programRepository;
            _dateValidator = dateValidator;
        }

        public void RegisterProgram(Programm programToRegister)
        {
            try
            {
                if (_dateValidator.ValidateOnMonday(programToRegister.StartDate) && _dateValidator.ValidateOnFriday(programToRegister.EndDate))
                {
                    _programRepository.AddProgram(programToRegister);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
