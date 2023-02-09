using AlphaProjectBudgetApp;
using AlphaProjectBudgetApp.Controllers;
using AlphaProjectBudgetApp.Helpers;
using AlphaProjectBudgetApp.Models;
using AlphaProjectBudgetApp.Repository;
using AlphaProjectBudgetApp.Validator;
using Microsoft.VisualStudio.TestPlatform.TestHost;


namespace TestAlphaProjectBudgetl;


[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestWhenProgrammIsAddedToRepositoryReturnBool()
    {
        // Arrange
        DateTime startDate = DateTime.Parse("05/08/2023");
        DateTime endDate = DateTime.Parse("05/26/2023");

        Programm program = new Programm("Test", "" , startDate, endDate,3);
        IRepository<Programm> programRepository = new ProgramRepository();
        IDateValidator dateValidator = new AllValidator();
        ProgramController programController = new ProgramController(programRepository, dateValidator);
        
        // Act
        bool result = programController.AddToRepository(program);
        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestIfStartDateIsntOnMondayRegisterProgramReturnFalse()
    {
        // Arrange
        DateTime startDate = DateTime.Parse("05/10/2023"); //Wednseday
        DateTime endDate = DateTime.Parse("05/26/2023");
        Programm program = new Programm("Test", "", startDate, endDate,3);

        IRepository<Programm> programRepository = new ProgramRepository();
        IDateValidator dateValidator = new AllValidator();
        ProgramController programController = new ProgramController(programRepository, dateValidator);

        // Act
        bool result = programController.AddToRepository(program);
        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestIfEndDateIsntOnFridayRegisterProgramReturnFalse()
    {
        // Arrange
        DateTime startDate = DateTime.Parse("05/10/2023"); 
        DateTime endDate = DateTime.Parse("05/21/2023"); //Monday
        Programm program = new Programm("Test", "", startDate, endDate, 3);

        IRepository<Programm> programRepository = new ProgramRepository();
        IDateValidator dateValidator = new AllValidator();
        ProgramController programController = new ProgramController(programRepository, dateValidator);

        // Act
        bool result = programController.AddToRepository(program);
        // Assert
        Assert.IsFalse(result);
    }
    [TestMethod]
    public void TestWeekCalculatorReturnsCorrectData()
    {
        // Arrange
        DateTime startDate = DateTime.Parse("01/01/2023");
        DateTime endDate = DateTime.Parse("12/31/2023");
        WeekCalculator weekCalculator = new WeekCalculator();


        // Act
        int result = weekCalculator.calculateWeeks(startDate,endDate);
        // Assert
        Assert.AreEqual(result, 52);
    }

   

}