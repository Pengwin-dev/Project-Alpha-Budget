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
    public class ProgramController : IController<Programm>
    {
        private IRepository<Programm> programRepository;
        private IDateValidator dateValidator;

        public ProgramController()
        {
            this.programRepository = new ProgramRepository();
            this.dateValidator = new AllValidator();
        }


        public bool AddToRepository(Programm programToAdd)
        {
            bool added = false;
            if (dateValidator.ValidateOnMonday(programToAdd.StartDate) && dateValidator.ValidateOnFriday(programToAdd.EndDate))
            {
                programRepository.Add(programToAdd);
                added = true;

            }
            return added;
        }

        public List<Programm> GetFromRepository(){
            return programRepository.GetList();
        }
    }
}
