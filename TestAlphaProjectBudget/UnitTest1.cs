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
        DateTime firstDate = DateTime.Parse("08/05/2023");
        DateTime endDate = DateTime.Parse("26/05/2023");
        Programm program = new Programm("Test", "" ,firstDate, endDate);
        
        ProgramController programController = new ProgramController();
        
        // Act
        bool result = programController.RegisterProgram(program);
        // Assert
        Assert.IsTrue(result);
    }
}