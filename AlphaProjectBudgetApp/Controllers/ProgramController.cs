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
            _programRepository = new ProgramRepository();
            _dateValidator = new AllValidator();
        }
        
            
        public bool RegisterProgram(Models.AlphaProjectBudgetApp programToRegister)
        {
            
            if (_dateValidator.ValidateOnMonday(programToRegister.StartDate) && _dateValidator.ValidateOnFriday(programToRegister.EndDate))
            {
                _programRepository.AddProgram(programToRegister);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
