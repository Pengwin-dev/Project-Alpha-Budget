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
        AlphaProjectBudgetApp.Models.AlphaProjectBudgetApp programToRegister = new AlphaProjectBudgetApp.Models.AlphaProjectBudgetApp("Dev-v1", " ", firstDate, endDate);
        IProgramController programController = new ProgramController();
        // Act
        bool result = programController.RegisterProgram(programToRegister);
        // Assert
        Assert.IsTrue(result);
    }
}