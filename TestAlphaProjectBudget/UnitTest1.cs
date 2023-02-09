using AlphaProjectBudgetApp;
using AlphaProjectBudgetApp.Controllers;
using AlphaProjectBudgetApp.Helpers;
using AlphaProjectBudgetApp.Models;
using Microsoft.VisualStudio.TestPlatform.TestHost;


namespace TestAlphaProjectBudgetl;


[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestRegisterProgramReturnBool()
    {
        // Arrange
        DateTime startDate = DateTime.Parse("05/08/2023");
        DateTime endDate = DateTime.Parse("05/26/2023");

        Programm program = new Programm("Test", "" , startDate, endDate,3);
        
        ProgramController programController = new ProgramController();
        
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

        ProgramController programController = new ProgramController();

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

        ProgramController programController = new ProgramController();

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

    [TestMethod]
    public void TestProgramIsSavedAtRegistration()
    {
        // Arrange
        
        // Act
        // Assert
        
    }

}