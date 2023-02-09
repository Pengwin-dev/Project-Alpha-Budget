using AlphaProjectBudgetApp.Models;

namespace AlphaProjectBudgetApp.Views
{
    public interface IPrinter<T>
    {
        
        public void Print(List<T> listOfProgram);
    }
}