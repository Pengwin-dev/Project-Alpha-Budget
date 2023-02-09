using AlphaProjectBudgetApp;
using AlphaProjectBudgetApp.Controllers;
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
        DateTime firstDate = DateTime.Parse("05/08/2023");
        DateTime endDate = DateTime.Parse("05/26/2023");
        Programm program = new Programm("Test", "" ,firstDate, endDate);
        
        ProgramController programController = new ProgramController();
        
        // Act
        bool result = programController.AddToRepository(program);
        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestRegisterProgramReturnFalse()
    {
        // Arrange
        DateTime firstDate = DateTime.Parse("05/10/2023");
        DateTime endDate = DateTime.Parse("05/28/2023");
        Programm program = new Programm("Test", "", firstDate, endDate);

        ProgramController programController = new ProgramController();

        // Act
        bool result = programController.AddToRepository(program);
        // Assert
        Assert.IsFalse(result);
    }

}