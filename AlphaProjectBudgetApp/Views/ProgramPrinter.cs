using AlphaProjectBudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProjectBudgetApp.Views
{
    
    public class ProgramPrinter : IPrinter<Programm>
    {
        
        public void Print(List<Programm> listOfPrograms)
        {
            Console.WriteLine("\n --------- List Of Programs: -------- \n");
            foreach (var item in listOfPrograms)
            {
                Console.WriteLine($"\nCode:{item.Code}\n Name: {item.Name}\n Start Date: {item.StartDate}\n End Date: {item.EndDate} \n  Duration: {item.Duration}" );
            }
        }
    }
}
