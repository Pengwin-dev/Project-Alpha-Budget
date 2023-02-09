using AlphaProjectBudgetApp.Controllers;
using AlphaProjectBudgetApp.Models;



namespace AlphaProjectBudgetApp.Views
{
    public class Menu
    {
        IRegistrationUI<Programm> programRegistrator;
        IController<Programm> programController;
        IPrinter<Programm> programPrinter;
        public Menu(IController<Programm> programController, ProgramPrinter programPrinter)
        {
            this.programRegistrator = new ProgramRegistration();
            this.programController = programController;
            this.programPrinter = programPrinter;
        }
        ///---------Menu.Show()--------\\\
        public void ShowMenu()
        {
            do
            {
                Console.WriteLine("Welcome to the Budget App");
                Console.WriteLine("1. Register a new Program");
                Console.WriteLine("2. List all Programs");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":

                        Programm program = programRegistrator.Register();

                        programController.AddToRepository(program);
                        break;
                    case "2":
                        List<Programm> listOfPrograms = programController.GetFromRepository();
                        programPrinter.Print(listOfPrograms);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (true);
        }
        
    }
}
