using AlphaProjectBudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProjectBudgetApp.Views
{
     public interface IRegisterMenu
    {
        public bool Register(Programm programToRegister);
    }
}
