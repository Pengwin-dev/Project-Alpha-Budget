using AlphaProjectBudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProjectBudgetApp.Controllers
{
    public interface IController<T>
    {
        bool AddToRepository(T toRegister);
        List<T> GetFromRepository();
    }
}
