using AlphaProjectBudgetApp.Controllers;
using AlphaProjectBudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlphaProjectBudgetApp.Views
{
    public class Menu
    {
        public void Show()
        {
            
            Console.WriteLine("Welcome to the Budget App");
            Console.WriteLine("1. Register a new Program");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ProgramRegistration UIProgramRegistration = new ProgramRegistration();
                    Programm program = UIProgramRegistration.Show();
                    ProgramController programController = new ProgramController();
                    programController.RegisterProgram(program);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
        
    }
}
